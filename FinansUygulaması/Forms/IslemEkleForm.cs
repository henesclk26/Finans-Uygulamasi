using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinansUygulaması.Models;

namespace FinansUygulaması.Forms
{
    public partial class IslemEkleForm : Form
    {
        public Transaction YeniIslem { get; private set; }
        public IslemEkleForm()
        {
            InitializeComponent();
            KategorileriYukle(true);
        }

        private void KategorileriYukle(bool gelirMi)
        {
            cmbKategori.Items.Clear();

            if (gelirMi)
            {
                cmbKategori.Items.Add("Maaş");
                cmbKategori.Items.Add("Yatırım");
                cmbKategori.Items.Add("Ek İş");
                cmbKategori.Items.Add("Diğer");
            }
            else
            {
                cmbKategori.Items.Add("Yemek");
                cmbKategori.Items.Add("Ulaşım");
                cmbKategori.Items.Add("Fatura");
                cmbKategori.Items.Add("Eğlence");
                cmbKategori.Items.Add("Sağlık");
                cmbKategori.Items.Add("Alışveriş");
                cmbKategori.Items.Add("Diğer");
            }

            cmbKategori.SelectedIndex = 0;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rbGelir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGelir.Checked)
            {
                KategorileriYukle(true);
            }
        }

        private void rbGider_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGider.Checked)
            {
                KategorileriYukle(false);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Validasyon - boş alan kontrolü
            if (string.IsNullOrWhiteSpace(tbxAciklama.Text))
            {
                MessageBox.Show("Lütfen açıklama giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxTutar.Text))
            {
                MessageBox.Show("Lütfen tutar giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tutar kontrolü
            if (!decimal.TryParse(tbxTutar.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbKategori.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kategori seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yeni işlem oluştur
            YeniIslem = new Transaction
            {
                Aciklama = tbxAciklama.Text.Trim(),
                Tutar = tutar,
                Tur = rbGelir.Checked ? IslemTuru.Gelir : IslemTuru.Gider,
                Kategori = cmbKategori.SelectedItem.ToString(),
                Tarih = dtpTarih.Value
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
