
namespace HeartRate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.firstTB = new System.Windows.Forms.TextBox();
            this.femaleCB = new System.Windows.Forms.CheckBox();
            this.birthdateDTP = new System.Windows.Forms.DateTimePicker();
            this.activeCB = new System.Windows.Forms.CheckBox();
            this.activityLevelCB = new System.Windows.Forms.ComboBox();
            this.mhrTB = new System.Windows.Forms.TextBox();
            this.targetMinTB = new System.Windows.Forms.TextBox();
            this.targetMaxTB = new System.Windows.Forms.TextBox();
            this.customerLB = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resultSS = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Is Female:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthdate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Is Activ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Activity Levl:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "MHR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Target Minimum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Target Maximum:";
            // 
            // firstTB
            // 
            this.firstTB.Location = new System.Drawing.Point(119, 19);
            this.firstTB.Name = "firstTB";
            this.firstTB.Size = new System.Drawing.Size(100, 29);
            this.firstTB.TabIndex = 8;
            // 
            // femaleCB
            // 
            this.femaleCB.AutoSize = true;
            this.femaleCB.Location = new System.Drawing.Point(143, 78);
            this.femaleCB.Name = "femaleCB";
            this.femaleCB.Size = new System.Drawing.Size(15, 14);
            this.femaleCB.TabIndex = 9;
            this.femaleCB.UseVisualStyleBackColor = true;
            // 
            // birthdateDTP
            // 
            this.birthdateDTP.Location = new System.Drawing.Point(328, 427);
            this.birthdateDTP.Name = "birthdateDTP";
            this.birthdateDTP.Size = new System.Drawing.Size(288, 29);
            this.birthdateDTP.TabIndex = 10;
            // 
            // activeCB
            // 
            this.activeCB.AutoSize = true;
            this.activeCB.Location = new System.Drawing.Point(143, 178);
            this.activeCB.Name = "activeCB";
            this.activeCB.Size = new System.Drawing.Size(15, 14);
            this.activeCB.TabIndex = 11;
            this.activeCB.UseVisualStyleBackColor = true;
            // 
            // activityLevelCB
            // 
            this.activityLevelCB.FormattingEnabled = true;
            this.activityLevelCB.Items.AddRange(new object[] {
            "Sedentary",
            "Minimal",
            "Sporadic",
            "Regular",
            "High"});
            this.activityLevelCB.Location = new System.Drawing.Point(122, 223);
            this.activityLevelCB.Name = "activityLevelCB";
            this.activityLevelCB.Size = new System.Drawing.Size(121, 29);
            this.activityLevelCB.TabIndex = 12;
            // 
            // mhrTB
            // 
            this.mhrTB.Location = new System.Drawing.Point(597, 16);
            this.mhrTB.Name = "mhrTB";
            this.mhrTB.Size = new System.Drawing.Size(100, 29);
            this.mhrTB.TabIndex = 13;
            // 
            // targetMinTB
            // 
            this.targetMinTB.Location = new System.Drawing.Point(581, 56);
            this.targetMinTB.Name = "targetMinTB";
            this.targetMinTB.Size = new System.Drawing.Size(100, 29);
            this.targetMinTB.TabIndex = 14;
            // 
            // targetMaxTB
            // 
            this.targetMaxTB.Location = new System.Drawing.Point(597, 101);
            this.targetMaxTB.Name = "targetMaxTB";
            this.targetMaxTB.Size = new System.Drawing.Size(100, 29);
            this.targetMaxTB.TabIndex = 15;
            // 
            // customerLB
            // 
            this.customerLB.FormattingEnabled = true;
            this.customerLB.ItemHeight = 21;
            this.customerLB.Location = new System.Drawing.Point(24, 340);
            this.customerLB.Name = "customerLB";
            this.customerLB.Size = new System.Drawing.Size(901, 193);
            this.customerLB.TabIndex = 16;
            this.customerLB.SelectedIndexChanged += new System.EventHandler(this.customerLB_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(24, 276);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(99, 40);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(144, 285);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 31);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // resultSS
            // 
            this.resultSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.resultSS.Location = new System.Drawing.Point(0, 554);
            this.resultSS.Name = "resultSS";
            this.resultSS.Size = new System.Drawing.Size(937, 22);
            this.resultSS.TabIndex = 20;
            this.resultSS.Text = "resultSS";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(39, 17);
            this.statusLbl.Text = "Ready";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(24, 560);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 21);
            this.resultLbl.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Age:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 576);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.resultSS);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.customerLB);
            this.Controls.Add(this.targetMaxTB);
            this.Controls.Add(this.targetMinTB);
            this.Controls.Add(this.mhrTB);
            this.Controls.Add(this.activityLevelCB);
            this.Controls.Add(this.activeCB);
            this.Controls.Add(this.femaleCB);
            this.Controls.Add(this.firstTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdateDTP);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "XINF 10009 Hart Rate";
            this.resultSS.ResumeLayout(false);
            this.resultSS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstTB;
        private System.Windows.Forms.CheckBox femaleCB;
        private System.Windows.Forms.DateTimePicker birthdateDTP;
        private System.Windows.Forms.CheckBox activeCB;
        private System.Windows.Forms.ComboBox activityLevelCB;
        private System.Windows.Forms.TextBox mhrTB;
        private System.Windows.Forms.TextBox targetMinTB;
        private System.Windows.Forms.TextBox targetMaxTB;
        private System.Windows.Forms.ListBox customerLB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.StatusStrip resultSS;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}

