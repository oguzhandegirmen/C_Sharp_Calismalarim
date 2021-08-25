
namespace NetFramework.S19.D2.KullanıcıGirisForm
{
    partial class anaForm
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
            this.lblFenerbahce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFenerbahce
            // 
            this.lblFenerbahce.AutoSize = true;
            this.lblFenerbahce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFenerbahce.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFenerbahce.Location = new System.Drawing.Point(426, 90);
            this.lblFenerbahce.Name = "lblFenerbahce";
            this.lblFenerbahce.Size = new System.Drawing.Size(2, 15);
            this.lblFenerbahce.TabIndex = 0;
            this.lblFenerbahce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(935, 242);
            this.Controls.Add(this.lblFenerbahce);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "anaForm";
            this.Text = "anaForm";
            this.Load += new System.EventHandler(this.anaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFenerbahce;
    }
}