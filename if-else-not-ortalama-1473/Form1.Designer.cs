namespace if_else_not_ortalama_1473
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtZayıf = new System.Windows.Forms.TextBox();
            this.txtDevamsızlık = new System.Windows.Forms.TextBox();
            this.btnDurumgoster = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOT ORTALAMASI=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZAYIF SAYISI=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DEVAMSIZLIK SAYİ=";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(139, 25);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 3;
            // 
            // txtZayıf
            // 
            this.txtZayıf.Location = new System.Drawing.Point(139, 61);
            this.txtZayıf.Name = "txtZayıf";
            this.txtZayıf.Size = new System.Drawing.Size(100, 20);
            this.txtZayıf.TabIndex = 4;
            // 
            // txtDevamsızlık
            // 
            this.txtDevamsızlık.Location = new System.Drawing.Point(139, 94);
            this.txtDevamsızlık.Name = "txtDevamsızlık";
            this.txtDevamsızlık.Size = new System.Drawing.Size(100, 20);
            this.txtDevamsızlık.TabIndex = 5;
            // 
            // btnDurumgoster
            // 
            this.btnDurumgoster.Location = new System.Drawing.Point(13, 139);
            this.btnDurumgoster.Name = "btnDurumgoster";
            this.btnDurumgoster.Size = new System.Drawing.Size(226, 38);
            this.btnDurumgoster.TabIndex = 6;
            this.btnDurumgoster.Text = "button1";
            this.btnDurumgoster.UseVisualStyleBackColor = true;
            this.btnDurumgoster.Click += new System.EventHandler(this.btnDurumgoster_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(15, 204);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(48, 13);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "DURUM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 234);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnDurumgoster);
            this.Controls.Add(this.txtDevamsızlık);
            this.Controls.Add(this.txtZayıf);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtZayıf;
        private System.Windows.Forms.TextBox txtDevamsızlık;
        private System.Windows.Forms.Button btnDurumgoster;
        private System.Windows.Forms.Label lblDurum;
    }
}

