namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblP4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblP1
            // 
            this.lblP1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblP1.Location = new System.Drawing.Point(63, 34);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(675, 33);
            this.lblP1.TabIndex = 0;
            // 
            // lblP2
            // 
            this.lblP2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblP2.Location = new System.Drawing.Point(63, 86);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(675, 33);
            this.lblP2.TabIndex = 1;
            // 
            // lblP3
            // 
            this.lblP3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblP3.Location = new System.Drawing.Point(63, 141);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(675, 33);
            this.lblP3.TabIndex = 2;
            // 
            // lblP4
            // 
            this.lblP4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblP4.Location = new System.Drawing.Point(63, 197);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(675, 33);
            this.lblP4.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTotal.Location = new System.Drawing.Point(63, 253);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(675, 154);
            this.lblTotal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblP4);
            this.Controls.Add(this.lblP3);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblP1;
        private Label lblP2;
        private Label lblP3;
        private Label lblP4;
        private Label lblTotal;
    }
}