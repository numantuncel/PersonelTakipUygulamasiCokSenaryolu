using PersonelTakipUygulamsi1.DataAccessLayer.Abstract;
using PersonelTakipUygulamsi1.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using PersonelTakipUygulamsi1.Tools.Connection.SQLite;
using System.Windows.Forms;

namespace PersonelTakipUygulamsi1.DataAccessLayer.Concrete.SQLite
{
    public class SQLiteCalisanDal : ICalisanDal
    {

        public List<Calisan> Listele(string kosulCümlesi)
        {
            string sorguCümlesi = $"select * from Clisanlar {kosulCümlesi}";
            List<Calisan> calisanlar = new List<Calisan>();
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(sorguCümlesi, SQLiteBaglanti.Connection))/* kosul cümlesi olursa gelir olmazsa olduğu gibi çalışır*/
                {
                    SQLiteBaglanti.BaglantiAc();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Calisan _calisan = new Calisan()
                            {
                                Id = Convert.ToInt32(reader[0]),
                                Adı = reader[1].ToString(),
                                Soyadı = reader[2].ToString(),
                                TcKimlik = reader[3].ToString(),
                                PersonelNo = reader[4].ToString(),
                                DogumTarihi = Convert.ToDateTime(reader[5].ToString()),
                                Departman = reader[6].ToString(),
                                Unvan = reader[7].ToString(),
                                Durumu = reader[8].ToString()

                            };
                            calisanlar.Add(_calisan);
                        }

                    }
                }
                return calisanlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
                return null;
            }
            finally
            {
                SQLiteBaglanti.BaglantiKapat();
            }

        }
        public Calisan Getir(string kosulCümlesi)
        {
            Calisan _calisan = null;
            try
            {
                int _sonuc = 0;
                using (SQLiteCommand command = new SQLiteCommand($"Select Count(*) from Clisanlar {kosulCümlesi}", SQLiteBaglanti.Connection))
                {
                    SQLiteBaglanti.BaglantiAc();
                    _sonuc = Convert.ToInt32(command.ExecuteScalar());/* sorgu sonucu elde edilen kayıt sayısı*/

                }
                if (_sonuc > 1)
                {
                    MessageBox.Show("Yapılan sorugu sonucunda 1' den fazla kayıt bulundu.");
                }
                else if (_sonuc == 1)
                {
                    using (SQLiteCommand command = new SQLiteCommand($"select * from Clisanlar {kosulCümlesi}", SQLiteBaglanti.Connection))
                    {
                        SQLiteBaglanti.BaglantiAc();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                _calisan = new Calisan
                                {
                                    Id = Convert.ToInt32(reader[0]),
                                    Adı = reader[1].ToString(),
                                    Soyadı = reader[2].ToString(),
                                    TcKimlik = reader[3].ToString(),
                                    PersonelNo = reader[4].ToString(),
                                    DogumTarihi = Convert.ToDateTime(reader[5].ToString()),
                                    Departman = reader[6].ToString(),
                                    Unvan = reader[7].ToString(),
                                    Durumu = reader[8].ToString()
                                };
                            }
                        }
                    }

                }
                return _calisan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
                return null;
            }
            finally { SQLiteBaglanti.BaglantiKapat(); }
        }

        public bool Güncelle(Calisan calisan)
        {
            string sorguCümlesi = "update Clisanlar set Ad=@p1,Soyad=@p2,TcKimlik=@p3,PersonelNo=@p4,DogumTarihi=@p5,Departman=@p6,Unvan=@p7,Durumu=@p8 where Id=@p9";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(sorguCümlesi, SQLiteBaglanti.Connection))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Adı);
                    command.Parameters.AddWithValue("@p2", calisan.Soyadı);
                    command.Parameters.AddWithValue("@p3", calisan.TcKimlik);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                    command.Parameters.AddWithValue("@p5", calisan.DogumTarihi.ToString("yyyy.MM.dd"));
                    command.Parameters.AddWithValue("@p6", calisan.Departman);
                    command.Parameters.AddWithValue("@p7", calisan.Unvan);
                    command.Parameters.AddWithValue("@p8", calisan.Durumu);
                    command.Parameters.AddWithValue("@p9", calisan.Id);

                    SQLiteBaglanti.BaglantiAc();

                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
            finally
            {
                SQLiteBaglanti.BaglantiKapat();
            }
        }

        public bool Kaydet(Calisan calisan)
        {
            string sorguCümlesi = "insert into Clisanlar (Ad,Soyad,TcKimlik,PersonelNo,DogumTarihi,Departman,Unvan,Durumu)Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(sorguCümlesi,SQLiteBaglanti.Connection))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Adı);
                    command.Parameters.AddWithValue("@p2", calisan.Soyadı);
                    command.Parameters.AddWithValue("@p3", calisan.TcKimlik);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                    command.Parameters.AddWithValue("@p5", calisan.DogumTarihi.ToString("yyyy.MM.dd"));
                    command.Parameters.AddWithValue("@p6", calisan.Departman);
                    command.Parameters.AddWithValue("@p7", calisan.Unvan);
                    command.Parameters.AddWithValue("@p8", calisan.Durumu);
                   


                    SQLiteBaglanti.BaglantiAc();

                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
            finally
            {
                SQLiteBaglanti.BaglantiKapat();
            }

        }



        public bool Sil(string kosulCümlesi)
        {
            try
            {
                using (SQLiteCommand command=new SQLiteCommand($"delete from Clisanlar {kosulCümlesi}",SQLiteBaglanti.Connection))
                {
                    SQLiteBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
            finally
            {
                SQLiteBaglanti.BaglantiKapat();
            }
        }

        public bool Sil(int id)
        {
           
            try
            {
                using (SQLiteCommand command = new SQLiteCommand($"delete from Clisanlar where Id=@p1", SQLiteBaglanti.Connection))
                {
                    SQLiteBaglanti.BaglantiAc();
                    command.Parameters.AddWithValue("@p1", id);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
            finally
            {
                SQLiteBaglanti.BaglantiKapat();
            }
        }
    }
}
