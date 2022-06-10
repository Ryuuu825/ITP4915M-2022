using System.ComponentModel;

namespace TheBetterLimited_Server.Helpers.Entity;

public class EntityValidator : IDisposable
{
    private readonly AssociatedMetadataTypeTypeDescriptionProvider _provider;

    private readonly Type _type;
    //TypeDescriptor.AddProviderTransparent(
    //        new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Data.Entity.Account)),
    //        typeof(Data.Entity.Account)
    //     );
    //    
    //bool valid = 

    public List<ValidationResult> _res;

    public EntityValidator(Type type)
    {
        _provider = new AssociatedMetadataTypeTypeDescriptionProvider(type);
        TypeDescriptor.AddProviderTransparent(
            _provider,
            type
        );
        _res = new List<ValidationResult>();
        _type = type;
    }

    public void Dispose()
    {
        TypeDescriptor.RemoveProviderTransparent(_provider, _type);
    }

    public bool Validate(object o)
    {
        return Validator.TryValidateObject(o, new ValidationContext(o), _res, true);
    }
    public static bool Validate<T>(object o, out string resultString)
    {
        bool res;
        StringBuilder _buffer = new StringBuilder();
        using (var v = new EntityValidator(typeof(T)))
        {
            v._res.Clear();
            res = v.Validate(o);
            foreach (var item in v._res)
            {
                _buffer.Append(item.ErrorMessage);
            }
        }

        resultString = _buffer.ToString();
        
        Console.WriteLine(resultString);
        Console.WriteLine(_buffer.ToString());
        return res;
    }
    public static bool Validate<T>(object o)
    {
        bool res;
        using (var v = new EntityValidator(typeof(T)))
        {
            res = v.Validate(o);
#if DEBUG
            foreach (var item in v._res)
            {
                ConsoleLogger.Error(item.ErrorMessage);
            }
#endif
        }

        return res;
    }

   
}