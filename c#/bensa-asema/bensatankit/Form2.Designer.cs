using System.Drawing;
using System.Windows.Forms;

namespace _3.Huoltoaseman_bensatankit
{
    partial class tilausLomake
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
            this.radioButton95 = new System.Windows.Forms.RadioButton();
            this.radioButton98 = new System.Windows.Forms.RadioButton();
            this.radioButtonDi = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tilausmaara = new System.Windows.Forms.TextBox();
            this.teeTilaus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse tilattava tuote";
            // 
            // radioButton95
            // 
            this.radioButton95.AutoSize = true;
            this.radioButton95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton95.Location = new System.Drawing.Point(48, 50);
            this.radioButton95.Name = "radioButton95";
            this.radioButton95.Size = new System.Drawing.Size(59, 24);
            this.radioButton95.TabIndex = 1;
            this.radioButton95.TabStop = true;
            this.radioButton95.Text = "95E";
            this.radioButton95.UseVisualStyleBackColor = true;
            // 
            // radioButton98
            // 
            this.radioButton98.AutoSize = true;
            this.radioButton98.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton98.Location = new System.Drawing.Point(48, 80);
            this.radioButton98.Name = "radioButton98";
            this.radioButton98.Size = new System.Drawing.Size(59, 24);
            this.radioButton98.TabIndex = 2;
            this.radioButton98.TabStop = true;
            this.radioButton98.Text = "98E";
            this.radioButton98.UseVisualStyleBackColor = true;
            // 
            // radioButtonDi
            // 
            this.radioButtonDi.AutoSize = true;
            this.radioButtonDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDi.Location = new System.Drawing.Point(48, 110);
            this.radioButtonDi.Name = "radioButtonDi";
            this.radioButtonDi.Size = new System.Drawing.Size(44, 24);
            this.radioButtonDi.TabIndex = 3;
            this.radioButtonDi.TabStop = true;
            this.radioButtonDi.Text = "Di";
            this.radioButtonDi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Määrä litroina";
            // 
            // tilausmaara
            // 
            this.tilausmaara.Location = new System.Drawing.Point(48, 184);
            this.tilausmaara.Name = "tilausmaara";
            this.tilausmaara.Size = new System.Drawing.Size(100, 20);
            this.tilausmaara.TabIndex = 5;
            // 
            // teeTilaus
            // 
            this.teeTilaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teeTilaus.Location = new System.Drawing.Point(17, 231);
            this.teeTilaus.Name = "teeTilaus";
            this.teeTilaus.Size = new System.Drawing.Size(171, 34);
            this.teeTilaus.TabIndex = 6;
            this.teeTilaus.Text = "Tee Tilaus";
            this.teeTilaus.UseVisualStyleBackColor = true;
            // 
            // tilausLomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 286);
            this.Controls.Add(this.teeTilaus);
            this.Controls.Add(this.tilausmaara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonDi);
            this.Controls.Add(this.radioButton98);
            this.Controls.Add(this.radioButton95);
            this.Controls.Add(this.label1);
            this.Name = "tilausLomake";
            this.Text = "Tilauslomake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton radioButton95;
        private RadioButton radioButton98;
        private RadioButton radioButtonDi;
        private Label label2;
        private TextBox tilausmaara;
        private Button teeTilaus;
    }
}