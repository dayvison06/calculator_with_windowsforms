namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnCross = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.Nb1 = new System.Windows.Forms.Button();
            this.Nb2 = new System.Windows.Forms.Button();
            this.Nb3 = new System.Windows.Forms.Button();
            this.Nb4 = new System.Windows.Forms.Button();
            this.Nb5 = new System.Windows.Forms.Button();
            this.Nb6 = new System.Windows.Forms.Button();
            this.Nb7 = new System.Windows.Forms.Button();
            this.Nb8 = new System.Windows.Forms.Button();
            this.Nb9 = new System.Windows.Forms.Button();
            this.txtPanel = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(217)))), ((int)(((byte)(88)))));
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(185, 178);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 36);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnLess
            // 
            this.btnLess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(217)))), ((int)(((byte)(88)))));
            this.btnLess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLess.FlatAppearance.BorderSize = 0;
            this.btnLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLess.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLess.Location = new System.Drawing.Point(231, 178);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(40, 36);
            this.btnLess.TabIndex = 4;
            this.btnLess.Text = "-";
            this.btnLess.UseVisualStyleBackColor = false;
            this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
            // 
            // btnCross
            // 
            this.btnCross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(217)))), ((int)(((byte)(88)))));
            this.btnCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCross.FlatAppearance.BorderSize = 0;
            this.btnCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCross.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCross.Location = new System.Drawing.Point(185, 220);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(40, 36);
            this.btnCross.TabIndex = 5;
            this.btnCross.Text = "x";
            this.btnCross.UseVisualStyleBackColor = false;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(217)))), ((int)(((byte)(88)))));
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivision.Location = new System.Drawing.Point(185, 263);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(40, 36);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(217)))), ((int)(((byte)(88)))));
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResult.Location = new System.Drawing.Point(231, 221);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(40, 78);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Nb1
            // 
            this.Nb1.BackColor = System.Drawing.Color.White;
            this.Nb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nb1.FlatAppearance.BorderSize = 0;
            this.Nb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nb1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nb1.Location = new System.Drawing.Point(26, 178);
            this.Nb1.Name = "Nb1";
            this.Nb1.Size = new System.Drawing.Size(47, 36);
            this.Nb1.TabIndex = 9;
            this.Nb1.Text = "1";
            this.Nb1.UseVisualStyleBackColor = false;
            this.Nb1.Click += new System.EventHandler(this.Nb1_Click);
            // 
            // Nb2
            // 
            this.Nb2.BackColor = System.Drawing.Color.White;
            this.Nb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nb2.FlatAppearance.BorderSize = 0;
            this.Nb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nb2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nb2.Location = new System.Drawing.Point(79, 178);
            this.Nb2.Name = "Nb2";
            this.Nb2.Size = new System.Drawing.Size(47, 36);
            this.Nb2.TabIndex = 10;
            this.Nb2.Text = "2";
            this.Nb2.UseVisualStyleBackColor = false;
            this.Nb2.Click += new System.EventHandler(this.Nb2_Click);
            // 
            // Nb3
            // 
            this.Nb3.BackColor = System.Drawing.Color.White;
            this.Nb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nb3.FlatAppearance.BorderSize = 0;
            this.Nb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nb3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nb3.Location = new System.Drawing.Point(132, 178);
            this.Nb3.Name = "Nb3";
            this.Nb3.Size = new System.Drawing.Size(47, 36);
            this.Nb3.TabIndex = 11;
            this.Nb3.Text = "3";
            this.Nb3.UseVisualStyleBackColor = false;
            this.Nb3.Click += new System.EventHandler(this.Nb3_Click);
            // 
            // Nb4
            // 
            this.Nb4.BackColor = System.Drawing.Color.White;
            this.Nb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nb4.FlatAppearance.BorderSize = 0;
            this.Nb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nb4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nb4.Location = new System.Drawing.Point(26, 220);
            this.Nb4.Name = "Nb4";
            this.Nb4.Size = new System.Drawing.Size(47, 36);
            this.Nb4.TabIndex = 12;
            this.Nb4.Text = "4";
            this.Nb4.UseVisualStyleBackColor = false;
            this.Nb4.Click += new System.EventHandler(this.Nb4_Click);
            // 
            // Nb5
            // 
            this.Nb5.BackColor = System.Drawing.Color.White;
            this.Nb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nb5.FlatAppearance.BorderSize = 0;
            this.Nb5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nb5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nb5.Location = new System.Drawing.Point(79, 220);
            this.Nb5.Name = "Nb5";
            this.Nb5.Size = new System.Drawing.Size(47, 36);
            this.Nb5.TabIndex = 13;
            this.Nb5.Text = "5";
            this.Nb5.UseVisualStyleBackColor = false;
            this.Nb5.Click += new System.EventHandler(this.Nb5_Click);
            // 
            // Nb6
            // 
            this.Nb6.BackColor = System.Drawing.Color.White;
            this.Nb6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nb6.FlatAppearance.BorderSize = 0;
            this.Nb6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nb6.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nb6.Location = new System.Drawing.Point(132, 220);
            this.Nb6.Name = "Nb6";
            this.Nb6.Size = new System.Drawing.Size(47, 36);
            this.Nb6.TabIndex = 14;
            this.Nb6.Text = "6";
            this.Nb6.UseVisualStyleBackColor = false;
            this.Nb6.Click += new System.EventHandler(this.Nb6_Click);
            // 
            // Nb7
            // 
            this.Nb7.BackColor = System.Drawing.Color.White;
            this.Nb7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nb7.FlatAppearance.BorderSize = 0;
            this.Nb7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nb7.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nb7.Location = new System.Drawing.Point(26, 262);
            this.Nb7.Name = "Nb7";
            this.Nb7.Size = new System.Drawing.Size(47, 36);
            this.Nb7.TabIndex = 15;
            this.Nb7.Text = "7";
            this.Nb7.UseVisualStyleBackColor = false;
            this.Nb7.Click += new System.EventHandler(this.Nb7_Click);
            // 
            // Nb8
            // 
            this.Nb8.BackColor = System.Drawing.Color.White;
            this.Nb8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nb8.FlatAppearance.BorderSize = 0;
            this.Nb8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nb8.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nb8.Location = new System.Drawing.Point(79, 262);
            this.Nb8.Name = "Nb8";
            this.Nb8.Size = new System.Drawing.Size(47, 36);
            this.Nb8.TabIndex = 16;
            this.Nb8.Text = "8";
            this.Nb8.UseVisualStyleBackColor = false;
            this.Nb8.Click += new System.EventHandler(this.Nb8_Click);
            // 
            // Nb9
            // 
            this.Nb9.BackColor = System.Drawing.Color.White;
            this.Nb9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nb9.FlatAppearance.BorderSize = 0;
            this.Nb9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nb9.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nb9.Location = new System.Drawing.Point(132, 262);
            this.Nb9.Name = "Nb9";
            this.Nb9.Size = new System.Drawing.Size(47, 36);
            this.Nb9.TabIndex = 17;
            this.Nb9.Text = "9";
            this.Nb9.UseVisualStyleBackColor = false;
            this.Nb9.Click += new System.EventHandler(this.Nb9_Click);
            // 
            // txtPanel
            // 
            this.txtPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPanel.Location = new System.Drawing.Point(26, 67);
            this.txtPanel.Multiline = true;
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPanel.Size = new System.Drawing.Size(245, 47);
            this.txtPanel.TabIndex = 21;
            this.txtPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPanel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPanel_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(217)))), ((int)(((byte)(88)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(26, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(245, 36);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(299, 323);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPanel);
            this.Controls.Add(this.Nb9);
            this.Controls.Add(this.Nb8);
            this.Controls.Add(this.Nb7);
            this.Controls.Add(this.Nb6);
            this.Controls.Add(this.Nb5);
            this.Controls.Add(this.Nb4);
            this.Controls.Add(this.Nb3);
            this.Controls.Add(this.Nb2);
            this.Controls.Add(this.Nb1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnCross);
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Shown += new System.EventHandler(this.Calculator_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnPlus;
        private Button btnLess;
        private Button btnCross;
        private Button btnDivision;
        private Button btnResult;
        private Button Nb1;
        private Button Nb2;
        private Button Nb3;
        private Button Nb4;
        private Button Nb5;
        private Button Nb6;
        private Button Nb7;
        private Button Nb8;
        private Button Nb9;
        private TextBox txtPanel;
        private Button btnClear;
    }
}