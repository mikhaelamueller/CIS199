//ID R8507
// Program 2
// Due 3/11/2021
// CIS 199-01
namespace select_best_option
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterPpl = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.txtMile = new System.Windows.Forms.TextBox();
            this.mileLbl = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.dayLbl = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
           
            // 
            // enterPpl
            // 
            this.enterPpl.AutoSize = true;
            this.enterPpl.Location = new System.Drawing.Point(33, 40);
            this.enterPpl.Name = "enterPpl";
            this.enterPpl.Size = new System.Drawing.Size(71, 13);
            this.enterPpl.TabIndex = 0;
            this.enterPpl.Text = "Enter People:";
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(149, 37);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 20);
            this.txtPeople.TabIndex = 1;
            // 
            // txtMile
            // 
            this.txtMile.Location = new System.Drawing.Point(149, 89);
            this.txtMile.Name = "txtMile";
            this.txtMile.Size = new System.Drawing.Size(100, 20);
            this.txtMile.TabIndex = 3;
            // 
            // mileLbl
            // 
            this.mileLbl.AutoSize = true;
            this.mileLbl.Location = new System.Drawing.Point(33, 92);
            this.mileLbl.Name = "mileLbl";
            this.mileLbl.Size = new System.Drawing.Size(57, 13);
            this.mileLbl.TabIndex = 2;
            this.mileLbl.Text = "Enter Mile:";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(149, 143);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            this.txtDay.TabIndex = 5;
            // 
            // dayLbl
            // 
            this.dayLbl.AutoSize = true;
            this.dayLbl.Location = new System.Drawing.Point(33, 146);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(98, 13);
            this.dayLbl.TabIndex = 4;
            this.dayLbl.Text = "Enter Delivery Day:";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(105, 188);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(129, 34);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Calculate Cost";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(68, 225);
            this.lblResult.MinimumSize = new System.Drawing.Size(200, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 100);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(329, 208);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 335);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.dayLbl);
            this.Controls.Add(this.txtMile);
            this.Controls.Add(this.mileLbl);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.enterPpl);
            this.Name = "Form1";
            this.Text = "Food Delivery Cost Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPpl;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.TextBox txtMile;
        private System.Windows.Forms.Label mileLbl;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
    }
}