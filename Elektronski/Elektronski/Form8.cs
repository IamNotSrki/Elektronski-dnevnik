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

namespace Elektronski
{
    public partial class Form8 : Form
    {
        int broj;
        SqlConnection veza;
        DataTable dtRaspodele, dtRaspodeleJoin;

        public Form8()
        {
            InitializeComponent();
        }

        private void nastavnikPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime+' '+prezime AS 'Naziv nastavnika' FROM osoba WHERE uloga = 2", veza);
            DataTable dtUcenik = new DataTable();
            adapter.Fill(dtUcenik);
            cbImePrezime.DataSource = dtUcenik;
            cbImePrezime.ValueMember = "id";
            cbImePrezime.DisplayMember = "Naziv nastavnika";
        }

        private void godinaPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, naziv AS 'Skolska godina' FROM skolska_godina", veza);
            DataTable dtGodina = new DataTable();
            adapter.Fill(dtGodina);
            cbSkolskaGodina.DataSource = dtGodina;
            cbSkolskaGodina.ValueMember = "id";
            cbSkolskaGodina.DisplayMember = "Skolska godina";
        }

        private void predmetPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, naziv AS 'Naziv predmeta' FROM predmet", veza);
            DataTable dtPredmet = new DataTable();
            adapter.Fill(dtPredmet);
            cbPredmet.DataSource = dtPredmet;
            cbPredmet.ValueMember = "id";
            cbPredmet.DisplayMember = "Naziv predmeta";
        }

        private void odeljenjePopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, razred + ' ' + indeks AS Odeljenje FROM odeljenje", veza);
            DataTable dtOdeljenje = new DataTable();
            adapter.Fill(dtOdeljenje);
            cbOdeljenje.DataSource = dtOdeljenje;
            cbOdeljenje.ValueMember = "id";
            cbOdeljenje.DisplayMember = "Odeljenje";
        }

        private void gridPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM raspodela ORDER BY id", veza);
            dtRaspodele = new DataTable();
            adapter.Fill(dtRaspodele);

            string tmp1 = "SELECT raspodela.id, osoba.ime + ' ' + osoba.prezime AS 'Nastavnik', Skolska_godina.naziv AS 'Skolska godina', predmet.naziv AS 'Predmet', odeljenje.razred + ' ' + odeljenje.indeks AS 'Odeljenje' ";
            string tmp2 = "FROM Raspodela JOIN osoba ON Raspodela.nastavnik_id = Osoba.id JOIN Skolska_godina ON Raspodela.godina_id = Skolska_godina.id JOIN Predmet ON Raspodela.predmet_id = Predmet.id ";
            string tmp3 = "JOIN Odeljenje ON Raspodela.odeljenje_id = Odeljenje.id WHERE osoba.uloga = 2";
            string tmp = tmp1 + tmp2 + tmp3;
            adapter = new SqlDataAdapter(tmp, veza);
            dtRaspodeleJoin = new DataTable();
            adapter.Fill(dtRaspodeleJoin);

            dataGridView1.DataSource = dtRaspodeleJoin;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                broj = dataGridView1.CurrentRow.Index;
                cbImePrezime.SelectedValue = dtRaspodele.Rows[broj]["nastavnik_id"].ToString();
                cbSkolskaGodina.SelectedValue = dtRaspodele.Rows[broj]["godina_id"].ToString();
                cbPredmet.SelectedValue = dtRaspodele.Rows[broj]["predmet_id"].ToString();
                cbOdeljenje.SelectedValue = dtRaspodele.Rows[broj]["odeljenje_id"].ToString();
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {

            try
            {
                string naredba = "DELETE FROM raspodela WHERE id = " + dtRaspodele.Rows[broj]["id"].ToString();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }
            catch (Exception Greska)
            {
                veza.Close();
                MessageBox.Show(Greska.Message);

            }
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "INSERT INTO raspodela (nastavnik_id, godina_id, predmet_id, odeljenje_id) VALUES ('";
                naredba = naredba + cbImePrezime.SelectedValue.ToString() + "','";
                naredba = naredba + cbSkolskaGodina.SelectedValue.ToString() + "','";
                naredba = naredba + cbPredmet.SelectedValue.ToString() + "','";
                naredba = naredba + cbOdeljenje.SelectedValue.ToString() + "')";

                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }
            catch (Exception Greska)
            {
                veza.Close();
                MessageBox.Show(Greska.Message);
            }
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "UPDATE raspodela SET nastavnik_id='" + cbImePrezime.SelectedValue.ToString();
                naredba = naredba + "', godina_id='" + cbSkolskaGodina.SelectedValue.ToString();
                naredba = naredba + "', predmet_id='" + cbPredmet.SelectedValue.ToString();
                naredba = naredba + "', odeljenje_id='" + cbOdeljenje.SelectedValue.ToString() + "'WHERE id='";
                naredba = naredba + dtRaspodele.Rows[broj]["id"].ToString() + "'";
                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }
            catch (Exception Greska)
            {
                veza.Close();
                MessageBox.Show(Greska.Message);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string CS = "Data Source=.\\SQLEXPRESS; Initial Catalog = esdnevnik; Integrated Security = True";
            veza = new SqlConnection(CS);
            nastavnikPopulate();
            predmetPopulate();
            gridPopulate();
            odeljenjePopulate();
            godinaPopulate();
        }
    }
}
