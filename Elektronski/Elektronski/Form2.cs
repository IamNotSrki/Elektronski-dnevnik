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
using System.Configuration;

namespace Elektronski
{
    public partial class Form2 : Form
    {
        /* static string CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
        static int mesto;
        SqlConnection conn = null;
        SqlCommand komanda = new SqlCommand();
        DataTable djaci = new DataTable();
        SqlDataReader citac;
        SqlCommand komandaCount = new SqlCommand(); */

        DataTable podaci;
        SqlDataAdapter adapter;
        string imeTabele;

        public Form2()
        {
            imeTabele = "Osoba";
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*  djaci = poveziSe();
              mesto = 0;
              textBox1.Text = djaci.Rows[0][0].ToString();
              textBox2.Text = djaci.Rows[0][1].ToString();
              textBox3.Text = djaci.Rows[0][2].ToString();
              textBox4.Text = djaci.Rows[0][3].ToString();
              textBox5.Text = djaci.Rows[0][4].ToString();
              textBox6.Text = djaci.Rows[0][5].ToString();
              textBox7.Text = djaci.Rows[0][6].ToString();
              textBox8.Text = djaci.Rows[0][7].ToString();
              buttonPrvi.Visible = false;
              buttonPrethodni.Visible = false;
              buttonSledeci.Visible = true;
              buttonPoslednji.Visible = true; */

            // adapter = new SqlDataAdapter("SELECT * FROM Skolska_godina", Konekcija.Connect());
            adapter = new SqlDataAdapter("SELECT * FROM " + imeTabele, Konekcija.Connect()); // imeTabele
            // kada hocemo da iskoristimo isti gridView za rukovanje sa vise tabela, inace konstantna SELECT naredba
            podaci = new DataTable();
            adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
            dataGridView1.Columns["id"].ReadOnly = true; // zabranjuje promenu kolone primarnog kljuca id
            // dataGridView1.Columns["id"].Visible = false; // kolonu id cini nevidljivom, ali ovo se moglo
            // resiti i u SELECT naredbi(samo se iskljuci id)
        }

