﻿namespace Depot
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
            this.addItem1 = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addItem1
            // 
            this.addItem1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addItem1.Location = new System.Drawing.Point(225, 178);
            this.addItem1.Name = "addItem1";
            this.addItem1.Size = new System.Drawing.Size(312, 49);
            this.addItem1.TabIndex = 0;
            this.addItem1.Text = "Add Item";
            this.addItem1.UseVisualStyleBackColor = false;
            this.addItem1.Click += new System.EventHandler(this.addItem1_Click);
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(225, 140);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(100, 20);
            this.itemName.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(437, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.addItem1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItem1;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

