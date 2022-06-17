using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Data.Dto;


namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class AppointmentController
    {      
        protected readonly Data.DataContext db;
        protected Data.Repositories.Repository<Appointment> repository;
        protected Data.Repositories.Repository<SalesOrderItem_Appointment> _SalesOrderItem_AppointmentTable;
        protected Data.Repositories.Repository<Account> _AccTable;
        protected Data.Repositories.Repository<SalesOrder> _SalesOrderTable;
        protected Data.Repositories.Repository<Team> _TeamTable;
        protected readonly Type DtoType;

        public AppointmentController(Data.DataContext dataContext)
        {
            db = dataContext;
            repository = new Data.Repositories.Repository<Appointment>(dataContext);
            _SalesOrderItem_AppointmentTable = new Data.Repositories.Repository<SalesOrderItem_Appointment>(dataContext);
            _AccTable = new Data.Repositories.Repository<Account>(dataContext);
            _SalesOrderTable = new Data.Repositories.Repository<SalesOrder>(dataContext);
            _TeamTable = new Data.Repositories.Repository<Team>(dataContext);
        }

        public void AssignTeam(string id , string teamId)
        {
            Appointment appointment = repository.GetById(id);
            if (appointment is null)
            {
                throw new Exceptions.BadArgException("Appointment not found");
            }

            // appointment._teamId = teamId;

            // check if the team is assigned to another appointment in the same session
            Session? appointmentSessoion = appointment.Session; 
            // there should not be any chance that the session is null
            // but c# nullable is such a pain 

            if (appointmentSessoion is null)
            {
                throw new Exceptions.BadArgException("Appointment session not found");
            }

            List<Appointment> appointmentsInThatSession = repository.GetBySQL(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Appointment>($"_sessionId:{appointmentSessoion.ID}")
            );

            foreach ( var app in appointmentsInThatSession )
            {
                if (app._teamId == teamId)
                {
                    throw new Exceptions.BadArgException("Team is already assigned to another appointment in the same session");
                }
            }

            appointment._teamId = teamId;

            try 
            {
                repository.Update(appointment);
            }
            catch (System.Exception ex)
            {
                throw new Exceptions.BadForeignKeyException("Team id is not valid");
            }
        }

        public class Dto : Data.Dto.AppointmentOutDto
        {
           public string sessionId { get; set; }
           public string orderId { get; set; }

           public Customer customer { get; set; }
           public Hashtable? team { get; set; }
           public string salesOrderStatus  { get; set; }
        }

        public async Task<List<Dto>> GetAppointment(string UserName , int day, int month)
        {
            Staff usr = (await _AccTable.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{UserName}")
            )).FirstOrDefault().Staff;
            List<Appointment> res = repository.GetAll().Where(x => x.Session.Date.Day == day && x.Session.Date.Month == month && x.Session._departmentId == usr._departmentId).ToList();
            return await ToDto(res);
        }
        public async Task<List<Dto>> ToDto(List<Appointment> list)
        {
            /*
                public class AppointmentOutDto 
                {
                    public string AppointmentId { get; set; }
                    public DateTime Date { get; set;}
                    public DateTime StartTime { get; set;}
                    public DateTime EndTime { get; set;}
                    public List<SalesOrderItem_AppointmentOutDto>? Items { get; set; }
                }
            */

            List<Dto> res = new List<Dto>();
            foreach( var item in list )
            {
                // all items in the appointment
                List<SalesOrderItem_Appointment> items = _SalesOrderItem_AppointmentTable.GetAll().Where(x => x._appointmentId== item.ID).ToList();
                List<Goods> localizedGoods = new List<Goods>();
                foreach (var goods in items)
                {
                    localizedGoods.Add(Helpers.Localizer.TryLocalize("en" , goods.SalesOrderItem.SupplierGoodsStock.Supplier_Goods.Goods));
                }
                List<SalesOrderItem_AppointmentOutDto> itemsDto = new List<SalesOrderItem_AppointmentOutDto>();
                for (int i = 0 ; i < items.Count ; i++)
                {
                    itemsDto.Add(new SalesOrderItem_AppointmentOutDto
                    {
                        ItemNames = localizedGoods[i].Name,
                        ItemsId = items[i].SalesOrderItem.Id
                    });
                }

                try
                {
                    OrderController.UpdateOrderStatus(items[0] , _SalesOrderTable);
                    // if the appointment is installation appointment
                    // and the delivery appointment is completed

                    SalesOrderStatus status = items[0].SalesOrderItem.SalesOrder.Status;

                    var orderId = items[0].SalesOrderItem._salesOrderId;

                    res.Add(
                        new Dto
                        {
                            AppointmentId = item.ID,
                            Date = item.Session.Date,
                            StartTime = item.Session.StartTime,
                            EndTime = item.Session.EndTime,
                            Items = itemsDto,
                            sessionId = item.Session.ID,
                            customer = item.Customer,
                            team = item.Team.MapToDto(),
                            salesOrderStatus = items[0].SalesOrderItem.SalesOrder.Status.ToString(),
                            orderId = orderId
                        }
                    );
                }catch(Exception e)
                {
                    continue; 
                }

            }
            return res;
        }
        
    }
}