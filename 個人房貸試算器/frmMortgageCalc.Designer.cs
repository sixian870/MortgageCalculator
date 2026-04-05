namespace 個人房貸試算器
{
    partial class frmMortgageCalc
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.lblHousePriceUnit = new System.Windows.Forms.Label();
            this.grpDownPayment = new System.Windows.Forms.GroupBox();
            this.rdoDownPercent = new System.Windows.Forms.RadioButton();
            this.rdoDownAmount = new System.Windows.Forms.RadioButton();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.txtDownAmount = new System.Windows.Forms.TextBox();
            this.lblDownAmountUnit = new System.Windows.Forms.Label();
            this.lblDownPercentUnit = new System.Windows.Forms.Label();
            this.txtDownPercent = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblGracePeriodUnit = new System.Windows.Forms.Label();
            this.nudLoanTerm = new System.Windows.Forms.NumericUpDown();
            this.nudGracePeriod = new System.Windows.Forms.NumericUpDown();
            this.lblInterestRateUnit = new System.Windows.Forms.Label();
            this.lblLoanTermUnit = new System.Windows.Forms.Label();
            this.LoanAmount = new System.Windows.Forms.Label();
            this.MonthlyPay = new System.Windows.Forms.Label();
            this.FirstInterest = new System.Windows.Forms.Label();
            this.FirstPrincipal = new System.Windows.Forms.Label();
            this.TotalInterest = new System.Windows.Forms.Label();
            this.TotalRepayment = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblMonthlyPay = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.lblPS = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpDownPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGracePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.SystemColors.Window;
            this.grpInput.Controls.Add(this.lblLoanTermUnit);
            this.grpInput.Controls.Add(this.lblInterestRateUnit);
            this.grpInput.Controls.Add(this.nudGracePeriod);
            this.grpInput.Controls.Add(this.nudLoanTerm);
            this.grpInput.Controls.Add(this.lblGracePeriodUnit);
            this.grpInput.Controls.Add(this.txtInterestRate);
            this.grpInput.Controls.Add(this.txtHousePrice);
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Controls.Add(this.lblGracePeriod);
            this.grpInput.Controls.Add(this.lblLoanTerm);
            this.grpInput.Controls.Add(this.lblInterestRate);
            this.grpInput.Controls.Add(this.grpDownPayment);
            this.grpInput.Controls.Add(this.lblHousePriceUnit);
            this.grpInput.Controls.Add(this.lblHousePrice);
            this.grpInput.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpInput.ForeColor = System.Drawing.Color.SteelBlue;
            this.grpInput.Location = new System.Drawing.Point(35, 27);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(408, 496);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入房貸資訊";
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.SystemColors.Window;
            this.grpOutput.Controls.Add(this.lblPS);
            this.grpOutput.Controls.Add(this.lblTotalRepayment);
            this.grpOutput.Controls.Add(this.lblTotalInterest);
            this.grpOutput.Controls.Add(this.lblFirstPrincipal);
            this.grpOutput.Controls.Add(this.lblFirstInterest);
            this.grpOutput.Controls.Add(this.lblMonthlyPay);
            this.grpOutput.Controls.Add(this.lblLoanAmount);
            this.grpOutput.Controls.Add(this.btnClear);
            this.grpOutput.Controls.Add(this.TotalRepayment);
            this.grpOutput.Controls.Add(this.TotalInterest);
            this.grpOutput.Controls.Add(this.FirstPrincipal);
            this.grpOutput.Controls.Add(this.FirstInterest);
            this.grpOutput.Controls.Add(this.MonthlyPay);
            this.grpOutput.Controls.Add(this.LoanAmount);
            this.grpOutput.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.ForeColor = System.Drawing.Color.SteelBlue;
            this.grpOutput.Location = new System.Drawing.Point(468, 27);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(408, 496);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "計算結果";
            // 
            // lblHousePrice
            // 
            this.lblHousePrice.AutoSize = true;
            this.lblHousePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblHousePrice.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHousePrice.Location = new System.Drawing.Point(32, 50);
            this.lblHousePrice.Name = "lblHousePrice";
            this.lblHousePrice.Size = new System.Drawing.Size(102, 25);
            this.lblHousePrice.TabIndex = 0;
            this.lblHousePrice.Text = "房屋總價 :";
            // 
            // lblHousePriceUnit
            // 
            this.lblHousePriceUnit.AutoSize = true;
            this.lblHousePriceUnit.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHousePriceUnit.Location = new System.Drawing.Point(269, 50);
            this.lblHousePriceUnit.Name = "lblHousePriceUnit";
            this.lblHousePriceUnit.Size = new System.Drawing.Size(114, 25);
            this.lblHousePriceUnit.TabIndex = 1;
            this.lblHousePriceUnit.Text = "萬元 (NTD)";
            // 
            // grpDownPayment
            // 
            this.grpDownPayment.BackColor = System.Drawing.Color.AliceBlue;
            this.grpDownPayment.Controls.Add(this.txtDownPercent);
            this.grpDownPayment.Controls.Add(this.lblDownPercentUnit);
            this.grpDownPayment.Controls.Add(this.lblDownAmountUnit);
            this.grpDownPayment.Controls.Add(this.txtDownAmount);
            this.grpDownPayment.Controls.Add(this.rdoDownAmount);
            this.grpDownPayment.Controls.Add(this.rdoDownPercent);
            this.grpDownPayment.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpDownPayment.ForeColor = System.Drawing.Color.SteelBlue;
            this.grpDownPayment.Location = new System.Drawing.Point(26, 98);
            this.grpDownPayment.Name = "grpDownPayment";
            this.grpDownPayment.Size = new System.Drawing.Size(354, 149);
            this.grpDownPayment.TabIndex = 1;
            this.grpDownPayment.TabStop = false;
            this.grpDownPayment.Text = "自備款方式 :";
            // 
            // rdoDownPercent
            // 
            this.rdoDownPercent.AutoSize = true;
            this.rdoDownPercent.Checked = true;
            this.rdoDownPercent.Location = new System.Drawing.Point(21, 46);
            this.rdoDownPercent.Name = "rdoDownPercent";
            this.rdoDownPercent.Size = new System.Drawing.Size(87, 29);
            this.rdoDownPercent.TabIndex = 0;
            this.rdoDownPercent.TabStop = true;
            this.rdoDownPercent.Text = "比例 :";
            this.rdoDownPercent.UseVisualStyleBackColor = true;
            this.rdoDownPercent.CheckedChanged += new System.EventHandler(this.rdoDownPercent_CheckedChanged);
            // 
            // rdoDownAmount
            // 
            this.rdoDownAmount.AutoSize = true;
            this.rdoDownAmount.Location = new System.Drawing.Point(21, 95);
            this.rdoDownAmount.Name = "rdoDownAmount";
            this.rdoDownAmount.Size = new System.Drawing.Size(87, 29);
            this.rdoDownAmount.TabIndex = 1;
            this.rdoDownAmount.TabStop = true;
            this.rdoDownAmount.Text = "金額 :";
            this.rdoDownAmount.UseVisualStyleBackColor = true;
            this.rdoDownAmount.CheckedChanged += new System.EventHandler(this.rdoDownAmount_CheckedChanged);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.BackColor = System.Drawing.Color.Transparent;
            this.lblInterestRate.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInterestRate.Location = new System.Drawing.Point(32, 272);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(102, 25);
            this.lblInterestRate.TabIndex = 3;
            this.lblInterestRate.Text = "貸款利率 :";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.BackColor = System.Drawing.Color.Transparent;
            this.lblLoanTerm.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoanTerm.Location = new System.Drawing.Point(32, 320);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(102, 25);
            this.lblLoanTerm.TabIndex = 4;
            this.lblLoanTerm.Text = "貸款年限 :";
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.AutoSize = true;
            this.lblGracePeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblGracePeriod.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGracePeriod.Location = new System.Drawing.Point(32, 368);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.Size = new System.Drawing.Size(82, 25);
            this.lblGracePeriod.TabIndex = 5;
            this.lblGracePeriod.Text = "寬限期 :";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRun.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRun.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRun.Location = new System.Drawing.Point(139, 429);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(124, 47);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "開始計算";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHousePrice.Location = new System.Drawing.Point(140, 47);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(123, 34);
            this.txtHousePrice.TabIndex = 0;
            this.txtHousePrice.Text = "1000";
            // 
            // txtDownAmount
            // 
            this.txtDownAmount.Location = new System.Drawing.Point(114, 94);
            this.txtDownAmount.Name = "txtDownAmount";
            this.txtDownAmount.Size = new System.Drawing.Size(123, 34);
            this.txtDownAmount.TabIndex = 2;
            // 
            // lblDownAmountUnit
            // 
            this.lblDownAmountUnit.AutoSize = true;
            this.lblDownAmountUnit.Location = new System.Drawing.Point(243, 97);
            this.lblDownAmountUnit.Name = "lblDownAmountUnit";
            this.lblDownAmountUnit.Size = new System.Drawing.Size(52, 25);
            this.lblDownAmountUnit.TabIndex = 10;
            this.lblDownAmountUnit.Text = "萬元";
            // 
            // lblDownPercentUnit
            // 
            this.lblDownPercentUnit.AutoSize = true;
            this.lblDownPercentUnit.Location = new System.Drawing.Point(243, 48);
            this.lblDownPercentUnit.Name = "lblDownPercentUnit";
            this.lblDownPercentUnit.Size = new System.Drawing.Size(30, 25);
            this.lblDownPercentUnit.TabIndex = 11;
            this.lblDownPercentUnit.Text = "%";
            // 
            // txtDownPercent
            // 
            this.txtDownPercent.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPercent.Location = new System.Drawing.Point(114, 45);
            this.txtDownPercent.Name = "txtDownPercent";
            this.txtDownPercent.Size = new System.Drawing.Size(123, 34);
            this.txtDownPercent.TabIndex = 1;
            this.txtDownPercent.Text = "20";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInterestRate.Location = new System.Drawing.Point(140, 269);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(123, 34);
            this.txtInterestRate.TabIndex = 2;
            this.txtInterestRate.Text = "2.15";
            // 
            // lblGracePeriodUnit
            // 
            this.lblGracePeriodUnit.AutoSize = true;
            this.lblGracePeriodUnit.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGracePeriodUnit.Location = new System.Drawing.Point(269, 367);
            this.lblGracePeriodUnit.Name = "lblGracePeriodUnit";
            this.lblGracePeriodUnit.Size = new System.Drawing.Size(91, 25);
            this.lblGracePeriodUnit.TabIndex = 13;
            this.lblGracePeriodUnit.Text = "年 (選填)";
            // 
            // nudLoanTerm
            // 
            this.nudLoanTerm.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudLoanTerm.Location = new System.Drawing.Point(140, 318);
            this.nudLoanTerm.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLoanTerm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoanTerm.Name = "nudLoanTerm";
            this.nudLoanTerm.Size = new System.Drawing.Size(123, 34);
            this.nudLoanTerm.TabIndex = 3;
            this.nudLoanTerm.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nudGracePeriod
            // 
            this.nudGracePeriod.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudGracePeriod.Location = new System.Drawing.Point(139, 366);
            this.nudGracePeriod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGracePeriod.Name = "nudGracePeriod";
            this.nudGracePeriod.Size = new System.Drawing.Size(124, 34);
            this.nudGracePeriod.TabIndex = 4;
            // 
            // lblInterestRateUnit
            // 
            this.lblInterestRateUnit.AutoSize = true;
            this.lblInterestRateUnit.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInterestRateUnit.Location = new System.Drawing.Point(269, 272);
            this.lblInterestRateUnit.Name = "lblInterestRateUnit";
            this.lblInterestRateUnit.Size = new System.Drawing.Size(30, 25);
            this.lblInterestRateUnit.TabIndex = 16;
            this.lblInterestRateUnit.Text = "%";
            // 
            // lblLoanTermUnit
            // 
            this.lblLoanTermUnit.AutoSize = true;
            this.lblLoanTermUnit.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoanTermUnit.Location = new System.Drawing.Point(269, 320);
            this.lblLoanTermUnit.Name = "lblLoanTermUnit";
            this.lblLoanTermUnit.Size = new System.Drawing.Size(32, 25);
            this.lblLoanTermUnit.TabIndex = 17;
            this.lblLoanTermUnit.Text = "年";
            // 
            // LoanAmount
            // 
            this.LoanAmount.AutoSize = true;
            this.LoanAmount.BackColor = System.Drawing.Color.Transparent;
            this.LoanAmount.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LoanAmount.Location = new System.Drawing.Point(30, 50);
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.Size = new System.Drawing.Size(122, 25);
            this.LoanAmount.TabIndex = 1;
            this.LoanAmount.Text = "貸款總金額 :";
            // 
            // MonthlyPay
            // 
            this.MonthlyPay.AutoSize = true;
            this.MonthlyPay.BackColor = System.Drawing.Color.Transparent;
            this.MonthlyPay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MonthlyPay.Location = new System.Drawing.Point(30, 194);
            this.MonthlyPay.Name = "MonthlyPay";
            this.MonthlyPay.Size = new System.Drawing.Size(122, 25);
            this.MonthlyPay.TabIndex = 2;
            this.MonthlyPay.Text = "每月應繳額 :";
            // 
            // FirstInterest
            // 
            this.FirstInterest.AutoSize = true;
            this.FirstInterest.BackColor = System.Drawing.Color.Transparent;
            this.FirstInterest.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FirstInterest.Location = new System.Drawing.Point(30, 98);
            this.FirstInterest.Name = "FirstInterest";
            this.FirstInterest.Size = new System.Drawing.Size(102, 25);
            this.FirstInterest.TabIndex = 3;
            this.FirstInterest.Text = "首期利息 :";
            // 
            // FirstPrincipal
            // 
            this.FirstPrincipal.AutoSize = true;
            this.FirstPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.FirstPrincipal.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FirstPrincipal.Location = new System.Drawing.Point(30, 146);
            this.FirstPrincipal.Name = "FirstPrincipal";
            this.FirstPrincipal.Size = new System.Drawing.Size(102, 25);
            this.FirstPrincipal.TabIndex = 4;
            this.FirstPrincipal.Text = "首期本金 :";
            // 
            // TotalInterest
            // 
            this.TotalInterest.AutoSize = true;
            this.TotalInterest.BackColor = System.Drawing.Color.Transparent;
            this.TotalInterest.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalInterest.Location = new System.Drawing.Point(30, 242);
            this.TotalInterest.Name = "TotalInterest";
            this.TotalInterest.Size = new System.Drawing.Size(122, 25);
            this.TotalInterest.TabIndex = 5;
            this.TotalInterest.Text = "總利息支出 :";
            // 
            // TotalRepayment
            // 
            this.TotalRepayment.AutoSize = true;
            this.TotalRepayment.BackColor = System.Drawing.Color.Transparent;
            this.TotalRepayment.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalRepayment.Location = new System.Drawing.Point(30, 290);
            this.TotalRepayment.Name = "TotalRepayment";
            this.TotalRepayment.Size = new System.Drawing.Size(122, 25);
            this.TotalRepayment.TabIndex = 6;
            this.TotalRepayment.Text = "總還款金額 :";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(146, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 47);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.lblLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoanAmount.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoanAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblLoanAmount.Location = new System.Drawing.Point(159, 50);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(219, 25);
            this.lblLoanAmount.TabIndex = 8;
            this.lblLoanAmount.Text = "$ 0";
            // 
            // lblMonthlyPay
            // 
            this.lblMonthlyPay.BackColor = System.Drawing.Color.AliceBlue;
            this.lblMonthlyPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthlyPay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthlyPay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMonthlyPay.Location = new System.Drawing.Point(159, 194);
            this.lblMonthlyPay.Name = "lblMonthlyPay";
            this.lblMonthlyPay.Size = new System.Drawing.Size(219, 25);
            this.lblMonthlyPay.TabIndex = 9;
            this.lblMonthlyPay.Text = "$ 0";
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.BackColor = System.Drawing.Color.AliceBlue;
            this.lblFirstInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstInterest.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstInterest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFirstInterest.Location = new System.Drawing.Point(159, 98);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(219, 25);
            this.lblFirstInterest.TabIndex = 10;
            this.lblFirstInterest.Text = "$ 0";
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            this.lblFirstPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstPrincipal.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstPrincipal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFirstPrincipal.Location = new System.Drawing.Point(159, 146);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(219, 25);
            this.lblFirstPrincipal.TabIndex = 11;
            this.lblFirstPrincipal.Text = "$ 0";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTotalInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalInterest.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalInterest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalInterest.Location = new System.Drawing.Point(159, 242);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(219, 25);
            this.lblTotalInterest.TabIndex = 12;
            this.lblTotalInterest.Text = "$ 0";
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTotalRepayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalRepayment.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalRepayment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalRepayment.Location = new System.Drawing.Point(159, 290);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.Size = new System.Drawing.Size(219, 25);
            this.lblTotalRepayment.TabIndex = 13;
            this.lblTotalRepayment.Text = "$ 0";
            // 
            // lblPS
            // 
            this.lblPS.BackColor = System.Drawing.Color.Transparent;
            this.lblPS.Font = new System.Drawing.Font("微軟正黑體", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPS.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPS.Location = new System.Drawing.Point(36, 341);
            this.lblPS.Name = "lblPS";
            this.lblPS.Size = new System.Drawing.Size(342, 87);
            this.lblPS.TabIndex = 14;
            this.lblPS.Text = "*小提醒：寬限期內每月只需負擔利息；試算結果顯示之每月應繳額為寬限期過後恢復本息攤還之數值。";
            // 
            // frmMortgageCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(915, 552);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Name = "frmMortgageCalc";
            this.Text = "個人房貸試算器";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpDownPayment.ResumeLayout(false);
            this.grpDownPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGracePeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblHousePriceUnit;
        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.GroupBox grpDownPayment;
        private System.Windows.Forms.RadioButton rdoDownAmount;
        private System.Windows.Forms.RadioButton rdoDownPercent;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblGracePeriod;
        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.Label lblDownAmountUnit;
        private System.Windows.Forms.TextBox txtDownAmount;
        private System.Windows.Forms.Label lblDownPercentUnit;
        private System.Windows.Forms.TextBox txtDownPercent;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblGracePeriodUnit;
        private System.Windows.Forms.NumericUpDown nudLoanTerm;
        private System.Windows.Forms.NumericUpDown nudGracePeriod;
        private System.Windows.Forms.Label lblInterestRateUnit;
        private System.Windows.Forms.Label lblLoanTermUnit;
        private System.Windows.Forms.Label MonthlyPay;
        private System.Windows.Forms.Label LoanAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label TotalRepayment;
        private System.Windows.Forms.Label TotalInterest;
        private System.Windows.Forms.Label FirstPrincipal;
        private System.Windows.Forms.Label FirstInterest;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblMonthlyPay;
        private System.Windows.Forms.Label lblPS;
    }
}

