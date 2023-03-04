using System;

namespace Utilitarios
{
    public static class clsExtensores
    {
        public static int ToInt(this string strText)
        {
            return int.Parse(strText);
        }

        public static decimal ToDouble(this string strText)
        {
            return Math.Round(Decimal.Parse(strText), 2);
        }
    }
}
