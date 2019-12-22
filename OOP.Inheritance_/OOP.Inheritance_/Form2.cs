using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Inheritance_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Base_Click(object sender, EventArgs e)
        {
            BasePhone @base = new BasePhone("alcatel", "kablolu");
            BasePhone phone = new BasePhone();
            phone.Brand = "Alcatel";
            phone.ConnectionType = "Kablolu";
            //  phone.PhoneType = "Ahizeli";
            MessageBox.Show($"Tel Markası : {phone.Brand}\nTelefon Bağlantı Türü : {phone.ConnectionType}\nTelefon tipi : {phone.PhoneType}Telefon Sesi : {phone.Sound()}");
        }

        private void Mobil_Click(object sender, EventArgs e)
        {
            MobilePhone mobil = new MobilePhone();
            mobil.Brand = "Nokia";
            mobil.ConnectionType = "Mobil";
            
            //  phone.PhoneType = "Ahizeli";
            MessageBox.Show($"Tel Markası : {mobil.Brand}\nTelefon Bağlantı Türü : {mobil.ConnectionType}\nTelefon tipi : {mobil.PhoneType}Telefon Sesi : {mobil.Sound()}");
        }

        private void Smart_Click(object sender, EventArgs e)
        {
            SmartPhone smart = new SmartPhone();
            smart.Brand = "Apple";
            smart.ConnectionType = "Mobil 5G";
            //  phone.PhoneType = "Ahizeli";
            MessageBox.Show($"Tel Markası : {smart.Brand}\nTelefon Bağlantı Türü : {smart.ConnectionType}\nTelefon tipi : {smart.PhoneType}Telefon Sesi : {smart.Sound()}");
        }
    }
}
