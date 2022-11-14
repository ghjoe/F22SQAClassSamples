namespace BMIExceptions
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
            this.heightTB = new System.Windows.Forms.TextBox();
            this.weightTB = new System.Windows.Forms.TextBox();
            this.bmiTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.countLbl = new System.Windows.Forms.Label();
            this.heightNUD = new System.Windows.Forms.NumericUpDown();
            this.massNUD = new System.Windows.Forms.NumericUpDown();
            this.bmiTB2 = new System.Windows.Forms.TextBox();
            this.calculateBtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heightNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(120, 32);
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(100, 23);
            this.heightTB.TabIndex = 0;
            // 
            // weightTB
            // 
            this.weightTB.Location = new System.Drawing.Point(118, 77);
            this.weightTB.Name = "weightTB";
            this.weightTB.Size = new System.Drawing.Size(100, 23);
            this.weightTB.TabIndex = 1;
            // 
            // bmiTB
            // 
            this.bmiTB.Location = new System.Drawing.Point(120, 120);
            this.bmiTB.Name = "bmiTB";
            this.bmiTB.Size = new System.Drawing.Size(100, 23);
            this.bmiTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mass:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "BMI:";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(126, 169);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(125, 209);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(64, 15);
            this.countLbl.TabIndex = 7;
            this.countLbl.Text = "BMI Count";
            // 
            // heightNUD
            // 
            this.heightNUD.Location = new System.Drawing.Point(281, 34);
            this.heightNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNUD.Name = "heightNUD";
            this.heightNUD.Size = new System.Drawing.Size(120, 23);
            this.heightNUD.TabIndex = 8;
            this.heightNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // massNUD
            // 
            this.massNUD.Location = new System.Drawing.Point(281, 77);
            this.massNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.massNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.massNUD.Name = "massNUD";
            this.massNUD.Size = new System.Drawing.Size(120, 23);
            this.massNUD.TabIndex = 9;
            this.massNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bmiTB2
            // 
            this.bmiTB2.Location = new System.Drawing.Point(283, 120);
            this.bmiTB2.Name = "bmiTB2";
            this.bmiTB2.ReadOnly = true;
            this.bmiTB2.Size = new System.Drawing.Size(100, 23);
            this.bmiTB2.TabIndex = 10;
            // 
            // calculateBtn2
            // 
            this.calculateBtn2.Location = new System.Drawing.Point(286, 169);
            this.calculateBtn2.Name = "calculateBtn2";
            this.calculateBtn2.Size = new System.Drawing.Size(177, 23);
            this.calculateBtn2.TabIndex = 11;
            this.calculateBtn2.Text = "Calculate with Better Controls";
            this.calculateBtn2.UseVisualStyleBackColor = true;
            this.calculateBtn2.Click += new System.EventHandler(this.calculateBtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateBtn2);
            this.Controls.Add(this.bmiTB2);
            this.Controls.Add(this.massNUD);
            this.Controls.Add(this.heightNUD);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bmiTB);
            this.Controls.Add(this.weightTB);
            this.Controls.Add(this.heightTB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.heightNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox heightTB;
        private TextBox weightTB;
        private TextBox bmiTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button calculateBtn;
        private Label countLbl;
        private NumericUpDown heightNUD;
        private NumericUpDown massNUD;
        private TextBox bmiTB2;
        private Button calculateBtn2;
    }
}