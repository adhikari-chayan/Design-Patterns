﻿namespace Singleton
{
    partial class Form2
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
            this.btnDoSomethingBad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoSomethingBad
            // 
            this.btnDoSomethingBad.Location = new System.Drawing.Point(12, 105);
            this.btnDoSomethingBad.Name = "btnDoSomethingBad";
            this.btnDoSomethingBad.Size = new System.Drawing.Size(285, 35);
            this.btnDoSomethingBad.TabIndex = 0;
            this.btnDoSomethingBad.Text = "Do Something Bad";
            this.btnDoSomethingBad.UseVisualStyleBackColor = true;
            this.btnDoSomethingBad.Click += new System.EventHandler(this.btnDoSomethingBad_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 291);
            this.Controls.Add(this.btnDoSomethingBad);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoSomethingBad;
    }
}