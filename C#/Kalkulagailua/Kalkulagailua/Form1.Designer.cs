namespace Kalkulagailua
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
            this.txtZenbaki1 = new System.Windows.Forms.TextBox();
            this.txtZenbaki2 = new System.Windows.Forms.TextBox();
            this.btnGehiketa = new System.Windows.Forms.Button();
            this.btnKenketa = new System.Windows.Forms.Button();
            this.btnBiderketa = new System.Windows.Forms.Button();
            this.btnZatiketa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtZenbaki1
            // 
            this.txtZenbaki1.Location = new System.Drawing.Point(161, 124);
            this.txtZenbaki1.Name = "txtZenbaki1";
            this.txtZenbaki1.Size = new System.Drawing.Size(132, 23);
            this.txtZenbaki1.TabIndex = 0;

            this.txtZenbaki1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZenbaki1_KeyPress);
            // 
            // txtZenbaki2
            // 
            this.txtZenbaki2.Location = new System.Drawing.Point(526, 124);
            this.txtZenbaki2.Name = "txtZenbaki2";
            this.txtZenbaki2.Size = new System.Drawing.Size(127, 23);
            this.txtZenbaki2.TabIndex = 1;
            this.txtZenbaki2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZenbaki2_KeyPress);
            // 
            // btnGehiketa
            // 
            this.btnGehiketa.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGehiketa.Location = new System.Drawing.Point(262, 202);
            this.btnGehiketa.Name = "btnGehiketa";
            this.btnGehiketa.Size = new System.Drawing.Size(84, 79);
            this.btnGehiketa.TabIndex = 2;
            this.btnGehiketa.Text = "+";
            this.btnGehiketa.UseVisualStyleBackColor = true;
            this.btnGehiketa.Click += new System.EventHandler(this.btnGehiketa_Click);
            // 
            // btnKenketa
            // 
            this.btnKenketa.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKenketa.Location = new System.Drawing.Point(438, 202);
            this.btnKenketa.Name = "btnKenketa";
            this.btnKenketa.Size = new System.Drawing.Size(88, 79);
            this.btnKenketa.TabIndex = 3;
            this.btnKenketa.Text = "-";
            this.btnKenketa.UseVisualStyleBackColor = true;
            this.btnKenketa.Click += new System.EventHandler(this.btnKenketa_Click);
            // 
            // btnBiderketa
            // 
            this.btnBiderketa.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBiderketa.Location = new System.Drawing.Point(262, 300);
            this.btnBiderketa.Name = "btnBiderketa";
            this.btnBiderketa.Size = new System.Drawing.Size(84, 82);
            this.btnBiderketa.TabIndex = 4;
            this.btnBiderketa.Text = "x";
            this.btnBiderketa.UseVisualStyleBackColor = true;
            this.btnBiderketa.Click += new System.EventHandler(this.btnBiderketa_Click);
            // 
            // btnZatiketa
            // 
            this.btnZatiketa.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZatiketa.Location = new System.Drawing.Point(438, 300);
            this.btnZatiketa.Name = "btnZatiketa";
            this.btnZatiketa.Size = new System.Drawing.Size(88, 82);
            this.btnZatiketa.TabIndex = 5;
            this.btnZatiketa.Text = "/";
            this.btnZatiketa.UseVisualStyleBackColor = true;
            this.btnZatiketa.Click += new System.EventHandler(this.btnZatiketa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZatiketa);
            this.Controls.Add(this.btnBiderketa);
            this.Controls.Add(this.btnKenketa);
            this.Controls.Add(this.btnGehiketa);
            this.Controls.Add(this.txtZenbaki2);
            this.Controls.Add(this.txtZenbaki1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtZenbaki1;
        private TextBox txtZenbaki2;
        private Button btnGehiketa;
        private Button btnKenketa;
        private Button btnBiderketa;
        private Button btnZatiketa;
    }
}