namespace Ariketa2
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
            this.txtZenbakia = new System.Windows.Forms.TextBox();
            this.labelZenbakia = new System.Windows.Forms.Label();
            this.btnHurrengoa = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtZenbakia
            // 
            this.txtZenbakia.Location = new System.Drawing.Point(319, 106);
            this.txtZenbakia.Name = "txtZenbakia";
            this.txtZenbakia.Size = new System.Drawing.Size(271, 23);
            this.txtZenbakia.TabIndex = 0;
            this.txtZenbakia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZenbakia_KeyPress);
            // 
            // labelZenbakia
            // 
            this.labelZenbakia.AutoSize = true;
            this.labelZenbakia.Location = new System.Drawing.Point(192, 114);
            this.labelZenbakia.Name = "labelZenbakia";
            this.labelZenbakia.Size = new System.Drawing.Size(64, 15);
            this.labelZenbakia.TabIndex = 1;
            this.labelZenbakia.Text = "1.Zenbakia";
            // 
            // btnHurrengoa
            // 
            this.btnHurrengoa.Location = new System.Drawing.Point(176, 272);
            this.btnHurrengoa.Name = "btnHurrengoa";
            this.btnHurrengoa.Size = new System.Drawing.Size(80, 38);
            this.btnHurrengoa.TabIndex = 2;
            this.btnHurrengoa.Text = "Hurrengoa";
            this.btnHurrengoa.UseVisualStyleBackColor = true;
            this.btnHurrengoa.Click += new System.EventHandler(this.btnHurrengoa_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Location = new System.Drawing.Point(300, 272);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(88, 38);
            this.btnGarbitu.TabIndex = 3;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Location = new System.Drawing.Point(420, 272);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(90, 38);
            this.btnIrten.TabIndex = 4;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnHurrengoa);
            this.Controls.Add(this.labelZenbakia);
            this.Controls.Add(this.txtZenbakia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtZenbakia;
        private Label labelZenbakia;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnIrten;
    }
}