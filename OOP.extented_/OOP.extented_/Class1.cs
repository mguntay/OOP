using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.extented_
{
    public static class Class1
    {
            /*   public static string Mail(string param)
               {
                   param = param.ToLower()
                       .Replace("ğ", "g")
                       .Replace("ç", "c")
                       .Replace("ü", "u")
                       .Replace("ı", "i")
                       .Replace("ö", "ö")
                       .Replace("ş", "s");
                   return param;
               }*/
            public static string Mail(this String param)
            {
                param = param.ToLower()
                    .Replace("ğ", "g")
                    .Replace("ç", "c")
                    .Replace("ü", "u")
                    .Replace("ı", "i")
                    .Replace("ö", "ö")
                    .Replace("ş", "s");
                return param;
            }            
    }

}
