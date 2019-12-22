using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.extented_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var sinif = new Class1();
        }
    }
    public static class Clear
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
