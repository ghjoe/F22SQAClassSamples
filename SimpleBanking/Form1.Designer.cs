namespace SimpleBanking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstTB = new System.Windows.Forms.TextBox();
            this.lastTB = new System.Windows.Forms.TextBox();
            this.chequingBtn = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.createBtn = new System.Windows.Forms.Button();
            this.accountsLB = new System.Windows.Forms.ListBox();
            this.transactionNUD = new System.Windows.Forms.NumericUpDown();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.overdraftTB = new System.Windows.Forms.TextBox();
            this.interestTB = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.transactionNUD)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstTB
            // 
            this.firstTB.Location = new System.Drawing.Point(95, 14);
            this.firstTB.Name = "firstTB";
            this.firstTB.Size = new System.Drawing.Size(100, 23);
            this.firstTB.TabIndex = 0;
            // 
            // lastTB
            // 
            this.lastTB.Location = new System.Drawing.Point(241, 14);
            this.lastTB.Name = "lastTB";
            this.lastTB.Size = new System.Drawing.Size(100, 23);
            this.lastTB.TabIndex = 1;
            // 
            // chequingBtn
            // 
            this.chequingBtn.AutoSize = true;
            this.chequingBtn.Checked = true;
            this.chequingBtn.Location = new System.Drawing.Point(94, 59);
            this.chequingBtn.Name = "chequingBtn";
            this.chequingBtn.Size = new System.Drawing.Size(77, 19);
            this.chequingBtn.TabIndex = 2;
            this.chequingBtn.TabStop = true;
            this.chequingBtn.Text = "Chequing";
            this.chequingBtn.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(239, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Savings";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(93, 110);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(95, 40);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // accountsLB
            // 
            this.accountsLB.FormattingEnabled = true;
            this.accountsLB.ItemHeight = 15;
            this.accountsLB.Location = new System.Drawing.Point(99, 190);
            this.accountsLB.Name = "accountsLB";
            this.accountsLB.Size = new System.Drawing.Size(370, 94);
            this.accountsLB.TabIndex = 5;
            this.accountsLB.SelectedIndexChanged += new System.EventHandler(this.accountsLB_SelectedIndexChanged);
            // 
            // transactionNUD
            // 
            this.transactionNUD.Location = new System.Drawing.Point(515, 32);
            this.transactionNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.transactionNUD.Name = "transactionNUD";
            this.transactionNUD.Size = new System.Drawing.Size(120, 23);
            this.transactionNUD.TabIndex = 6;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(515, 97);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(95, 40);
            this.depositButton.TabIndex = 7;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(644, 97);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(95, 40);
            this.withdrawBtn.TabIndex = 8;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Overdraft Fee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Interest Earned:";
            // 
            // balanceTB
            // 
            this.balanceTB.Location = new System.Drawing.Point(622, 182);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.ReadOnly = true;
            this.balanceTB.Size = new System.Drawing.Size(100, 23);
            this.balanceTB.TabIndex = 12;
            // 
            // overdraftTB
            // 
            this.overdraftTB.Location = new System.Drawing.Point(622, 226);
            this.overdraftTB.Name = "overdraftTB";
            this.overdraftTB.ReadOnly = true;
            this.overdraftTB.Size = new System.Drawing.Size(100, 23);
            this.overdraftTB.TabIndex = 13;
            // 
            // interestTB
            // 
            this.interestTB.Location = new System.Drawing.Point(622, 261);
            this.interestTB.Name = "interestTB";
            this.interestTB.ReadOnly = true;
            this.interestTB.Size = new System.Drawing.Size(100, 23);
            this.interestTB.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.interestTB);
            this.Controls.Add(this.overdraftTB);
            this.Controls.Add(this.balanceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.transactionNUD);
            this.Controls.Add(this.accountsLB);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.chequingBtn);
            this.Controls.Add(this.lastTB);
            this.Controls.Add(this.firstTB);
            this.Name = "Form1";
            this.Text = "SQA Simple Banking";
            ((System.ComponentModel.ISupportInitialize)(this.transactionNUD)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstTB;
        private TextBox lastTB;
        private RadioButton chequingBtn;
        private RadioButton radioButton2;
        private Button createBtn;
        private ListBox accountsLB;
        private NumericUpDown transactionNUD;
        private Button depositButton;
        private Button withdrawBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox balanceTB;
        private TextBox overdraftTB;
        private TextBox interestTB;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLbl;
    }
}