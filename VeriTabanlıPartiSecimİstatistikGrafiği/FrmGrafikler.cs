﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VeriTabanlıİstatistikUygulaması;
using System.Net.Http.Headers;

namespace VeriTabanlıİstatistikUygulaması
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=GOKCE;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //İlçe Adlarını Combobox'a çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Grafiğe Toplam Sonuçları Getirme

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Sum(APARTI),Sum(BPARTI),Sum(CPARTI),Sum(DPARTI),Sum(EPARTI) FROM TBLILCE", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*From TBLILCE where ILCEAD=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = Convert.ToInt32(dr[2].ToString());
                progressBar2.Value = Convert.ToInt32(dr[3].ToString());
                progressBar3.Value = Convert.ToInt32(dr[4].ToString());
                progressBar4.Value = Convert.ToInt32(dr[5].ToString());
                progressBar5.Value = Convert.ToInt32(dr[6].ToString());

                lblA.Text = dr[2].ToString();
                lblB.Text = dr[3].ToString();
                lblC.Text = dr[4].ToString();
                lblD.Text = dr[5].ToString();
                lblE.Text = dr[6].ToString();

            }
            baglanti.Close();
        }
    }
}