namespace FractalulLuiCantor
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLinitial = new System.Windows.Forms.TextBox();
            this.ButtonDesenare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(2, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(742, 363);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lungime segment initial : ";
            // 
            // textBoxLinitial
            // 
            this.textBoxLinitial.Location = new System.Drawing.Point(183, 391);
            this.textBoxLinitial.Name = "textBoxLinitial";
            this.textBoxLinitial.Size = new System.Drawing.Size(100, 20);
            this.textBoxLinitial.TabIndex = 2;
            // 
            // ButtonDesenare
            // 
            this.ButtonDesenare.Location = new System.Drawing.Point(492, 369);
            this.ButtonDesenare.Name = "ButtonDesenare";
            this.ButtonDesenare.Size = new System.Drawing.Size(133, 71);
            this.ButtonDesenare.TabIndex = 3;
            this.ButtonDesenare.Text = "Desenare";
            this.ButtonDesenare.UseVisualStyleBackColor = true;
            this.ButtonDesenare.Click += new System.EventHandler(this.ButtonDesenare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.ButtonDesenare);
            this.Controls.Add(this.textBoxLinitial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "FractalulLuiCantor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLinitial;
        private System.Windows.Forms.Button ButtonDesenare;
    }
}

