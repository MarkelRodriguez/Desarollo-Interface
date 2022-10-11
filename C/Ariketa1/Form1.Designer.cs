namespace Ariketa1
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
            this.txtEsaldiak = new System.Windows.Forms.TextBox();
            this.btnEsaldi1 = new System.Windows.Forms.Button();
            this.btnEsaldi2 = new System.Windows.Forms.Button();
            this.btnEsaldi3 = new System.Windows.Forms.Button();
            this.btnEsaldi4 = new System.Windows.Forms.Button();
            this.btnEsaldi5 = new System.Windows.Forms.Button();
            this.btnLotu = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEsaldiak
            // 
            this.txtEsaldiak.Location = new System.Drawing.Point(168, 76);
            this.txtEsaldiak.Multiline = true;
            this.txtEsaldiak.Name = "txtEsaldiak";
            this.txtEsaldiak.Size = new System.Drawing.Size(422, 137);
            this.txtEsaldiak.TabIndex = 0;
            // 
            // btnEsaldi1
            // 
            this.btnEsaldi1.Location = new System.Drawing.Point(168, 266);
            this.btnEsaldi1.Name = "btnEsaldi1";
            this.btnEsaldi1.Size = new System.Drawing.Size(105, 46);
            this.btnEsaldi1.TabIndex = 1;
            this.btnEsaldi1.Text = "Esaldia 1";
            this.btnEsaldi1.UseVisualStyleBackColor = true;
            this.btnEsaldi1.Click += new System.EventHandler(this.btnEsaldi1_Click);
            // 
            // btnEsaldi2
            // 
            this.btnEsaldi2.Location = new System.Drawing.Point(334, 267);
            this.btnEsaldi2.Name = "btnEsaldi2";
            this.btnEsaldi2.Size = new System.Drawing.Size(105, 46);
            this.btnEsaldi2.TabIndex = 2;
            this.btnEsaldi2.Text = "Esaldia 2";
            this.btnEsaldi2.UseVisualStyleBackColor = true;
            this.btnEsaldi2.Click += new System.EventHandler(this.btnEsaldi2_Click);
            // 
            // btnEsaldi3
            // 
            this.btnEsaldi3.Location = new System.Drawing.Point(495, 267);
            this.btnEsaldi3.Name = "btnEsaldi3";
            this.btnEsaldi3.Size = new System.Drawing.Size(95, 45);
            this.btnEsaldi3.TabIndex = 3;
            this.btnEsaldi3.Text = "Esaldia 3";
            this.btnEsaldi3.UseVisualStyleBackColor = true;
            this.btnEsaldi3.Click += new System.EventHandler(this.btnEsaldi3_Click);
            // 
            // btnEsaldi4
            // 
            this.btnEsaldi4.Location = new System.Drawing.Point(168, 333);
            this.btnEsaldi4.Name = "btnEsaldi4";
            this.btnEsaldi4.Size = new System.Drawing.Size(105, 46);
            this.btnEsaldi4.TabIndex = 4;
            this.btnEsaldi4.Text = "Esaldia 4";
            this.btnEsaldi4.UseVisualStyleBackColor = true;
            this.btnEsaldi4.Click += new System.EventHandler(this.btnEsaldi4_Click);
            // 
            // btnEsaldi5
            // 
            this.btnEsaldi5.Location = new System.Drawing.Point(334, 333);
            this.btnEsaldi5.Name = "btnEsaldi5";
            this.btnEsaldi5.Size = new System.Drawing.Size(105, 46);
            this.btnEsaldi5.TabIndex = 5;
            this.btnEsaldi5.Text = "Esaldia 5";
            this.btnEsaldi5.UseVisualStyleBackColor = true;
            this.btnEsaldi5.Click += new System.EventHandler(this.btnEsaldi5_Click);
            // 
            // btnLotu
            // 
            this.btnLotu.Location = new System.Drawing.Point(495, 333);
            this.btnLotu.Name = "btnLotu";
            this.btnLotu.Size = new System.Drawing.Size(95, 46);
            this.btnLotu.TabIndex = 6;
            this.btnLotu.Text = "Lotu";
            this.btnLotu.UseVisualStyleBackColor = true;
            this.btnLotu.Click += new System.EventHandler(this.btnLotu_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Location = new System.Drawing.Point(235, 419);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(125, 58);
            this.btnGarbitu.TabIndex = 7;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Location = new System.Drawing.Point(417, 422);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(126, 55);
            this.btnIrten.TabIndex = 8;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnLotu);
            this.Controls.Add(this.btnEsaldi5);
            this.Controls.Add(this.btnEsaldi4);
            this.Controls.Add(this.btnEsaldi3);
            this.Controls.Add(this.btnEsaldi2);
            this.Controls.Add(this.btnEsaldi1);
            this.Controls.Add(this.txtEsaldiak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private TextBox txtEsaldiak;
        
        private Button btnEsaldi1;
        private Button btnEsaldi2;
        private Button btnEsaldi3;
        private Button btnEsaldi4;
        private Button btnEsaldi5;
        private Button btnLotu;
        private Button btnGarbitu;
        private Button btnIrten;
    }
}