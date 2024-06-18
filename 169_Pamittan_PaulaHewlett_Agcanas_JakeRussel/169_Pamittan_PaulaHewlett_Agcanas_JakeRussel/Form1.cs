using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _169_Pamittan_PaulaHewlett_Agcanas_JakeRussel
{
    public partial class frmMotor : Form
    {

        double tax1 = 0.03;
        double tax2 = 0.11;
        double ADVinstallment = 274840.00;
        double PCXinstallment = 250400.00;
        double CLICKinstallment = 153800.00;
        double ADVcash = 168800.00;
        double PCXcash = 151800.00;
        double CLICKcash = 82800.00;
        double insurance = 4500.00;
        double registration = 3100.00;
        int months = 36;
        double total = 0.0;
        double payment = 0.0;
        double taxDeduction = 0.0;
        double taxTotal = 0.0;

        public frmMotor()
        {
            InitializeComponent();

         
    
            ComboBox cBox = new ComboBox();


            cboModel.Items.Add("ADV");
            cboModel.Items.Add("PCX");
            cboModel.Items.Add("CLICK");
            Controls.Add(cboModel);

            cboModel.SelectedIndexChanged += cboModel_SelectedIndexChanged;
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModel.SelectedIndex >= 0)
            {
                string selectedText = cboModel.SelectedItem.ToString();

                switch (selectedText)
                {
                    case "ADV":
                        txtCashValue.Text = ADVcash.ToString();
                        break;

                    case "PCX":
                        txtCashValue.Text = PCXcash.ToString();
                        break;

                    case "CLICK":
                        txtCashValue.Text = CLICKcash.ToString();
                        break;

                    default:
                        txtCashValue.Text = " ";
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkInstallment.Checked == false)
            {
            

                txtMonthlyPayment.Text = "Fully Paid";
                txtInsurance.Text = insurance.ToString();
                txtRegistration.Text = registration.ToString();

                double taxDeduction = Double.Parse(txtCashValue.Text) * tax1;
                txtTax.Text = taxDeduction.ToString();

               

            }
            else
            {

                string selectedText = cboModel.SelectedItem.ToString();

                switch (selectedText)
                {
                    case "ADV":
                       
                         taxDeduction = ADVinstallment * tax2;
                         taxTotal = ADVinstallment + taxDeduction;

                        txtMonthlyPayment.Text = (((taxTotal - Double.Parse(txtPayment.Text)) / months).ToString());

                        txtInsurance.Text = insurance.ToString();
                        txtRegistration.Text = registration.ToString();
                        txtTax.Text = taxDeduction.ToString();
                        break;

                    case "PCX":

                         taxDeduction = PCXinstallment * tax2;
                         taxTotal = PCXinstallment + taxDeduction;

                        txtMonthlyPayment.Text = (((taxTotal - Double.Parse(txtPayment.Text)) / months).ToString());

                        txtInsurance.Text = insurance.ToString();
                        txtRegistration.Text = registration.ToString();
                        txtTax.Text = taxDeduction.ToString();
                        break;

                    case "CLICK":

                         taxDeduction = CLICKinstallment * tax2;
                         taxTotal = CLICKinstallment + taxDeduction;

                        txtMonthlyPayment.Text = (((taxTotal - Double.Parse(txtPayment.Text)) / months).ToString());

                        txtInsurance.Text = insurance.ToString();
                        txtRegistration.Text = registration.ToString();
                        txtTax.Text = taxDeduction.ToString();
                        break;
                }
            }
        }

        private void chkInstallment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstallment.Checked)
            {
                txtPayment.ReadOnly = false;
            }

            else
            {
                txtPayment.ReadOnly = true;
            }
        }
    }
}
