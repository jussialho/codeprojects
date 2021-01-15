namespace Maksuautomaatti_ja_mittari
{
    partial class maksuLomake
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
            this.label1 = new System.Windows.Forms.Label();
            this.pinkoodi = new System.Windows.Forms.TextBox();
            this.vahvistaMaksu = new System.Windows.Forms.Button();
            this.okNappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Syötä PIN-koodi:";
            // 
            // pinkoodi
            // 
            this.pinkoodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinkoodi.Location = new System.Drawing.Point(32, 50);
            this.pinkoodi.MaxLength = 4;
            this.pinkoodi.Name = "pinkoodi";
            this.pinkoodi.Size = new System.Drawing.Size(100, 29);
            this.pinkoodi.TabIndex = 1;
            this.pinkoodi.UseSystemPasswordChar = true;
            // 
            // vahvistaMaksu
            // 
            this.vahvistaMaksu.Enabled = false;
            this.vahvistaMaksu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vahvistaMaksu.Location = new System.Drawing.Point(17, 90);
            this.vahvistaMaksu.Name = "vahvistaMaksu";
            this.vahvistaMaksu.Size = new System.Drawing.Size(175, 37);
            this.vahvistaMaksu.TabIndex = 2;
            this.vahvistaMaksu.Text = "Vahvista Maksu";
            this.vahvistaMaksu.UseVisualStyleBackColor = true;
            // 
            // okNappi
            // 
            this.okNappi.Location = new System.Drawing.Point(138, 50);
            this.okNappi.Name = "okNappi";
            this.okNappi.Size = new System.Drawing.Size(38, 29);
            this.okNappi.TabIndex = 3;
            this.okNappi.Text = "OK";
            this.okNappi.UseVisualStyleBackColor = true;
            // 
            // maksuLomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 139);
            this.Controls.Add(this.okNappi);
            this.Controls.Add(this.vahvistaMaksu);
            this.Controls.Add(this.pinkoodi);
            this.Controls.Add(this.label1);
            this.Name = "maksuLomake";
            this.Text = "Korttimaksu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pinkoodi;
        private System.Windows.Forms.Button vahvistaMaksu;
        private System.Windows.Forms.Button okNappi;
    }
}