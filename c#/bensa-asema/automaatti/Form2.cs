using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maksuautomaatti_ja_mittari
{
    public partial class maksuLomake : Form
    {
        Form1 paaLomake;
        public maksuLomake(Form1 f1)
        {
            InitializeComponent();
            paaLomake = f1;
            okNappi.Click += tarkistaPIN;
            vahvistaMaksu.Click += maksa;

        }

        private void maksa(object sender, EventArgs e)
        {
            paaLomake.paivitaMaksu();
            this.Close();
        }

        private void tarkistaPIN(object sender, EventArgs e)
        {
            //Tarkistetaan onko PIN-koodi numero. Jos on, niin maksu voidaan hyväksyä
            try
            {
                int k = int.Parse(pinkoodi.Text);
                vahvistaMaksu.Enabled = true;
            }
            //Jos koodi ei ole numero, tyhjätään kenttä
            catch(Exception ex)
            {
                pinkoodi.Text = "";
            }
        }

        public maksuLomake()
        {
            InitializeComponent();
        }
    }
}
