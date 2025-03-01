namespace PraktikumKPL_TPmod03
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

        //tes

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSUBMIT = new System.Windows.Forms.Button();
            this.btnOUTPUT = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblIsian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSUBMIT
            // 
            this.btnSUBMIT.Location = new System.Drawing.Point(489, 57);
            this.btnSUBMIT.Name = "btnSUBMIT";
            this.btnSUBMIT.Size = new System.Drawing.Size(241, 56);
            this.btnSUBMIT.TabIndex = 3;
            this.btnSUBMIT.Text = "SUBMIT";
            this.btnSUBMIT.UseVisualStyleBackColor = true;
            this.btnSUBMIT.Click += new System.EventHandler(this.btnSUBMIT_Click);
            // 
            // btnOUTPUT
            // 
            this.btnOUTPUT.Location = new System.Drawing.Point(38, 132);
            this.btnOUTPUT.Name = "btnOUTPUT";
            this.btnOUTPUT.Size = new System.Drawing.Size(692, 56);
            this.btnOUTPUT.TabIndex = 4;
            this.btnOUTPUT.Text = "OUTPUT";
            this.btnOUTPUT.UseVisualStyleBackColor = true;
            this.btnOUTPUT.Click += new System.EventHandler(this.btnOUTPUT_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(38, 74);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(434, 22);
            this.txtInput.TabIndex = 6;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(35, 220);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(133, 16);
            this.lblNama.TabIndex = 7;
            this.lblNama.Text = "NAMA PRAKTIKAN : ";
            this.lblNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIsian
            // 
            this.lblIsian.AutoSize = true;
            this.lblIsian.Location = new System.Drawing.Point(174, 220);
            this.lblIsian.Name = "lblIsian";
            this.lblIsian.Size = new System.Drawing.Size(0, 16);
            this.lblIsian.TabIndex = 8;
            this.lblIsian.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.lblIsian);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnOUTPUT);
            this.Controls.Add(this.btnSUBMIT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSUBMIT;
        private System.Windows.Forms.Button btnOUTPUT;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblIsian;
    }
}

