//R8507
//CIS 199-01
//Program 3
//Due 4/1/2021
//Uses parallel arrays and range matching. It allows the user to input state, product number and quantity and return a price to the user
using System;

namespace Program3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblInitialCost = new System.Windows.Forms.TextBox();
            this.lblDiscCost = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Initial Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discounted Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shipment Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Price:";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.cmbState.Location = new System.Drawing.Point(196, 36);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 21);
            this.cmbState.TabIndex = 7;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(196, 74);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(121, 20);
            this.txtProduct.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(196, 110);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // lblInitialCost
            // 
            this.lblInitialCost.Enabled = false;
            this.lblInitialCost.Location = new System.Drawing.Point(196, 186);
            this.lblInitialCost.Name = "lblInitialCost";
            this.lblInitialCost.Size = new System.Drawing.Size(121, 20);
            this.lblInitialCost.TabIndex = 10;
            // 
            // lblDiscCost
            // 
            this.lblDiscCost.Enabled = false;
            this.lblDiscCost.Location = new System.Drawing.Point(196, 223);
            this.lblDiscCost.Name = "lblDiscCost";
            this.lblDiscCost.Size = new System.Drawing.Size(121, 20);
            this.lblDiscCost.TabIndex = 10;
            // 
            // lblTax
            // 
            this.lblTax.Enabled = false;
            this.lblTax.Location = new System.Drawing.Point(196, 264);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(121, 20);
            this.lblTax.TabIndex = 10;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Enabled = false;
            this.lblTotalCost.Location = new System.Drawing.Point(196, 304);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(121, 20);
            this.lblTotalCost.TabIndex = 10;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(220, 148);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblDiscCost);
            this.Controls.Add(this.lblInitialCost);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sales Co Cost Calculator";
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
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox lblInitialCost;
        private System.Windows.Forms.TextBox lblDiscCost;
        private System.Windows.Forms.TextBox lblTax;
        private System.Windows.Forms.TextBox lblTotalCost;
        private System.Windows.Forms.Button BtnCalculate;
        private EventHandler Form1_Load;
    }
}

