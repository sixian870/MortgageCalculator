using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 個人房貸試算器
{
    public partial class frmMortgageCalc : Form
    {
        public frmMortgageCalc()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            bool isHousePrice = decimal.TryParse(txtHousePrice.Text, out decimal housePrice);
            bool isDownPercent = decimal.TryParse(txtDownPercent.Text, out decimal downPercent);
            bool isDownAmount=decimal.TryParse(txtDownAmount.Text, out decimal downAmount);
            bool isInterestRate = decimal.TryParse(txtInterestRate.Text, out decimal interestRate);

            if (!isHousePrice || housePrice <= 0)
            {
                MessageBox.Show("請輸入正確的房屋總價（必須為正數）", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHousePrice.Focus();
                return;
            }

            decimal downPayment = 0; // 要先宣告
            if (rdoDownPercent.Checked)
            {
                if (!isDownPercent || downPercent < 0 || downPercent > 100)
                {
                    MessageBox.Show("請輸入正確的頭期款百分比（0~100%）", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDownPercent.Focus();
                    return;
                }
                downPayment = housePrice * 10000 * (downPercent / 100);
            }
            else if (rdoDownAmount.Checked)
            {
                if (!isDownAmount || downAmount < 0 || downAmount >= housePrice)
                {
                    MessageBox.Show("請輸入正確的頭期款金額（必須為正數且小於房屋總價）", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDownAmount.Focus();
                    return;
                }
                downPayment = downAmount * 10000;
            }

            if (!isInterestRate || interestRate <= 0 || interestRate > 20)
            {
                MessageBox.Show("請輸入合理的年利率 (0~20%)", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInterestRate.Focus();
                return;
            }

            int loanTerm = (int)nudLoanTerm.Value;
            int gracePeriod = (int)nudGracePeriod.Value;
            if (gracePeriod >= loanTerm)
            {
                MessageBox.Show("寬限期必須小於貸款年限", "邏輯錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal loanAmount = (housePrice * 10000) - downPayment; // 貸款總金額 = 房屋總價 - 自備款
            decimal monthlyRate = (interestRate / 100) / 12; // 月利率 = 年利率 / 12
            int totalMonths = loanTerm * 12; // 總期數 = 貸款年限 * 12個月
            int graceMonths = gracePeriod * 12; // 寬限期月數 = 寬限期年數 * 12個月
            int paymentMonths = totalMonths - graceMonths; // 剩餘還款月數 = 總期數 - 寬限期月數

            // 本息平均攤還
            double r = (double)monthlyRate;
            double n = (double)paymentMonths;
            decimal monthlyPayment = 0;

            // 月付金額
            if (r > 0)
            {
                decimal factor = (decimal)Math.Pow(1 + r, n);
                monthlyPayment = loanAmount * monthlyRate * factor / (factor - 1);
            }
            else
            {
                monthlyPayment = loanAmount / paymentMonths;
            }

            // 首期
            decimal firstMonthInterest = loanAmount * monthlyRate;
            decimal firstMonthPrincipal = (graceMonths > 0) ? 0 : monthlyPayment - firstMonthInterest;

            // 總支出
            decimal totalInterest = (firstMonthInterest * graceMonths) + (monthlyPayment * paymentMonths) - loanAmount;
            decimal totalRepayment = loanAmount + totalInterest;

            // Output
            lblLoanAmount.Text = $"$ {loanAmount:N2}";
            lblMonthlyPay.Text = $"$ {monthlyPayment:N2}";
            lblFirstInterest.Text = $"$ {firstMonthInterest:N2}";
            lblFirstPrincipal.Text = $"$ {firstMonthPrincipal:N2}";
            lblTotalInterest.Text = $"$ {totalInterest:N2}";
            lblTotalRepayment.Text = $"$ {totalRepayment:N2}";
        }

        private void rdoDownPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDownPercent.Checked)
            {
                txtDownPercent.Enabled = true;
                txtDownAmount.Enabled = false;
                txtDownAmount.Clear();
                txtDownPercent.Focus();
            }
        }

        private void rdoDownAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDownAmount.Checked)
            {
                txtDownAmount.Enabled = true;
                txtDownPercent.Enabled = false;
                txtDownPercent.Clear();
                txtDownAmount.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHousePrice.Clear();
            txtDownPercent.Clear();
            txtDownAmount.Clear();
            txtInterestRate.Clear();

            nudLoanTerm.Value = 30;
            nudGracePeriod.Value = 0;

            rdoDownPercent.Checked = true;
            txtDownPercent.Enabled = true;
            rdoDownAmount.Checked = false;
            txtDownAmount.Enabled = false;

            lblLoanAmount.Text = "$ 0";
            lblMonthlyPay.Text = "$ 0";
            lblFirstInterest.Text = "$ 0";
            lblFirstPrincipal.Text = "$ 0";
            lblTotalInterest.Text = "$ 0";
            lblTotalRepayment.Text = "$ 0";

            txtHousePrice.Focus();
        }
    }
}
