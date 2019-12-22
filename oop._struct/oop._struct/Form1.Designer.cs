namespace oop._struct
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
            this.Struct = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Struct
            // 
            this.Struct.Location = new System.Drawing.Point(12, 66);
            this.Struct.Name = "Struct";
            this.Struct.Size = new System.Drawing.Size(279, 52);
            this.Struct.TabIndex = 0;
            this.Struct.Text = "Struct";
            this.Struct.UseVisualStyleBackColor = true;
            this.Struct.Click += new System.EventHandler(this.Struct_Click);
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(12, 8);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(279, 52);
            this.Class.TabIndex = 1;
            this.Class.Text = "Class";
            this.Class.UseVisualStyleBackColor = true;
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 146);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Struct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Struct;
        private System.Windows.Forms.Button Class;
    }
}

