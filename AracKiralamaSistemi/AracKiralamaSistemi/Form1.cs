using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ardav\\source\\repos\\AracKiralamaSistemi\\AracKiralamaSistemi\\AracKiralama.mdf;Integrated Security=True;";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();       
                    SqlDataAdapter da = new SqlDataAdapter("SELECT AracID, CONCAT(AracMarka, ' ', AracModel, ' - ', Plaka) AS AracBilgisi FROM Araclar", conn);
                    DataTable dt = new DataTable(); 
                    da.Fill(dt); 

                    comboArac.DataSource = dt;
                    comboArac.DisplayMember = "AracBilgisi"; 
                    comboArac.ValueMember = "AracID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();    
                    SqlCommand cmd = new SqlCommand("INSERT INTO Araclar (AracMarka, AracModel, Plaka) VALUES (@Marka, @Model, @Plaka)", conn);
                    cmd.Parameters.AddWithValue("@Marka", txtAracMarka.Text);
                    cmd.Parameters.AddWithValue("@Model", txtAracModel.Text);
                    cmd.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Araç başarıyla eklendi.");

                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private int GetOrCreateMusteriID(SqlConnection conn, string musteriAdi)
        {
            string checkQuery = "SELECT MusteriID FROM Musteriler WHERE AdSoyad = @AdSoyad";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn); 
            checkCmd.Parameters.AddWithValue("@AdSoyad", musteriAdi);
            object result = checkCmd.ExecuteScalar(); 

            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            string insertQuery = "INSERT INTO Musteriler (AdSoyad, Telefon) OUTPUT INSERTED.MusteriID VALUES (@AdSoyad, @Telefon)";
            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@AdSoyad", musteriAdi);
            insertCmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            return (int)insertCmd.ExecuteScalar();
        }


        private void btnKiralama_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string musteriAdi = txtMusteri.Text;
                    int musteriID = GetOrCreateMusteriID(conn, musteriAdi);

                    string query = "INSERT INTO Kiralama (MusteriID, AracID, KiralamaTarihi, TeslimTarihi) " +
                                   "VALUES (@MusteriID, @AracID, @KiralamaTarihi, @TeslimTarihi)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                    cmd.Parameters.AddWithValue("@AracID", comboArac.SelectedValue);
                    cmd.Parameters.AddWithValue("@KiralamaTarihi", dateTimeKiralama.Value);
                    cmd.Parameters.AddWithValue("@TeslimTarihi", dateTimeTeslim.Value);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kiralama işlemi başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT Kiralama.KiralamaID, Musteriler.AdSoyad AS Musteri, 
                                      CONCAT(Araclar.AracMarka, ' - ', Araclar.Plaka) AS Arac, 
                                      Kiralama.KiralamaTarihi, Kiralama.TeslimTarihi
                                      FROM Kiralama
                                      INNER JOIN Musteriler ON Kiralama.MusteriID = Musteriler.MusteriID
                                      INNER JOIN Araclar ON Kiralama.AracID = Araclar.AracID";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["KiralamaID"].Value);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Kiralama WHERE KiralamaID = @KiralamaID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@KiralamaID", secilenID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seçilen kiralama kaydı silindi.");
                        btnListele_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (btnGuncelle.Tag != null)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Kiralama SET MusteriID = @MusteriID, AracID = @AracID, KiralamaTarihi = @KiralamaTarihi, TeslimTarihi = @TeslimTarihi WHERE KiralamaID = @KiralamaID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MusteriID", GetOrCreateMusteriID(conn, txtMusteri.Text));
                        cmd.Parameters.AddWithValue("@AracID", comboArac.SelectedValue);
                        cmd.Parameters.AddWithValue("@KiralamaTarihi", dateTimeKiralama.Value);
                        cmd.Parameters.AddWithValue("@TeslimTarihi", dateTimeTeslim.Value);
                        cmd.Parameters.AddWithValue("@KiralamaID", btnGuncelle.Tag);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kiralama bilgisi güncellendi.");
                        btnListele_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir satır seçin.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                btnGuncelle.Tag = row.Cells["KiralamaID"].Value.ToString();
                txtMusteri.Text = row.Cells["Musteri"].Value.ToString();
                comboArac.Text = row.Cells["Arac"].Value.ToString();
                dateTimeKiralama.Value = Convert.ToDateTime(row.Cells["KiralamaTarihi"].Value);
                dateTimeTeslim.Value = Convert.ToDateTime(row.Cells["TeslimTarihi"].Value);
            }
        }
    }
}
