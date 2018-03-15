using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxBDC_Common
{
    public static class DataTypes
    {
        public static HashSet<Type> NumericTypes = new HashSet<Type>()
        {
            typeof(Byte),
            typeof(UInt16),
            typeof(UInt32),
            typeof(UInt64),
            typeof(SByte),
            typeof(Int16),
            typeof(Int32),
            typeof(Int64),
            typeof(Single),
            typeof(Double),
            typeof(Decimal)
        };

        public static bool IsNumericType (Type t)
        {
            return DataTypes.NumericTypes.Contains(t);
        }

        public static bool IsNumericType (this object o)
        {
            switch(Type.GetTypeCode(o.GetType()))
            {
                case TypeCode.Byte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return true;
                default:
                    return false;
            }
        }
    }
}
