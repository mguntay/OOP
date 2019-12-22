using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPP.referenceValueType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class ogrenci
        {
            public string firstName { get; set; }
            public string LastName { get; set; }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ogrenci ogr1 = new ogrenci();
            ogr1.firstName = "Muammer";
            ogr1.LastName = "Güntay";

            ogrenci ogr2 = ogr1;
            ogr2.firstName = "deneme";
            MessageBox.Show($"ilkİsim{ogr1.firstName} ikinciİsim:{ogr2.firstName}");
            int[] sayılar = { 1, 2, 3, 4 };+-

        }

        struct student
        {
            public string firstName { get; set; }
            public string LastName { get; set; }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            student ogr1 = new student();
            ogr1.firstName = "Muammer";
            ogr1.LastName = "Güntay";

            student ogr2 = ogr1;
            ogr2.firstName = "deneme";
            MessageBox.Show($"ilkİsim{ogr1.firstName} ikinciİsim:{ogr2.firstName}");
        }
    }
}
