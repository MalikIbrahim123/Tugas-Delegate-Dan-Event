//Malik Ibrahim
//21.11.4178
//IF05

using CalculatorApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FrmEntryCalculator : Form
    {
        public delegate void CreateUpdateEventHandler(ClassCalculator cal);
        public event CreateUpdateEventHandler OnCreate;
        private bool Masukan = true;
        private ClassCalculator cal;

        public FrmEntryCalculator()
        {
            InitializeComponent();
        }
        
        public FrmEntryCalculator(string title)
            : this()
        {
            this.Text= title;
        }

        private void FrmEntryCalculator_Load(object sender, EventArgs e)
        {
        }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (Masukan) cal = new ClassCalculator();

            if (txtNilaiA.Text == "" || txtNilaiB.Text == "")
            {
                MessageBox.Show("Data belum diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNilaiA.Focus();
            }

            else if (cmbOperasi.Text == "")
            {
                MessageBox.Show("Pilih Operasi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbOperasi.Focus();
            }

            else
            {
                if (cmbOperasi.Text == "Penjumlahan")
                {
                    cal.Hasil = "Hasil Penjumlahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) + int.Parse(txtNilaiB.Text));
                }

                else if (cmbOperasi.Text == "Pengurangan")
                {
                    cal.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) - int.Parse(txtNilaiB.Text));
                }

                else if (cmbOperasi.Text == "Perkalian")
                {
                    cal.Hasil = "Hasil Perkalian " + txtNilaiA.Text + " x " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) * int.Parse(txtNilaiB.Text));
                }

                else if (cmbOperasi.Text == "Pembagian")
                {
                    cal.Hasil = "Hasil Pembagian " + txtNilaiA.Text + " : " + txtNilaiB.Text + " = " + (Convert.ToDouble(txtNilaiA.Text) / Convert.ToDouble(txtNilaiB.Text));
                }

                if (Masukan)
                {
                    OnCreate(cal);
                }
            }
        }
    }
}
