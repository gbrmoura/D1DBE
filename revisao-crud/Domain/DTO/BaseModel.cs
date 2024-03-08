using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public void SetPropertyValue(object instance, string strPropertyName, string newValue)
        {
            var type = instance.GetType();
            var prop = type.GetProperty(strPropertyName);

            if (prop.PropertyType == typeof(DateTime)) 
            { 
                prop.SetValue(instance, DateTime.Parse(newValue), null);
                return;
            }

            if (prop.PropertyType == typeof(int))
            {
                prop.SetValue(instance, Convert.ToInt32(newValue), null);
                return;
            }

            if (prop.PropertyType == typeof(double))
            {
                prop.SetValue(instance, Convert.ToDouble(newValue), null);
                return;
            }

            prop.SetValue(instance, newValue, null);
        }

    }
}
