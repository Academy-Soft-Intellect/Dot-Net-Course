namespace OurFirstWindowsForm
{
    partial class OurForm
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
            this.btnOpenSecondForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenSecondForm
            // 
            this.btnOpenSecondForm.Location = new System.Drawing.Point(48, 47);
            this.btnOpenSecondForm.Name = "btnOpenSecondForm";
            this.btnOpenSecondForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSecondForm.TabIndex = 0;
            this.btnOpenSecondForm.Text = "Open";
            this.btnOpenSecondForm.UseVisualStyleBackColor = true;
            this.btnOpenSecondForm.Click += new System.EventHandler(this.btnOpenSecondForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // OurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(347, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenSecondForm);
            this.Name = "OurForm";
            this.Text = "Our Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSecondForm;
        private System.Windows.Forms.Label label1;


    }
}

