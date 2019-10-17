namespace MintPlayer.IconUtils.TestFramework
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
            this.btnOpenIconFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenIconFile
            // 
            this.btnOpenIconFile.Location = new System.Drawing.Point(13, 13);
            this.btnOpenIconFile.Name = "btnOpenIconFile";
            this.btnOpenIconFile.Size = new System.Drawing.Size(100, 25);
            this.btnOpenIconFile.TabIndex = 0;
            this.btnOpenIconFile.Text = "Select ICO file";
            this.btnOpenIconFile.UseVisualStyleBackColor = true;
            this.btnOpenIconFile.Click += new System.EventHandler(this.btnOpenIconFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenIconFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenIconFile;
    }
}

