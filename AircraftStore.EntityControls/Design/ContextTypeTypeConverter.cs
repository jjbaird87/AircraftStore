using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;

namespace EFWinforms.Design
{
    /// <summary>
    /// TypeConverter that shows a list of types that inherit from ObjectContext and
    /// can be assigned to the ObjectContextType property.
    /// </summary>
    public class DbContextTypeTypeConverter : ReferenceConverter
    {
        //----------------------------------------------------------------------------
        #region ** ctor

        public DbContextTypeTypeConverter()
            : base(typeof(Type))
        {
        }

        #endregion

        //----------------------------------------------------------------------------
        #region ** overrides

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<Type> values = new List<Type> {null};
            values.AddRange(GetDbContextTypes(context));

            // value for no data source

            // all types that derive from ObjectContext

            // done
            return new StandardValuesCollection(values);
        }
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var s = value as string;
            if (s != null)
            {
                var values = GetDbContextTypes(context);
                return values.FirstOrDefault(t => t.ToString() == s);
            }
            return base.ConvertFrom(context, culture, value);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is Type)
            {
                return value.ToString();
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        List<Type> GetDbContextTypes(ITypeDescriptorContext context)
        {
            var values = new List<Type>();
            var tds = context.GetService(typeof(ITypeDiscoveryService)) as ITypeDiscoveryService;
            if (tds != null)
            {
                values.AddRange(from Type t in tds.GetTypes(typeof (System.Data.Entity.DbContext), true) where t.IsPublic && t.IsVisible && !t.IsAbstract && t != typeof (System.Data.Entity.DbContext) select t);
            }
            return values;
        }

        #endregion
    }
}
