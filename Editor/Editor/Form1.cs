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

namespace Editor
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            Plaka.Visible = false;
            Mudur.Visible = false;
            
            SidePanel.Top = SirketAraciG.Top;
        }

        private void SirketAraciG_Click(object sender, EventArgs e)
        {
            Mudur.Visible = false;
            Plaka.Visible = true;
            Plaka.Location = new Point(222, 190);
            ListeleArac();
            SidePanel.Top = SirketAraciG.Top;
            Temizle(groupBox4);
            Temizle(groupBox3);
            Temizle(groupBox1);
            Temizle(Mudurgiris);
            MudurSilll.Items.Clear();
        }

        private void MudurG_Click(object sender, EventArgs e)
        {
            Plaka.Visible = false;
            Mudur.Visible = true ;
            Mudur.Location = new Point(222, 190);
            ListeleMudur();
            SidePanel.Top = MudurG.Top;
            Temizle(groupBox4);
            Temizle(groupBox3);
            Temizle(groupBox1);
            Temizle(Mudurgiris);
            PlakaSilll.Items.Clear();
        }
        public void Temizle(GroupBox gr)
        {
            foreach (Control c in gr.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox)
                {
                    c.Text = "";

                }
            }
        }
        void ListeleMudur()
        {
            
            con = new SqlConnection("Data Source=.;Initial Catalog=ZiyaretciTakipS;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Mudurler";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr1;
            con.Open();
            dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                MudurSilll.Items.Add(dr1["AdiSoyadi"]);
            }
            con.Close();
            MudurSilll.SelectedIndex = 0;
        }
        void ListeleArac()
        {

            con = new SqlConnection("Data Source=.;Initial Catalog=ZiyaretciTakipS;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Araclar";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr1;
            con.Open();
            dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                PlakaSilll.Items.Add(dr1["Plaka"]);
            }
            con.Close();
            PlakaSilll.SelectedIndex = 0;
        }

        private void MudurEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Yeni kişi eklensin mi?", "MÜDÜR EKLE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    con = new SqlConnection("Data Source=.;Initial Catalog=ZiyaretciTakipS;Integrated Security=True");
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Mudurler (AdiSoyadi) VALUES('" + MudurEklee.Text.ToUpper() + "')";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();                    
                    Temizle(Mudurgiris);
                    MudurSilll.Items.Clear();
                    ListeleMudur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MudurSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kişi silinsin mi?", "MÜDÜR SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=ZiyaretciTakipS;Integrated Security=True");
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Mudurler WHERE AdiSoyadi='" + MudurSilll.SelectedItem.ToString() + "'";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MudurSilll.Items.RemoveAt(MudurSilll.SelectedIndex);
                Temizle(groupBox1);

            }

        }

        private void PlakaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Yeni araç eklensin mi?", "PLAKA EKLE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    con = new SqlConnection("Data Source=.;Initial Catalog=ZiyaretciTakipS;Integrated Security=True");
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Araclar (Plaka) VALUES('" + PlakaEklee.Text.ToUpper() + "')";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Temizle(groupBox4);
                    PlakaSilll.Items.Clear();
                    ListeleArac();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlakaSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Araç silinsin mi?", "PLAKA SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=ZiyaretciTakipS;Integrated Security=True");
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Araclar WHERE Plaka='" + PlakaSilll.SelectedItem.ToString() + "'";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                PlakaSilll.Items.RemoveAt(PlakaSilll.SelectedIndex);
                Temizle(groupBox3);
            }
        }
    }
}
