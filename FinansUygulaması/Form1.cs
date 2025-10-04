using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinansUygulaması.Forms;
using FinansUygulaması.Models;
using System.Text.Json;
using System.IO;

namespace FinansUygulaması
{
    public partial class MainForm : Form
    {
        private List<Transaction> islemler = new List<Transaction>();
        private int sonrakiId = 1;
        private string dosyaYolu = "islemler.json";
        public MainForm()
        {
            InitializeComponent();
            VeriYukle();        
            ListeyiYenile();
            OzetGuncelle();
        }

        private void VeriKaydet()
        {
            try
            {
                string json = JsonSerializer.Serialize(islemler, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(dosyaYolu, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kaydetme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VeriYukle()
        {
            try
            {
                if (File.Exists(dosyaYolu))
                {
                    string json = File.ReadAllText(dosyaYolu);
                    islemler = JsonSerializer.Deserialize<List<Transaction>>(json) ?? new List<Transaction>();

                    // En yüksek ID'yi bul
                    if (islemler.Any())
                    {
                        sonrakiId = islemler.Max(i => i.Id) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListeyiYenile()
        {
            dgwIslemler.Rows.Clear();

            foreach (var islem in islemler.OrderByDescending(i => i.Tarih))
            {
                int rowIndex = dgwIslemler.Rows.Add();
                DataGridViewRow row = dgwIslemler.Rows[rowIndex];

                row.Cells["colId"].Value = islem.Id;
                row.Cells["colTarih"].Value = islem.Tarih.ToString("dd/MM/yyyy");
                row.Cells["colTur"].Value = islem.Tur.ToString();
                row.Cells["colKategori"].Value = islem.Kategori;
                row.Cells["colAciklama"].Value = islem.Aciklama;
                row.Cells["colTutar"].Value = islem.Tutar.ToString("N2") + " ₺";

          
                if (islem.Tur == IslemTuru.Gelir)
                    row.DefaultCellStyle.ForeColor = Color.Green;
                else
                    row.DefaultCellStyle.ForeColor = Color.Red;
            }


        }
        private void OzetGuncelle()
        {
            decimal toplamGelir = islemler.Where(i => i.Tur == IslemTuru.Gelir).Sum(i => i.Tutar);
            decimal toplamGider = islemler.Where(i => i.Tur == IslemTuru.Gider).Sum(i => i.Tutar);
            decimal bakiye = toplamGelir - toplamGider;

            lblToplamGelir.Text = toplamGelir.ToString("N2") + " ₺";
            lblToplamGider.Text = toplamGider.ToString("N2") + " ₺";
            lblBakiye.Text = bakiye.ToString("N2") + " ₺";

            
            if (bakiye > 0)
                lblBakiye.ForeColor = Color.Green;
            else if (bakiye < 0)
                lblBakiye.ForeColor = Color.Red;
            else
                lblBakiye.ForeColor = Color.Blue;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            IslemEkleForm form = new IslemEkleForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                form.YeniIslem.Id = sonrakiId++;
                islemler.Add(form.YeniIslem);
                ListeyiYenile();
                OzetGuncelle();
                MessageBox.Show("Gelir başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriKaydet();
            }
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            IslemEkleForm form = new IslemEkleForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                form.YeniIslem.Id = sonrakiId++;
                islemler.Add(form.YeniIslem);
                ListeyiYenile();
                OzetGuncelle();
                MessageBox.Show("Gider başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriKaydet();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgwIslemler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz işlemi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VeriKaydet();

            int selectedId = Convert.ToInt32(dgwIslemler.SelectedRows[0].Cells["colId"].Value);

            var onay = MessageBox.Show("Bu işlemi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                var islem = islemler.FirstOrDefault(i => i.Id == selectedId);
                if (islem != null)
                {
                    islemler.Remove(islem);
                    ListeyiYenile();
                    OzetGuncelle();
                    MessageBox.Show("İşlem silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
            OzetGuncelle();
        }
    }
}
