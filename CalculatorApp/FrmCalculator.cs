//Malik Ibrahim
//21.11.4178
//IF05

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
    public partial class FrmCalculator : Form
    {
        private IList<ClassCalculator> ListOfCalculator = new List<ClassCalculator>();
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void FrmEntry_OnCreate(ClassCalculator cal)
        {
            ListOfCalculator.Add(cal);
            lstHasil.Items.Add(cal.Hasil);
        }

        private void lstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmEntryCalculator frmEntry = new FrmEntryCalculator("Calculator");
            frmEntry.OnCreate += FrmEntry_OnCreate;
            frmEntry.ShowDialog();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
        }
    }
}
