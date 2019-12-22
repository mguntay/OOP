using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Class_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FirstClass firstClass = new FirstClass();
            /*firstClass.isim = "muammer";
            firstClass.soyisim = "güntay";
            firstClass.telefon = "5555555555";
            firstClass.mail = "guntay11@gmail.com";
            firstClass.adres = "deneme adressss";*/

            firstClass.Ad = "muammer";
            firstClass.Soyad = "güntay";
            firstClass.Telefon = "5555555555";
            firstClass.Mail = "guntay11@gmail.com";
            firstClass.Adres = "deneme adressss";
        }
    }
}
