using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;




namespace Proje2
{
    public partial class Musterimenu : Form
    {
        
        public static List<Button> butonlar2 = new List<Button>();
        public static Musteri m=new Musteri();
        

        public Musterimenu()
        {
            InitializeComponent();
        }
        

        SqlConnection baglanti = new SqlConnection("Data Source=JARVIS;Initial Catalog=SiparisOtomasyonu;Integrated Security=True");
        private void Musterimenu_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sql = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=1", baglanti);
            SqlDataReader da = sql.ExecuteReader();
            while(da.Read() || da.Read())
            {
                lblSapkaFiyat.Text = da[0].ToString();
                lblSapkaAgirlik.Text = da[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql2 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=2", baglanti);
            SqlDataReader da2 = sql2.ExecuteReader();
            while (da2.Read() || da2.Read())
            {
                lblAyakkabiFiyat.Text = da2[0].ToString();
                lblAyakkabiAgirlik.Text = da2[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql3 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=3", baglanti);
            SqlDataReader da3 = sql3.ExecuteReader();
            while (da3.Read() || da3.Read())
            {
                lblGomlekFiyat.Text = da3[0].ToString();
                lblGomlekAgirlik.Text = da3[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql4 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=4", baglanti);
            SqlDataReader da4 = sql4.ExecuteReader();
            while (da4.Read() || da4.Read())
            {
                lblPantolonFiyat.Text = da4[0].ToString();
                lblPantolonAgirlik.Text = da4[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql5 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=5", baglanti);
            SqlDataReader da5 = sql5.ExecuteReader();
            while (da5.Read() || da5.Read())
            {
                lblSaatFiyat.Text = da5[0].ToString();
                lblSaatAgirlik.Text = da5[1].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand sql6 = new SqlCommand("Select UrunFiyati,UrunAgirligi from Tbl_Urunler where id=6", baglanti);
            SqlDataReader da6 = sql6.ExecuteReader();
            while (da6.Read() || da6.Read())
            {
                lblGozlukFiyat.Text = da6[0].ToString();
                lblGozlukAgirlik.Text = da6[1].ToString();
            }
            baglanti.Close();

        }
       
       
        public void ayakkabıbutton_Click(object sender, EventArgs e)
        {
           
            if (ayakkabıbutton.BackColor==Color.White)
            {
                ayakkabıbutton.BackColor = Color.Turquoise;
            }else 
            {
                ayakkabıbutton.BackColor = Color.White;
            }

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=2", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
          baglanti.Close();
        }

        public void gomlekbutton_Click(object sender, EventArgs e)
        {
            
            if (gomlekbutton.BackColor == Color.White)
            {
                gomlekbutton.BackColor = Color.Turquoise;
            }
            else
            {
                gomlekbutton.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=3", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        private void sapkabutton_Click_1(object sender, EventArgs e)
        {
            
            if (sapkabutton.BackColor == Color.White)
            {
                sapkabutton.BackColor = Color.Turquoise;
            }
            else
            {
                sapkabutton.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=1", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        private void pantolonbutton_Click(object sender, EventArgs e)
        {
           
            if (pantolonbutton.BackColor == Color.White)
            {
                pantolonbutton.BackColor = Color.Turquoise;
            }
            else
            {
                pantolonbutton.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=4", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        private void saatbutton_Click(object sender, EventArgs e)
        {
            
            if (saatbutton.BackColor == Color.White)
            {
                saatbutton.BackColor = Color.Turquoise;
            }
            else
            {
                saatbutton.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=5", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        private void gozlukbutton_Click(object sender, EventArgs e)
        {
            
            if (gozlukbutton.BackColor == Color.White)
            {
                gozlukbutton.BackColor = Color.Turquoise;
            }
            else
            {
                gozlukbutton.BackColor = Color.White;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select UrunAciklama From Tbl_Urunler where id=6", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblUrunAciklama.Text = dr1[0].ToString();
            }
            baglanti.Close();
        }

        public void ürüneklebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=JARVIS;Initial Catalog=SiparisOtomasyonu;Integrated Security=True");
            con.Open();
            
            butonlar2.Add(ayakkabıbutton);
            butonlar2.Add(sapkabutton);
            butonlar2.Add(gomlekbutton);
            butonlar2.Add(gozlukbutton);
            butonlar2.Add(saatbutton);
            butonlar2.Add(pantolonbutton);

            foreach (Button b in butonlar2)
            {

                if (b.BackColor == Color.Turquoise)
                {
                   
                    switch (b.Name)
                    {
                        case "sapkabutton":
                            string adres;
                            SqlCommand cmd = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            adres = dt.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com = new SqlCommand("Insert into Sepet (KullanıcıAdı,UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@k,@a,@b,@c,@d)", con);
                            Urun urun = new Urun { Fiyat = Convert.ToInt32(lblSapkaFiyat.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(lblSapkaAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "sapka", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun);
                            com.Parameters.AddWithValue("@k",KullanıcıGirisi.kullanıcı);
                            com.Parameters.AddWithValue("@a", urun.UrunAdi);
                            com.Parameters.AddWithValue("@b", urun.Fiyat);
                            com.Parameters.AddWithValue("@c", urun.Agirlik);
                            com.Parameters.AddWithValue("@d", urun.UrunAdedi);
                            com.ExecuteNonQuery();
                            sapkabutton.BackColor = Color.White;
                            SqlCommand cmnd = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd.Parameters.AddWithValue("@a", urun.UrunAdi);
                            cmnd.Parameters.AddWithValue("@b", urun.Fiyat);
                            cmnd.Parameters.AddWithValue("@c", urun.Agirlik);
                            cmnd.Parameters.AddWithValue("@d", urun.UrunAdedi);
                            cmnd.Parameters.AddWithValue("@z", adres);
                            cmnd.ExecuteNonQuery();
                            break;
                        case "gozlukbutton":
                            string adres1;
                            SqlCommand cmd1 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd1.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                            DataTable dt1 = new DataTable();
                            da1.Fill(dt1);
                            adres1 = dt1.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com2 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun1 = new Urun { Fiyat = Convert.ToInt32(lblGozlukFiyat.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(lblGozlukAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "gozluk", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun1);

                            com2.Parameters.AddWithValue("@a", urun1.UrunAdi);
                            com2.Parameters.AddWithValue("@b", urun1.Fiyat);
                            com2.Parameters.AddWithValue("@c", urun1.Agirlik);
                            com2.Parameters.AddWithValue("@d", urun1.UrunAdedi);
                            com2.ExecuteNonQuery(); 
                            SqlCommand cmnd1 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd1.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd1.Parameters.AddWithValue("@a", urun1.UrunAdi);
                            cmnd1.Parameters.AddWithValue("@b", urun1.Fiyat);
                            cmnd1.Parameters.AddWithValue("@c", urun1.Agirlik);
                            cmnd1.Parameters.AddWithValue("@d", urun1.UrunAdedi);
                            cmnd1.Parameters.AddWithValue("@z", adres1);
                            cmnd1.ExecuteNonQuery();
                            gozlukbutton.BackColor = Color.White;
                            break;
                        case "saatbutton":
                            string adres2;
                            SqlCommand cmd2 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd2.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            da2.Fill(dt2);
                            adres2 = dt2.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com3 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun2 = new Urun { Fiyat = Convert.ToInt32(lblSaatFiyat.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(lblSaatAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "saat", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun2);
                            com3.Parameters.AddWithValue("@a", urun2.UrunAdi);
                            com3.Parameters.AddWithValue("@b", urun2.Fiyat);
                            com3.Parameters.AddWithValue("@c", urun2.Agirlik);
                            com3.Parameters.AddWithValue("@d", urun2.UrunAdedi);
                            com3.ExecuteNonQuery(); 
                            SqlCommand cmnd2 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd2.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd2.Parameters.AddWithValue("@a", urun2.UrunAdi);
                            cmnd2.Parameters.AddWithValue("@b", urun2.Fiyat);
                            cmnd2.Parameters.AddWithValue("@c", urun2.Agirlik);
                            cmnd2.Parameters.AddWithValue("@d", urun2.UrunAdedi);
                            cmnd2.Parameters.AddWithValue("@z", adres2);

                            saatbutton.BackColor = Color.White;
                            break;
                        case "pantolonbutton":
                            string adres3;
                            SqlCommand cmd3 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd3.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                            DataTable dt3 = new DataTable();
                            da3.Fill(dt3);
                            adres3 = dt3.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com4 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun3 = new Urun { Fiyat = Convert.ToInt32(lblPantolonFiyat.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(lblPantolonAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "pantolon", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun3);
                            com4.Parameters.AddWithValue("@a", urun3.UrunAdi);
                            com4.Parameters.AddWithValue("@b", urun3.Fiyat);
                            com4.Parameters.AddWithValue("@c", urun3.Agirlik);
                            com4.Parameters.AddWithValue("@d", urun3.UrunAdedi);
                            com4.ExecuteNonQuery();
                            SqlCommand cmnd3 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd3.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd3.Parameters.AddWithValue("@a", urun3.UrunAdi);
                            cmnd3.Parameters.AddWithValue("@b", urun3.Fiyat);
                            cmnd3.Parameters.AddWithValue("@c", urun3.Agirlik);
                            cmnd3.Parameters.AddWithValue("@d", urun3.UrunAdedi);
                            cmnd3.Parameters.AddWithValue("@z", adres3);
                            cmnd3.ExecuteNonQuery();
                            pantolonbutton.BackColor = Color.White;
                            break;
                        case "gomlekbutton":
                            string adres4;
                            SqlCommand cmd4 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd4.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                            DataTable dt4 = new DataTable();
                            da4.Fill(dt4);
                            adres4 = dt4.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com5 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun4 = new Urun { Fiyat =Convert.ToInt32(lblGomlekFiyat.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(lblGomlekAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "gomlek", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun4);
                            com5.Parameters.AddWithValue("@a", urun4.UrunAdi);
                            com5.Parameters.AddWithValue("@b", urun4.Fiyat);
                            com5.Parameters.AddWithValue("@c", urun4.Agirlik);
                            com5.Parameters.AddWithValue("@d", urun4.UrunAdedi);
                            com5.ExecuteNonQuery();                          
                            SqlCommand cmnd4 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd4.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd4.Parameters.AddWithValue("@a", urun4.UrunAdi);
                            cmnd4.Parameters.AddWithValue("@b", urun4.Fiyat);
                            cmnd4.Parameters.AddWithValue("@c", urun4.Agirlik);
                            cmnd4.Parameters.AddWithValue("@d", urun4.UrunAdedi);
                            cmnd4.Parameters.AddWithValue("@z", adres4);
                            cmnd4.ExecuteNonQuery();
                            gomlekbutton.BackColor = Color.White;
                            break;
                        case "ayakkabıbutton":
                            string adres5;
                            SqlCommand cmd5 = new SqlCommand("Select MusteriAdres From Tbl_Musteri where MusteriAd=@MusteriAd", con);
                            cmd5.Parameters.AddWithValue("@MusteriAd", KullanıcıGirisi.kullanıcı);
                            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                            DataTable dt5 = new DataTable();
                            da5.Fill(dt5);
                            adres5 = dt5.Rows[0]["MusteriAdres"].ToString();
                            SqlCommand com6 = new SqlCommand("Insert into Sepet (UrunAdi,UrunFiyati,UrunAgirligi,UrunAdedi) values (@a,@b,@c,@d)", con);
                            Urun urun5 = new Urun { Fiyat = Convert.ToInt32(lblAyakkabiFiyat.Text) * Convert.ToInt32(musterimenutextbox.Text), Agirlik = Convert.ToInt32(lblAyakkabiAgirlik.Text) * Convert.ToInt32(musterimenutextbox.Text), UrunAdi = "ayakkabı", UrunAdedi = Convert.ToInt32(musterimenutextbox.Text) };
                            m.Urunler.Add(urun5);
                            com6.Parameters.AddWithValue("@a", urun5.UrunAdi);
                            com6.Parameters.AddWithValue("@b", urun5.Fiyat);
                            com6.Parameters.AddWithValue("@c", urun5.Agirlik);
                            com6.Parameters.AddWithValue("@d", urun5.UrunAdedi);
                            com6.ExecuteNonQuery();
                            SqlCommand cmnd5 = new SqlCommand("Insert into SiparişKaydı  (kullanıcıAdi,UrunAdi,UrunFiyat,UrunAgirligi,UrunAdet,Adres) values (@k,@a,@b,@c,@d,@z)", con);
                            cmnd5.Parameters.AddWithValue("@k", KullanıcıGirisi.kullanıcı);
                            cmnd5.Parameters.AddWithValue("@a", urun5.UrunAdi);
                            cmnd5.Parameters.AddWithValue("@b", urun5.Fiyat);
                            cmnd5.Parameters.AddWithValue("@c", urun5.Agirlik);
                            cmnd5.Parameters.AddWithValue("@d", urun5.UrunAdedi);
                            cmnd5.Parameters.AddWithValue("@z", adres5);
                            cmnd5.ExecuteNonQuery();
                            ayakkabıbutton.BackColor = Color.White;
                            break;
                    }


                }

            }
            con.Close();
        }

        public void sepetimbutton_Click(object sender, EventArgs e)
        {

            sepetim sepet = new sepetim();
            sepet.Show();
            this.Hide();
           
            
        }
    }
}
