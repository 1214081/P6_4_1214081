using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_1214081
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Textbox Nama tidak boleh kosong!");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
            else
            {

                if ((tbNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbNama, "Inputan Hanya Boleh Huruf!");
                    epWarning.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "");
                }
            }
        }

        private void tbUsernameValorant_Leave(object sender, EventArgs e)
        {
            if (tbUsernameValorant.Text == "")
            {
                epWarning.SetError(tbUsernameValorant, "Textbox Username Valorant Sekarang tidak boleh kosong!");
                epWrong.SetError(tbUsernameValorant, "");
                epCorrect.SetError(tbUsernameValorant, "");
            }
            else
            {
                if (tbUsernameValorant.Text.Length <= 25)
                {
                    epCorrect.SetError(tbUsernameValorant, "Betul!");
                    epWarning.SetError(tbUsernameValorant, "");
                    epWrong.SetError(tbUsernameValorant, "");
                }
                else
                {
                    epCorrect.SetError(tbUsernameValorant, "");
                    epWarning.SetError(tbUsernameValorant, "");
                    epWrong.SetError(tbUsernameValorant, "Inputan Hanya Boleh Angka!");
                }
            }
        }

        private void tbPendidikanTerakhir_Leave(object sender, EventArgs e)
        {
            if (tbPendidikanTerakhir.Text == "")
            {
                epWarning.SetError(tbPendidikanTerakhir, "Textbox Pendidikan Terakhi tidak boleh kosong!");
                epWrong.SetError(tbPendidikanTerakhir, "");
                epCorrect.SetError(tbPendidikanTerakhir, "");
            }
            else
            {
                if ((tbPendidikanTerakhir.Text).All(Char.IsUpper))
                {
                    epCorrect.SetError(tbPendidikanTerakhir, "Betul!");
                    epWarning.SetError(tbPendidikanTerakhir, "");
                    epWrong.SetError(tbPendidikanTerakhir, "");
                }
                else
                {
                    epCorrect.SetError(tbPendidikanTerakhir, "");
                    epWarning.SetError(tbPendidikanTerakhir, "");
                    epWrong.SetError(tbPendidikanTerakhir, "Inputan Hanya Boleh Huruf Besar!");
                }
            }
        }

        private void tbKotaAsal_Leave(object sender, EventArgs e)
        {
            if (tbKotaAsal.Text == "")
            {
                epWarning.SetError(tbKotaAsal, "Textbox Kota Asal tidak boleh kosong!");
                epWrong.SetError(tbKotaAsal, "");
                epCorrect.SetError(tbKotaAsal, "");
            }
            else
            {
                if ((tbKotaAsal.Text).All(Char.IsLower))
                {
                    epCorrect.SetError(tbKotaAsal, "Betul!");
                    epWarning.SetError(tbKotaAsal, "");
                    epWrong.SetError(tbKotaAsal, "");
                }
                else
                {
                    epCorrect.SetError(tbKotaAsal, "");
                    epWarning.SetError(tbKotaAsal, "");
                    epWrong.SetError(tbKotaAsal, "Inputan Hanya Boleh Huruf Kecil!");
                }
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbEmail, "Format email salah!\nContoh : a@b.c");
                    epWarning.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "");
                }
            }
        }

        private void tbBeratSekarang_Leave(object sender, EventArgs e)
        {
            if (tbBeratSekarang.Text == "")
            {
                epWarning.SetError(tbBeratSekarang, "Textbox Berat Sekarang tidak boleh kosong!");
                epWrong.SetError(tbBeratSekarang, "");
                epCorrect.SetError(tbBeratSekarang, "");
            }
            else
            {
                if ((tbBeratSekarang.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbBeratSekarang, "Betul!");
                    epWarning.SetError(tbBeratSekarang, "");
                    epWrong.SetError(tbBeratSekarang, "");
                }
                else
                {
                    epCorrect.SetError(tbBeratSekarang, "");
                    epWarning.SetError(tbBeratSekarang, "");
                    epWrong.SetError(tbBeratSekarang, "Inputan Hanya Boleh Angka!");
                }
            }
        }

        private void tbBeratTahunKemaren_Leave(object sender, EventArgs e)
        {
            if (tbBeratTahunKemaren.Text == "")
            {
                epWarning.SetError(tbBeratTahunKemaren, "Textbox Berat Tahun Kemaren tidak boleh kosong!");
                epWrong.SetError(tbBeratTahunKemaren, "");
                epCorrect.SetError(tbBeratTahunKemaren, "");
            }
            else
            {
                if ((tbBeratTahunKemaren.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbBeratTahunKemaren, "Betul!");
                    epWarning.SetError(tbBeratTahunKemaren, "");
                    epWrong.SetError(tbBeratTahunKemaren, "");
                }
                else
                {
                    epCorrect.SetError(tbBeratTahunKemaren, "");
                    epWarning.SetError(tbBeratTahunKemaren, "");
                    epWrong.SetError(tbBeratTahunKemaren, "Inputan Hanya Boleh Angka!");
                }
            }
        }

        private void btTampilkan_Click(object sender, EventArgs e)
        {
            int Angka1 = int.Parse(tbBeratSekarang.Text);
            int Angka2 = int.Parse(tbBeratTahunKemaren.Text);

            //Nama
            if (tbNama.Text == "")
            {
                MessageBox.Show("Harus memasukkan nama anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(tbNama.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Masukkan nama anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Username Valorant
            else if (tbUsernameValorant.Text == "")
            {
                MessageBox.Show("Harus memasukkan username valorant anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(tbUsernameValorant.Text.Length <= 25))
            {
                MessageBox.Show("Masukkan username valorant anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Pendidikan Terakhir
            else if (tbPendidikanTerakhir.Text == "")
            {
                MessageBox.Show("Harus memasukkan pendidikan terakhir anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(tbPendidikanTerakhir.Text).All(Char.IsUpper))
            {
                MessageBox.Show("Masukkan pendidikan terakhir anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Kota Asal
            else if (tbKotaAsal.Text == "")
            {
                MessageBox.Show("Harus memasukkan kota asal anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(tbKotaAsal.Text).All(Char.IsLower))
            {
                MessageBox.Show("Masukkan kota asal anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Email
            else if (tbEmail.Text == "")
            {
                MessageBox.Show("Harus memasukkan email anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                MessageBox.Show("Masukkan kota asal anda dengan benar", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Berat Sekarang
            else
            {
                if (Angka1 > Angka2) 
                {
                    int x = Angka1 - Angka2;
                    MessageBox.Show
                    ("Nama\t\t\t: " + tbNama.Text +
                    "\nUsername Valorant\t: " + tbUsernameValorant.Text +
                    "\nPendidikan Terakhir\t: " + tbPendidikanTerakhir.Text +
                    "\nKota Asal\t\t\t: " + tbKotaAsal.Text +
                    "\nEmail\t\t\t: " + tbEmail.Text +
                    "\n\nBerat badan anda tahun ini bertambah sebesar " + x + " kilogram",
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Angka1 < Angka2)
                {
                    int y = Angka2 - Angka1;

                    MessageBox.Show
                    ("Nama\t\t\t: " + tbNama.Text +
                    "\nUsername Valorant\t: " + tbUsernameValorant.Text +
                    "\nPendidikan Terakhir\t: " + tbPendidikanTerakhir.Text +
                    "\nKota Asal\t\t\t: " + tbKotaAsal.Text +
                    "\nEmail\t\t\t: " + tbEmail.Text +
                    "\n\nBerat badan anda tahun ini berkurang sebesar " + y + " kilogram",
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
