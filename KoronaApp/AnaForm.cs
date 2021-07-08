using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoronaApp
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            HosgeldingForm hosgeldingForm = new HosgeldingForm();
            hosgeldingForm.MdiParent = this; //Ana Form oldugunu belirttik.this=Ana Form 'u ifade ediyor.
            hosgeldingForm.WindowState = FormWindowState.Maximized;//Formu kaplamasini sagliyoruz.
            hosgeldingForm.Show();//Ana Formun icinde gosterdik.
        }

        private void yardimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardimForm yardimForm = new YardimForm();//Formlar birer class olduklarindan newlemek gerek.
            yardimForm.Show();//Yardim formunu ekranda gosterir.
        }
    }
}
