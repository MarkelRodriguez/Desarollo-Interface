namespace KaixoForms
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
            this.btnMezuaErakutsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMezuaErakutsi
            // 
            this.btnMezuaErakutsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMezuaErakutsi.Location = new System.Drawing.Point(236, 172);
            this.btnMezuaErakutsi.Name = "btnMezuaErakutsi";
            this.btnMezuaErakutsi.Size = new System.Drawing.Size(277, 117);
            this.btnMezuaErakutsi.TabIndex = 0;
            this.btnMezuaErakutsi.Text = "Mezua erakutsi";
            this.btnMezuaErakutsi.UseVisualStyleBackColor = true;
            this.btnMezuaErakutsi.Click += new System.EventHandler(this.btnMezuaErakutsi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMezuaErakutsi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMezuaErakutsi;
    }
}

