using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop._struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kitap kitap;
        private void Class_Click(object sender, EventArgs e)
        {
            kitap = new Kitap();
            kitap.KitapAdi = "Fakirler";
            kitap.YayinEvi = "Türkiye";
            kitap.YazarAdi = "Tesla";
            kitap.SayfaSayisi = 1;
        }

        Book book;
        private void Struct_Click(object sender, EventArgs e)
        {
            book.KitapAdi = "Züğürtler";
            book.YayinEvi = "Apple";
            book.YazarAdi = "mac pro";
            book.SayfaSayisi = 1;
        }
    }
}
