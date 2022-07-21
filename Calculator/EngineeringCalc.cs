using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class EngineeringCalc : Form
    {
        private const string odin = "1";
        private const string dva = "2";
        private const string tri = "3";
        private const string chetire = "4";
        private const string pyat = "5";
        private const string shest = "6";
        private const string sem = "7";
        private const string vosem = "8";
        private const string devyat = "9";
        private const string nul = "0";

        public EngineeringCalc()
        {
            InitializeComponent();
        }

        private void EngineeringCalc_Load(object sender, EventArgs e)
        {

        }

        private void btn_sbros_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.Sbros();
            txtOutput.Text = "0";
        }

        private void OrdinMenuItem_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.Show();
        }

        private void EngMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ravno_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(sem);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(vosem);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(devyat);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(chetire);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(pyat);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(shest);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(odin);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(dva);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(tri);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(nul);
        }

        private void btnChangesign_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
        }

        private void btn_Stepen_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Stepen);
        }

        private void btn_KvKoren_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.KvKoren);
        }

        private void btn_ObrZnachenie_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.ObrZnachenie);
        }

        private void btn_KvadratChisla_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.KvadratChisla);
        }
    }
}
