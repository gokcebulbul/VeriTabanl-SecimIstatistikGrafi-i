namespace VeriTabanlıİstatistikUygulaması
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox2 = new GroupBox();
            lblA = new Label();
            lblE = new Label();
            lblD = new Label();
            lblC = new Label();
            lblB = new Label();
            progressBar5 = new ProgressBar();
            label6 = new Label();
            progressBar4 = new ProgressBar();
            label5 = new Label();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            progressBar2 = new ProgressBar();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chart1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            chart1.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(3, 21);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            chart1.Series.Add(series2);
            chart1.Size = new Size(634, 278);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblA);
            groupBox2.Controls.Add(lblE);
            groupBox2.Controls.Add(lblD);
            groupBox2.Controls.Add(lblC);
            groupBox2.Controls.Add(lblB);
            groupBox2.Controls.Add(progressBar5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(progressBar4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(progressBar3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(progressBar2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(15, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(637, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İlçe Değerleri";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(407, 84);
            lblA.Name = "lblA";
            lblA.Size = new Size(17, 18);
            lblA.TabIndex = 16;
            lblA.Text = "0";
            // 
            // lblE
            // 
            lblE.AutoSize = true;
            lblE.Location = new Point(407, 231);
            lblE.Name = "lblE";
            lblE.Size = new Size(17, 18);
            lblE.TabIndex = 15;
            lblE.Text = "0";
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Location = new Point(407, 198);
            lblD.Name = "lblD";
            lblD.Size = new Size(17, 18);
            lblD.TabIndex = 14;
            lblD.Text = "0";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(407, 162);
            lblC.Name = "lblC";
            lblC.Size = new Size(17, 18);
            lblC.TabIndex = 13;
            lblC.Text = "0";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(407, 124);
            lblB.Name = "lblB";
            lblB.Size = new Size(17, 18);
            lblB.TabIndex = 12;
            lblB.Text = "0";
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(130, 231);
            progressBar5.Maximum = 200;
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(263, 23);
            progressBar5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 236);
            label6.Name = "label6";
            label6.Size = new Size(81, 18);
            label6.TabIndex = 10;
            label6.Text = "E PARTİ : ";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(130, 193);
            progressBar4.Maximum = 200;
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(265, 23);
            progressBar4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 198);
            label5.Name = "label5";
            label5.Size = new Size(82, 18);
            label5.TabIndex = 8;
            label5.Text = "D PARTİ : ";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(128, 157);
            progressBar3.Maximum = 200;
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(265, 23);
            progressBar3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 157);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 6;
            label4.Text = "C PARTİ : ";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(130, 119);
            progressBar2.Maximum = 200;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(265, 23);
            progressBar2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 124);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 4;
            label3.Text = "B PARTİ : ";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(130, 84);
            progressBar1.Maximum = 200;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(265, 23);
            progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 89);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 2;
            label2.Text = "A PARTİ : ";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 26);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 0;
            label1.Text = "İlçe Seçim : ";
            // 
            // FrmGrafikler
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(673, 604);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmGrafikler";
            Text = "VTGS";
            Load += FrmGrafikler_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label1;
        private Label lblA;
        private Label lblE;
        private Label lblD;
        private Label lblC;
        private Label lblB;
        private ProgressBar progressBar5;
        private Label label6;
        private ProgressBar progressBar4;
        private Label label5;
        private ProgressBar progressBar3;
        private Label label4;
        private ProgressBar progressBar2;
        private Label label3;
        private ProgressBar progressBar1;
        private Label label2;
    }
}