namespace OOP.Inheritance_
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
            this.Base = new System.Windows.Forms.Button();
            this.Mobil = new System.Windows.Forms.Button();
            this.Smart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(291, 49);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(193, 34);
            this.Base.TabIndex = 0;
            this.Base.Text = "Base";
            this.Base.UseVisualStyleBackColor = true;
            this.Base.Click += new System.EventHandler(this.Base_Click);
            // 
            // Mobil
            // 
            this.Mobil.Location = new System.Drawing.Point(291, 92);
            this.Mobil.Name = "Mobil";
            this.Mobil.Size = new System.Drawing.Size(193, 34);
            this.Mobil.TabIndex = 1;
            this.Mobil.Text = "Mobil";
            this.Mobil.UseVisualStyleBackColor = true;
            this.Mobil.Click += new System.EventHandler(this.Mobil_Click);
            // 
            // Smart
            // 
            this.Smart.Location = new System.Drawing.Point(291, 134);
            this.Smart.Name = "Smart";
            this.Smart.Size = new System.Drawing.Size(193, 34);
            this.Smart.TabIndex = 2;
            this.Smart.Text = "Smart";
            this.Smart.UseVisualStyleBackColor = true;
            this.Smart.Click += new System.EventHandler(this.Smart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Smart);
            this.Controls.Add(this.Mobil);
            this.Controls.Add(this.Base);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Base;
        private System.Windows.Forms.Button Mobil;
        private System.Windows.Forms.Button Smart;
    }
}