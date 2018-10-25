using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attack_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_attack_Click(object sender, EventArgs e)
        {
            double dmg = 0;
            double mod = 0;
            int type = new Random().Next(6);
            double rnd = new Random().NextDouble();
            rnd = rnd < 0.85 ? 0.85 : rnd;
            double[] type_mod = new double[] { 0, 0.25, 0.5, 1, 2, 4 };

            double lvl;
            if (!double.TryParse(txt_lvl.Text, out lvl))
            {
                MessageBox.Show("The value you've entered for Level is incorrect.", "Error");
                return;
            }

            double pwr;
            if (!double.TryParse(txt_pwr.Text, out pwr))
            {
                MessageBox.Show("The value you've entered for Power is incorrect.", "Error");
                return;
            }

            double atk;
            if (!double.TryParse(txt_atk.Text, out atk))
            {
                MessageBox.Show("The value you've entered for Attack is incorrect.", "Error");
                return;
            }

            double def;
            if (!double.TryParse(txt_def.Text, out def))
            {
                MessageBox.Show("The value you've entered for Defence is incorrect.", "Error");
                return;
            }

            mod = (chkbox_list.GetItemChecked(0) ? 0.75 : 1) * (chkbox_list.GetItemChecked(1) ? 1.5 : 1) * (chkbox_list.GetItemChecked(2) ? 2 : 1) * (chkbox_list.GetItemChecked(3) ? 1.5 : 1) * type_mod[type] * rnd;
            dmg = ((((2 * lvl) / 5 + 2) * pwr * atk / def) / 50 + 2) * mod;

            lbl_dmg.Text = "Damage: "+(int)dmg;
        }
    }
}
