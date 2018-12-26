using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intro_pizzaciSiparisEkrani
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnsiparisekle_Click(object sender, EventArgs e)
		{

			StringBuilder sb = new StringBuilder();

   

		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			listBoxsiparis.SelectedItems.Clear();
		}

		private void listboxcesit_SelectedIndexChanged(object sender, EventArgs e)
		{
			decimal tutar = 0;


			if (comboboxebat.SelectedIndex == 0)
			{
				if ((listboxcesit.SelectedIndex == 0 || listboxcesit.SelectedIndex == 1))
				{
					tutar += 30;
				}
				if ((listboxcesit.SelectedIndex == 2 || listboxcesit.SelectedIndex == 3 ||
				listboxcesit.SelectedIndex == 4))
				{
					tutar += 35;
				}
				if ((listboxcesit.SelectedIndex == 5 || listboxcesit.SelectedIndex == 6))
				{
					tutar += 40;
				}
				lbltoplamtutar.Text = (tutar * numericUpDown1.Value).ToString();
			}



			else if (comboboxebat.SelectedIndex == 1)
			{
				if ((listboxcesit.SelectedIndex == 0 || listboxcesit.SelectedIndex == 1))
				{
					tutar += 18;
				}
				if ((listboxcesit.SelectedIndex == 2 || listboxcesit.SelectedIndex == 3 ||
				listboxcesit.SelectedIndex == 4))
				{
					tutar += 21;
				}
				if ((listboxcesit.SelectedIndex == 5 || listboxcesit.SelectedIndex == 6))
				{
					tutar += 24;
				}
				lbltoplamtutar.Text = (tutar * numericUpDown1.Value).ToString();
			}



			else if (comboboxebat.SelectedIndex == 2)
			{
				if ((listboxcesit.SelectedIndex == 0 || listboxcesit.SelectedIndex == 1))
				{
					tutar += 12;
				}
				if ((listboxcesit.SelectedIndex == 2 || listboxcesit.SelectedIndex == 3 ||
				listboxcesit.SelectedIndex == 4))
				{
					tutar += 14;
				}
				if ((listboxcesit.SelectedIndex == 5 || listboxcesit.SelectedIndex == 6))
				{
					tutar += 16;
				}
				lbltoplamtutar.Text = (tutar * numericUpDown1.Value).ToString();
			}



			if (checkBoxancuez.Checked)
			{
				tutar += 0.5M;
			}
			if (checkBoxjalepeno.Checked)
			{
				tutar += 0.5M;
			}
			if (checkBoxsalam.Checked)
			{
				tutar += 0.5M;
			}
			if (checkBoxsosis.Checked)
			{
				tutar += 0.5M;
			}
			if (checkBoxsucuk.Checked)
			{
				tutar += 0.5M;
			}
			if (checkBoxzeytin.Checked)
			{
				tutar += 0.5M;
			}
			lbltoplamtutar.Text = (tutar * numericUpDown1.Value).ToString();
		}
	}
}
