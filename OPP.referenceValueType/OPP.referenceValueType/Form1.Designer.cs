namespace OPP.referenceValueType
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
            this.ReferenceType = new System.Windows.Forms.Button();
            this.ValueType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReferenceType
            // 
            this.ReferenceType.Location = new System.Drawing.Point(12, 11);
            this.ReferenceType.Name = "ReferenceType";
            this.ReferenceType.Size = new System.Drawing.Size(250, 55);
            this.ReferenceType.TabIndex = 0;
            this.ReferenceType.Text = "ReferenceType";
            this.ReferenceType.UseVisualStyleBackColor = true;
            this.ReferenceType.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ValueType
            // 
            this.ValueType.Location = new System.Drawing.Point(12, 72);
            this.ValueType.Name = "ValueType";
            this.ValueType.Size = new System.Drawing.Size(250, 61);
            this.ValueType.TabIndex = 1;
            this.ValueType.Text = "ValueType";
            this.ValueType.UseVisualStyleBackColor = true;
            this.ValueType.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 143);
            this.Controls.Add(this.ValueType);
            this.Controls.Add(this.ReferenceType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReferenceType;
        private System.Windows.Forms.Button ValueType;
    }
}

