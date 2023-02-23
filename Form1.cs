using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinGeorgiMitev
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void btnFinalise_Click(object sender, EventArgs e)
        {
            string worksphere = "";
            string pol = "";
            string firstname = textBoxFirstName.Text;
            string lastname = textBoxLastName.Text;
            string egn = textBoxEGN.Text;
            if (!string.IsNullOrEmpty(cmbBox.Text))
            {
                worksphere = cmbBox.Text;
            }
            else
            {
                MessageBox.Show("Не си избрал сфера на работа.");
                cmbBox.Focus();
                return;
            }
            if (rdButtonMan.Checked)
            {
                pol = rdButtonMan.Text;
            }
            if (rdButtonWoman.Checked)
            {
                pol = rdButtonWoman.Text;
            }
            if (textBoxFirstName.Text == "")
            {
                MessageBox.Show("Не си въвел име.");
            }
            if (textBoxLastName.Text == "")
            {
                MessageBox.Show("Не си въвел фамилия.");
            }
            if (textBoxEGN.Text == "")
            {
                MessageBox.Show("Не си въвел EGN.");
            }
            DialogResult result = MessageBox.Show($"Име: {firstname} Фамилия: {lastname}, ЕГН: {egn}." + $"Пол: \"{pol}\"" + $"Сфера на работа: {worksphere}", "Потвърждавате ли?", MessageBoxButtons.YesNo);
        }

        
    }
}