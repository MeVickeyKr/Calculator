using System;


namespace Calc_Funcs
{
    public class Perform_Calc
    {

        public static dynamic Perform_Add(dynamic obj1, dynamic obj2)
        {
            try
            {
                dynamic d1 = ConvertTONUmeric(obj1);
                dynamic d2 = ConvertTONUmeric(obj2);
                return d1 + d2;
            }
            catch (Exception )
            {
                return "not a valid type";
            }
        }
        public static dynamic Perform_Sub(dynamic obj1, dynamic obj2)
        {
            try
            {
                dynamic d1 = ConvertTONUmeric(obj1);
                dynamic d2 = ConvertTONUmeric(obj2);
                return d1 - d2;
            }
            catch (Exception )
            {
                return "not a valid type";
            }

        }
        public static dynamic Perform_Mul(dynamic obj1, dynamic obj2)
        {
            try
            {
                dynamic d1 = ConvertTONUmeric(obj1);
                dynamic d2 = ConvertTONUmeric(obj2);
                return d1 * d2;
            }
            catch (Exception )
            {
                return "not a valid type";
            }
        }
        public static dynamic Perform_Div(dynamic obj1, dynamic obj2)
        {
            try
            {
                dynamic d1 = ConvertTONUmeric(obj1);
                dynamic d2 = ConvertTONUmeric(obj2);

                return d1 / d2;
            }
            catch (Exception)
            {
                return "not a valid type";
            }
        }
        private static dynamic ConvertTONUmeric(dynamic value)
        {
            if(value == null)
            {
                throw new ArgumentNullException("value");
            }
            if(value is string s) 
            {
                return double.Parse(s);
            }
            if(value is IConvertible)
            {
                return Convert.ChangeType(value, typeof(double));
            }
            return "invalid type";
        }
    }
}
