﻿
namespace Elektronski
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbRaspodela = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.tbOcena = new System.Windows.Forms.TextBox();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbImePrezime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Broj raspodele";
            // 
            // cbRaspodela
            // 
            this.cbRaspodela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaspodela.FormattingEnabled = true;
            this.cbRaspodela.Location = new System.Drawing.Point(488, 105);
            this.cbRaspodela.Margin = new System.Windows.Forms.Padding(2);
            this.cbRaspodela.Name = "cbRaspodela";
            this.cbRaspodela.Size = new System.Drawing.Size(71, 21);
            this.cbRaspodela.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ocena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ime i prezime ucenika";
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(326, 106);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(100, 20);
            this.tbDatum.TabIndex = 41;
            // 
            // tbOcena
            // 
            this.tbOcena.Location = new System.Drawing.Point(621, 105);
            this.tbOcena.Name = "tbOcena";
            this.tbOcena.Size = new System.Drawing.Size(36, 20);
            this.tbOcena.TabIndex = 40;
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(585, 353);
            this.btDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(73, 22);
            this.btDodaj.TabIndex = 39;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(365, 352);
            this.btIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(73, 23);
            this.btIzmeni.TabIndex = 38;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(145, 352);
            this.btBrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(73, 24);
            this.btBrisi.TabIndex = 37;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 159);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 166);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // cbImePrezime
            // 
            this.cbImePrezime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImePrezime.FormattingEnabled = true;
            this.cbImePrezime.Location = new System.Drawing.Point(145, 105);
            this.cbImePrezime.Margin = new System.Windows.Forms.Padding(2);
            this.cbImePrezime.Name = "cbImePrezime";
            this.cbImePrezime.Size = new System.Drawing.Size(119, 21);
            this.cbImePrezime.TabIndex = 35;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRaspodela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.tbOcena);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbImePrezime);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRaspodela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.TextBox tbOcena;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbImePrezime;
    }
}