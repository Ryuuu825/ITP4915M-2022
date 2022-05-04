using System;
using System.ComponentModel;

namespace TheBetterLimited_Server.Helpers.Sql
{
    public class EntityValidator : IDisposable
    {
        //TypeDescriptor.AddProviderTransparent(
        //        new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Data.Entity.Account)),
        //        typeof(Data.Entity.Account)
        //     );
        //    
        //bool valid = 

        public List<ValidationResult> res;

        private Type _type;
        private AssociatedMetadataTypeTypeDescriptionProvider _provider;
        public EntityValidator(Type type)
        {
            _provider = new AssociatedMetadataTypeTypeDescriptionProvider(type);
            TypeDescriptor.AddProviderTransparent(
                    _provider,
                    type
                 );
            res = new List<ValidationResult>();
            _type = type;
        }

        public void Dispose()
        {
            TypeDescriptor.RemoveProviderTransparent(_provider, _type);
        }

        public bool Validate(Object o)
        {
            if (o.GetType() != _type)
                return false;
            else
                return Validator.TryValidateObject( o, new ValidationContext(o), res, true);
        }


        public static bool Validate<T>(Object o)
        {
            bool res;
            using (EntityValidator v = new EntityValidator(typeof(T)))
            {
                res = v.Validate(o);
            }
            return res;
        }
    }
}

