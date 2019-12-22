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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new HataClassi("Kulanıcı hatası");
        }
    }
    public class HataClassi :Exception
    {
        private string _exception;
        public HataClassi(string exception):base(exception)
        {
            //this._exception = exception;
            hataAl(exception);
        }
        private void hataAl(string exception)
        {
            MessageBox.Show(exception);
        }

    }
}
