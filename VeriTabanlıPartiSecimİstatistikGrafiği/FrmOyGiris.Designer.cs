namespace VeriTabanlıPartiSecimİstatistikGrafiği
{
    partial class FrmOyGiris
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
            label1 = new Label();
            txtIlceAd = new TextBox();
            txtB = new TextBox();
            label2 = new Label();
            txtA = new TextBox();
            label3 = new Label();
            txtC = new TextBox();
            label4 = new Label();
            txtD = new TextBox();
            label5 = new Label();
            txtE = new TextBox();
            label6 = new Label();
            btnOyGirisi = new Button();
            btnGrafik = new Button();
            btnCıkısYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 0;
            label1.Text = "İLÇE AD : ";
            // 
            // txtIlceAd
            // 
            txtIlceAd.Location = new Point(111, 44);
            txtIlceAd.Name = "txtIlceAd";
            txtIlceAd.Size = new Size(238, 29);
            txtIlceAd.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(111, 134);
            txtB.Name = "txtB";
            txtB.Size = new Size(238, 29);
            txtB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 2;
            label2.Text = "A PARTİ : ";
            // 
            // txtA
            // 
            txtA.Location = new Point(111, 94);
            txtA.Name = "txtA";
            txtA.Size = new Size(238, 29);
            txtA.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 142);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "B PARTİ : ";
            // 
            // txtC
            // 
            txtC.Location = new Point(111, 177);
            txtC.Name = "txtC";
            txtC.Size = new Size(238, 29);
            txtC.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 185);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 6;
            label4.Text = "C PARTİ : ";
            // 
            // txtD
            // 
            txtD.Location = new Point(111, 220);
            txtD.Name = "txtD";
            txtD.Size = new Size(238, 29);
            txtD.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 223);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 8;
            label5.Text = "D PARTİ : ";
            // 
            // txtE
            // 
            txtE.Location = new Point(111, 260);
            txtE.Name = "txtE";
            txtE.Size = new Size(238, 29);
            txtE.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 263);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 10;
            label6.Text = "E PARTİ : ";
            // 
            // btnOyGirisi
            // 
            btnOyGirisi.Location = new Point(111, 295);
            btnOyGirisi.Name = "btnOyGirisi";
            btnOyGirisi.Size = new Size(246, 38);
            btnOyGirisi.TabIndex = 12;
            btnOyGirisi.Text = "OY GİRİŞİ YAP";
            btnOyGirisi.UseVisualStyleBackColor = true;
            btnOyGirisi.Click += btnOyGirisi_Click;
            // 
            // btnGrafik
            // 
            btnGrafik.Location = new Point(111, 339);
            btnGrafik.Name = "btnGrafik";
            btnGrafik.Size = new Size(116, 41);
            btnGrafik.TabIndex = 13;
            btnGrafik.Text = "GRAFİKLER";
            btnGrafik.UseVisualStyleBackColor = true;
            btnGrafik.Click += btnGrafik_Click;
            // 
            // btnCıkısYap
            // 
            btnCıkısYap.Location = new Point(233, 339);
            btnCıkısYap.Name = "btnCıkısYap";
            btnCıkısYap.Size = new Size(124, 41);
            btnCıkısYap.TabIndex = 14;
            btnCıkısYap.Text = "ÇIKIŞ YAP";
            btnCıkısYap.UseVisualStyleBackColor = true;
            btnCıkısYap.Click += btnCıkısYap_Click;
            // 
            // FrmOyGiris
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(402, 416);
            Controls.Add(btnCıkısYap);
            Controls.Add(btnGrafik);
            Controls.Add(btnOyGirisi);
            Controls.Add(txtE);
            Controls.Add(label6);
            Controls.Add(txtD);
            Controls.Add(label5);
            Controls.Add(txtC);
            Controls.Add(label4);
            Controls.Add(txtA);
            Controls.Add(label3);
            Controls.Add(txtB);
            Controls.Add(label2);
            Controls.Add(txtIlceAd);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmOyGiris";
            Text = "VTGS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIlceAd;
        private TextBox txtB;
        private Label label2;
        private TextBox txtA;
        private Label label3;
        private TextBox txtC;
        private Label label4;
        private TextBox txtD;
        private Label label5;
        private TextBox txtE;
        private Label label6;
        private Button btnOyGirisi;
        private Button btnGrafik;
        private Button btnCıkısYap;
    }
}
