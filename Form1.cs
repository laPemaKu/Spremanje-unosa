using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Spremanje_kolekcija_u_datoteku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZaUnos_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"c:\Users\ucenik\Documents\3d\DatotekaUnosa.txt");
            sw.WriteLine(txtUnos.Text);
            sw.Close();
            txtUnos.Clear();
        }
    }
}