        /* private void buttonPrvi_Click(object sender, EventArgs e)
         {
             djaci = poveziSe();
             conn.Open();
             mesto = 0;
             if (conn.State == ConnectionState.Open)
             {
                 textBox1.Text = djaci.Rows[0][0].ToString();
                 textBox2.Text = djaci.Rows[0][1].ToString();
                 textBox3.Text = djaci.Rows[0][2].ToString();
                 textBox4.Text = djaci.Rows[0][3].ToString();
                 textBox5.Text = djaci.Rows[0][4].ToString();
                 textBox6.Text = djaci.Rows[0][5].ToString();
                 textBox7.Text = djaci.Rows[0][6].ToString();
                 textBox8.Text = djaci.Rows[0][7].ToString();
             }
             buttonPrvi.Visible = false;
             buttonPrethodni.Visible = false;
             buttonSledeci.Visible = true;
             buttonPoslednji.Visible = true;
             conn.Close();
         }

         private void buttonPrethodni_Click(object sender, EventArgs e)
         {
             djaci = poveziSe();
             mesto = int.Parse(textBox1.Text) - 2;
             conn.Open();
             if (conn.State == ConnectionState.Open)
             {
                 textBox1.Text = djaci.Rows[mesto][0].ToString();
                 textBox2.Text = djaci.Rows[mesto][1].ToString();
                 textBox3.Text = djaci.Rows[mesto][2].ToString();
                 textBox4.Text = djaci.Rows[mesto][3].ToString();
                 textBox5.Text = djaci.Rows[mesto][4].ToString();
                 textBox6.Text = djaci.Rows[mesto][5].ToString();
                 textBox7.Text = djaci.Rows[mesto][6].ToString();
                 textBox8.Text = djaci.Rows[mesto][7].ToString();
             }
             if (mesto == 0)
             {
                 buttonPrvi.Visible = false;
                 buttonPrethodni.Visible = false;
             }
             else
             {
                 buttonPrvi.Visible = true;
                 buttonPrethodni.Visible = true;
             }
             buttonSledeci.Visible = true;
             buttonPoslednji.Visible = true;
             conn.Close();
         }

         private void buttonSledeci_Click(object sender, EventArgs e)
         {
             djaci = poveziSe();
             mesto = int.Parse(textBox1.Text);
             conn.Open();
             if (conn.State == ConnectionState.Open)
             {
                 textBox1.Text = djaci.Rows[mesto][0].ToString();
                 textBox2.Text = djaci.Rows[mesto][1].ToString();
                 textBox3.Text = djaci.Rows[mesto][2].ToString();
                 textBox4.Text = djaci.Rows[mesto][3].ToString();
                 textBox5.Text = djaci.Rows[mesto][4].ToString();
                 textBox6.Text = djaci.Rows[mesto][5].ToString();
                 textBox7.Text = djaci.Rows[mesto][6].ToString();
                 textBox8.Text = djaci.Rows[mesto][7].ToString();
             }
             buttonPrvi.Visible = true;
             buttonPrethodni.Visible = true;
             conn.Close();
             if (mesto == brojRedova() - 1)
             {
                 buttonSledeci.Visible = false;
                 buttonPoslednji.Visible = false;
             }
             else
             {
                 buttonSledeci.Visible = true;
                 buttonPoslednji.Visible = true;
             }
         }

         private void buttonPoslednji_Click(object sender, EventArgs e)
         {
             djaci = poveziSe();
             mesto = brojRedova() - 1;
             textBox1.Text = djaci.Rows[mesto][0].ToString();
             textBox2.Text = djaci.Rows[mesto][1].ToString();
             textBox3.Text = djaci.Rows[mesto][2].ToString();
             textBox4.Text = djaci.Rows[mesto][3].ToString();
             textBox5.Text = djaci.Rows[mesto][4].ToString();
             textBox6.Text = djaci.Rows[mesto][5].ToString();
             textBox7.Text = djaci.Rows[mesto][6].ToString();
             textBox8.Text = djaci.Rows[mesto][7].ToString();
             buttonSledeci.Visible = false;
             buttonPoslednji.Visible = false;
             buttonPrvi.Visible = true;
             buttonPrethodni.Visible = true;
         }

         private void buttonDodaj_Click(object sender, EventArgs e)
         {
             StringBuilder te = new StringBuilder("INSERT INTO osoba VALUES(");
           //  te.Append(int.Parse(textBox1.Text) + ",");
             te.Append("'" + textBox2.Text + "',");
             te.Append("'" + textBox3.Text + "',");
             te.Append("'" + textBox4.Text + "',");
             te.Append("'" + textBox5.Text + "',");
             te.Append("'" + textBox6.Text + "',");
             te.Append("'" + textBox7.Text + "',");
             te.Append(int.Parse(textBox8.Text) + ")");
             SqlCommand dodaj = new SqlCommand(te.ToString(), conn);
             conn.Open();
             dodaj.ExecuteNonQuery();
             conn.Close();
         }

         private void buttonIzmeni_Click(object sender, EventArgs e)
         {
             StringBuilder te = new StringBuilder("UPDATE osoba ");
             te.Append("SET ime = '" + textBox2.Text + "'");
             te.Append(", prezime = '" + textBox3.Text + "'");
             te.Append(", adresa = '" + textBox4.Text + "'");
             te.Append(", jmbg = '" + textBox5.Text + "'");
             te.Append(", email = '" + textBox6.Text + "'");
             te.Append(", pass = '" + textBox7.Text + "'");
             te.Append(", uloga = " + int.Parse(textBox8.Text));
             te.Append(" WHERE id = " + int.Parse(textBox1.Text));
             SqlCommand izmeni = new SqlCommand(te.ToString(), conn);
             conn.Open();
             izmeni.ExecuteNonQuery();
             conn.Close();
         }

         private void buttonBrisi_Click(object sender, EventArgs e)
         {
             StringBuilder te = new StringBuilder("DELETE FROM osoba WHERE id = " + int.Parse(textBox1.Text));
             SqlCommand brisi = new SqlCommand(te.ToString(), conn);
             conn.Open();
             brisi.ExecuteNonQuery();
             conn.Close();
         } */

        private void button1_Click(object sender, EventArgs e)
        {
            podaci = podaci.GetChanges(DataRowState.Modified); //npr samo jedna od 3 vrste promena
            dataGridView1.DataSource = podaci;
            // ============= Ovo je nastavak posto se obrise dataGridView2 nakon pokazanog primera
            DataTable menjano = podaci.GetChanges(); // ovde ce biti sve promene
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.Close();
            }
        }
    }
}
