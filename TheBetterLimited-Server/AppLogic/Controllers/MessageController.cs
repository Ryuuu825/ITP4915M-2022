using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Data.Dto;


namespace TheBetterLimited_Server.AppLogic.Controllers;

public class MessageController
{

    private readonly DataContext _db;

    private readonly Data.Repositories.Repository<Data.Entity.Message> _sendMessageTable;
    private readonly Data.Repositories.Repository<Data.Entity.Staff_Message> _receiveMessageTable;
    private readonly Data.Repositories.Repository<Data.Entity.Account> _accountTable;

    public MessageController(DataContext dataContext)
    {
        _db = dataContext;
        _sendMessageTable = new Data.Repositories.Repository<Data.Entity.Message>(dataContext);
        _receiveMessageTable = new Data.Repositories.Repository<Data.Entity.Staff_Message>(dataContext);
        _accountTable = new Data.Repositories.Repository<Data.Entity.Account>(dataContext);
    }

    public Models.ReceiveMessageModel GetMessage(string username , uint limit = 0 )
    {
        
        var account = _accountTable.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Data.Entity.Account>($"UserName:{username}" )
        ).FirstOrDefault();

        if (account is null)
        {
            throw new BadArgException("Account is not exist in database.");
        }

        var messages = _receiveMessageTable.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Data.Entity.Staff_Message>($"_receiverId:{account.Id}" )
        ).OrderByDescending( m => m.message.SentDate ).ToList();

        // do not show error message if the limit is not valid
        if (limit != 0 && limit < messages.Count)
        {
            messages = messages.GetRange(0 , (int)limit);
        }

        List<ReceiveMessageDto> messageList = new List<ReceiveMessageDto>();
        foreach (var message in messages)
        {
            messageList.Add(new ReceiveMessageDto
            {
                senderName = message.message.sender.UserName,
                sentDate = message.message.SentDate.ToShortDateString(),
                content = message.message.Content
                
            });
        }
        var messageModel = new Models.ReceiveMessageModel
        {
            messageReceived = (short)messages.Count,
            messages = messageList
        };

        return messageModel;
    }

    public Models.ReceiveMessageModel GetUnReadMessage(string username)
    {
        
        var account = _accountTable.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Data.Entity.Account>($"UserName:{username}")
        ).FirstOrDefault();

        if (account is null)
        {
            throw new BadArgException("Account is not exist in database.");
        }

        var messages = _receiveMessageTable.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Data.Entity.Staff_Message>($"_receiverId:{account.Id}" )
        );

        List<ReceiveMessageDto> messageList = new List<ReceiveMessageDto>();
        foreach (var message in messages)
        {
           if (message.Status == Data.Entity.StaffMessageStatus.Unread)
            {
                message.Status = Data.Entity.StaffMessageStatus.Read;
                _receiveMessageTable.Update(message);

                messageList.Add(new ReceiveMessageDto
                {
                    senderName = message.message.sender.UserName,
                    sentDate = message.message.SentDate.ToShortDateString(),
                    content = message.message.Content

                });
            }
        }
        try
        {
            _db.SaveChanges();
        }
        catch (System.Exception)
        {
            throw new OperationFailException("Cannot update message status.");
        }

        Models.ReceiveMessageModel messageModel = new Models.ReceiveMessageModel
        {
            messageReceived = (short)messageList.Count,
            messages = messageList
        };

        return messageModel;
    }
    
    public void SendMessage(string SenderUserName , Data.Dto.SendMessageDto message)
    {
        var account = _accountTable.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Data.Entity.Account>($"UserName:{SenderUserName}" )
        ).FirstOrDefault();

        if (account is null)
        {
            throw new BadArgException("Account is not exist in database.");
        }

        var newMessage = new Data.Entity.Message
        {
            Title = message.Title,
            Content = message.content,
            SentDate = DateTime.Now,
            _senderId = account.Id,
            sender = account,
            Id = Helpers.Secure.RandomId.GetID(10)
        };

        _sendMessageTable.Add(newMessage);
        _db.SaveChanges();


        bool isFailed = false;
        StringBuilder failedUsername = new StringBuilder();

        foreach (var recevier in message.receiver)
        {
            var acc = _accountTable.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Data.Entity.Account>($"UserName:{recevier}" )
            ).FirstOrDefault();
            
            var receiverMessage = new Data.Entity.Staff_Message
            {
                _receiverId = acc.Id,
                message = newMessage,
                _messageId = newMessage.Id,
            };
            try
            {
                _receiveMessageTable.Add(receiverMessage);
            }
            catch (System.Exception e)
            {
                ConsoleLogger.Debug(e.Message);
                ConsoleLogger.Debug(e.InnerException);

                isFailed = true;
                failedUsername.Append(recevier + ", ");
            }
        }

        if (isFailed)
        {
            throw new BadArgException("Some user is not exist in database. " + failedUsername.ToString());
        }

        try
        {
            _db.SaveChanges();

        }catch(Exception e)
        {
            throw new OperationFailException("Send message failed.");
        }

        
    }

    
}