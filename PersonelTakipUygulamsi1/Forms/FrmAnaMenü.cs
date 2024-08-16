using PersonelTakipUygulamsi1.DataAccessLayer.Abstract;
using PersonelTakipUygulamsi1.DataAccessLayer.Concrete.SQLite;
using PersonelTakipUygulamsi1.DataAccessLayer.Concrete.SqlServer;
using PersonelTakipUygulamsi1.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulamsi1.Forms
{
    public partial class FrmAnaMenü : Form
    {
        public FrmAnaMenü(string veriTabanı)
        {
            InitializeComponent();

            switch (veriTabanı)
            {
                case "SQLite":
                    calisanDal = new SQLiteCalisanDal();
                    break;
                case "SqlServer":
                    calisanDal=new SqlServerCalisanDal();
                    break;
            }
        }
     
        ICalisanDal calisanDal;
        
        Calisan calisan;

        private bool Kontroller()
        {
            bool kontrol = true;
            foreach (Control item in panelAraçlar.Controls)
            {
                if (item.Text == string.Empty || item.Text == " ")/* boş ise*/
                {
                    kontrol = false;
                }
            }
            return kontrol;
        }

        private void Temizle()
        {
            foreach (Control item in panelAraçlar.Controls)
            {
                if (item.GetType().Name != "Label")
                {
                    item.Text = string.Empty;
                }

            }
            dateDogumTarihi.Format = DateTimePickerFormat.Custom;
            dateDogumTarihi.CustomFormat = " ";

        }

        private void GridViewDüzenle()
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["DogumTarihi"].HeaderText = "Doğum Tarihi";


            dataGridView1.ClearSelection();

        }

        private string kosulCümlesiOluştur()
        {
            string kosulCümlesi = string.Empty;
            List<string> alanlar = new List<string>();
            foreach (Control item in panelAraçlar.Controls)
            {
                if (item.Tag == null)
                {
                    continue;
                }
                string alanAdi = item.Tag.ToString();
                string deger = string.Empty;

                if (string.IsNullOrEmpty(item.Text) || item.Text == " ")
                {
                    continue;
                }
                deger = item.Text;

                if (item.Name == "dateDogumTarihi")
                {

                    alanlar.Add($"{alanAdi}='{deger}'");
                }
                else
                {
                    alanlar.Add($"{alanAdi} LIKE '%{deger}%'");
                }
            }
            if (alanlar.Count > 0)
            {
                kosulCümlesi = $"where {string.Join(" and ", alanlar)}";/* tek tek dolaşıp and joini ile bağla*/
            }

            return kosulCümlesi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!Kontroller())
            {
                MessageBox.Show("Lütfen Gerekli Boşlukları Doldurun.");
            }
            else
            {
                calisan = new Calisan()
                {
                    Adı = textAdı.Text,
                    Soyadı = textSoyadı.Text,
                    TcKimlik = textTc.Text,
                    PersonelNo = textPerNo.Text,
                    DogumTarihi = dateDogumTarihi.Value,
                    Departman = comboDepartman.Text,
                    Unvan = comboUnvan.SelectedItem.ToString(),
                    Durumu = comboDurum.SelectedItem.ToString(),

                };

                bool islem = calisanDal.Kaydet(calisan);
                if (islem)
                {

                    MessageBox.Show("Kayıt İşlemi Yapıldı.");
                    dataGridView1.DataSource = calisanDal.Listele(string.Empty);
                    Temizle();
                    GridViewDüzenle();

                }
            }
        }

        private void dateDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dateDogumTarihi.Format = DateTimePickerFormat.Short;
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            calisan = calisanDal.Getir(kosulCümlesiOluştur());
            GridViewDüzenle();
            if (calisan != null)
            {
                MessageBox.Show(calisan.Id.ToString() + "\n" +calisan.Adı.ToString()+ "\n" + calisan.Soyadı.ToString() + "\n" + calisan.TcKimlik.ToString() + "\n" + calisan.PersonelNo.ToString() + "\n" + calisan.DogumTarihi.ToString() + "\n" + calisan.Departman.ToString() + "\n" +
                    calisan.Unvan.ToString() + "\n" + calisan.Durumu.ToString());
            }


        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = calisanDal.Listele(kosulCümlesiOluştur());
            GridViewDüzenle();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = calisanDal.Listele("where durumu='Aktif Çalışan'");
            secilenCalisanId = 0;
            Temizle();
            GridViewDüzenle();
        }

        private void FrmAnaMenü_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = calisanDal.Listele(string.Empty);
            GridViewDüzenle();
            Temizle();
        }

        private int secilenCalisanId;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenCalisanId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textAdı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textSoyadı.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textPerNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateDogumTarihi.Format = DateTimePickerFormat.Short;
            dateDogumTarihi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            comboDepartman.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboUnvan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboDurum.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (secilenCalisanId == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçiniz.");
            }
            else if (!Kontroller())
            {
                MessageBox.Show("Lütfen Gerekli Boşlukları Doldurun.");
            }
            else
            {
                calisan = new Calisan()
                {
                    Id = secilenCalisanId,
                    Adı = textAdı.Text,
                    Soyadı = textSoyadı.Text,
                    TcKimlik = textTc.Text,
                    PersonelNo = textPerNo.Text,
                    DogumTarihi = dateDogumTarihi.Value,
                    Departman = comboDepartman.Text,
                    Unvan = comboUnvan.SelectedItem.ToString(),
                    Durumu = comboDurum.SelectedItem.ToString(),

                };

                bool islem = calisanDal.Güncelle(calisan);
                if (islem)
                {

                    MessageBox.Show("Güncelleme İşlemi Yapıldı.");
                    dataGridView1.DataSource = calisanDal.Listele("where durumu='Aktif Çalışan'");
                    GridViewDüzenle();
                    Temizle();

                }
                secilenCalisanId = 0;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenCalisanId == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz.");
            }

            else
            {
                DialogResult onay = MessageBox.Show("Seçilen kayıt kalıcı olarak silincekdir. \n" +
                    "Kayıt silme işlemini onaylıyormusunuz?", "Kayıt Silme Onayı", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    bool islem = calisanDal.Sil(secilenCalisanId);
                    if (islem)
                    {
                        dataGridView1.DataSource = calisanDal.Listele("where durumu='Aktif Çalışan'");
                        GridViewDüzenle();
                        Temizle();
                        MessageBox.Show("Silme İşlemi Yapıldı.");

                    }




                }
                secilenCalisanId = 0;
            }
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {

            DialogResult onay = MessageBox.Show("Tüm kayıtlar kalıcı olarak silincekdir. \n" +
                   "Silme işlemini onaylıyormusunuz?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                bool islem = calisanDal.Sil(string.Empty);/*  string türde boş değer*/
                if (islem)
                {
                    dataGridView1.DataSource = null;
                    
                    MessageBox.Show("Tüm kayıtlar silindi");

                }
                

            }


        }
    }
}
