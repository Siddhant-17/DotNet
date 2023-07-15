using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_DOTNET
{
    internal class DataTypes
    {
        static void Main(string[] args)
        {
            //there are 15 data type in .NET

            /*
             * Struct value type         CTS dataype
             */
            byte b1;                  //System.Byte          1byte
            sbyte b2;                 //System.Byte          1byte
            char c1;                 //System.Char           2 byte(stored unicode)
            short s1;                //System.Int16          2 byte
            ushort us2;              //System.UInt16         2 byte
            int i;                   //System.Int32          4 byte
            uint ui1;                //System.UInt32         4 byte
            long l1;                 //System.Int64          8 byte
            ulong ul1;               //System.UInt64         8 byte

            float f1;                //System.Single         4 byte
            
            double d1;               //System.Double         8 byte
            decimal dec;             //System.Decimal        16  byte        (Large)
            bool status;             //System.Boolean


            /*
             * Reference Type
             */
            String str;              //System.String  
            Object o;                //System.Object
        }
    }
}
