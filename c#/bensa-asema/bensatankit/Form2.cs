using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Huoltoaseman_bensatankit
{
    public partial class tilausLomake : Form
    {
        Form1 paaLomake;
        string saldo95 = "";
        string saldo98 = "";
        string saldoDi = "";

        public tilausLomake(Form1 f1)
        {
            InitializeComponent();
            paaLomake = f1;
            teeTilaus.Click += tilaa;
        }

        private void tilaa(object sender, EventArgs e)
        {
            int s, k;
            try
            {
                k = int.Parse(tilausmaara.Text);
                if (radioButton95.Checked)
                {
                    s = int.Parse(saldo95);
                    s = s + k;
                    paaLomake.paivita95Saldo("" + s);
                    this.saldo95 = "" + s;
                }
                if (radioButton98.Checked)
                {
                    s = int.Parse(saldo98);
                    s = s + k;
                    paaLomake.paivita98Saldo("" + s);
                    this.saldo98 = "" + s;
                }
                if (radioButtonDi.Checked)
                {
                    s = int.Parse(saldoDi);
                    s = s + k;
                    paaLomake.paivitaDiSaldo("" + s);
                    this.saldoDi = "" + s;
                }

            }
            catch (Exception ex)
            {
                tilausmaara.Text = "";
            }
        }

        public void setSaldot(string saldo95, string saldo98, string saldoDi)
        {
            this.saldo95 = saldo95;
            this.saldo98 = saldo98;
            this.saldoDi = saldoDi;
        }

        public tilausLomake()
        {
            InitializeComponent();
        }

    }
}
