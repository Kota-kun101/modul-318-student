﻿
namespace MyTransportApp
{
    partial class Form3
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
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.btn_teilen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meine Verbindung teilen mit:";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(13, 34);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(281, 22);
            this.inputEmail.TabIndex = 1;
            // 
            // btn_teilen
            // 
            this.btn_teilen.Location = new System.Drawing.Point(301, 32);
            this.btn_teilen.Name = "btn_teilen";
            this.btn_teilen.Size = new System.Drawing.Size(75, 23);
            this.btn_teilen.TabIndex = 2;
            this.btn_teilen.Text = "teilen";
            this.btn_teilen.UseVisualStyleBackColor = true;
            this.btn_teilen.Click += new System.EventHandler(this.btn_teilen_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 75);
            this.Controls.Add(this.btn_teilen);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Button btn_teilen;
    }
}