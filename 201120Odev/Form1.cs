using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201120Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\by_nu\Desktop\Gider";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            Yenile();

        }

        // Button Kısmı
        private void btn_ode_Click(object sender, EventArgs e)
        {
            try
            {
                Ode(txt_isim.Text, Convert.ToDouble(txt_tutar.Text));

                Yenile();

                Temizle();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Boşlukları Doğru Biçimde Giriniz...");
            }
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Karsılastır(txt_isim.Text);

                Yenile();

                Temizle();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Boşlukları Doğru Biçimde Giriniz...");
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                Sil(listBox_kayıtlı.SelectedIndex, 1);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_sil_odenen_Click(object sender, EventArgs e)
        {
            try
            {
                Sil(listBox_odenmis.SelectedIndex, 2);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }
        private void btn_filtre_Click(object sender, EventArgs e)
        {
            Ara(2);
        }
        private void btn_gider_ara_Click(object sender, EventArgs e)
        {
            Ara(1);
        }

        //Diğer Kısımlar
        private void listBox_kayıtlı_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_isim.Text = listBox_kayıtlı.SelectedItem.ToString();

                btn_kaydet.Enabled = false;


            }
            catch (Exception)
            {

                throw;
            }
        }
        private void txt_isim_TextChanged(object sender, EventArgs e)
        {
            btn_kaydet.Enabled = true;
        }
        private void txt_odenen_ara_Click(object sender, EventArgs e) // burada arayama metnini textbox yazdıktan sonra silinmiyor tekrardan tıklandığında textbox içindeki metni otamatik seçiyor.
        {
            txt_odenen_ara.SelectAll();
        }
        private void txt_odenen_ara_TextChanged(object sender, EventArgs e)
        {
            if (txt_odenen_ara.Text == "")
            {
                Yenile();
            }
        }

        //Metot Kısmı
        void Ode(string isim, double fiyat)
        {
            string path = @"C:\Users\by_nu\Desktop\Gider\odenen.txt";
            string zaman = DateTime.Now.ToString().Split(' ')[0];

            if (!File.Exists(path))
            {
                FileStream yaz = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(yaz);
                sw.WriteLine(zaman + "-" + isim.ToUpper() + "-" + fiyat);
                sw.Close();
            }
            else
            {
                FileStream yaz = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(yaz);
                sw.WriteLine(zaman + "-" + isim.ToUpper() + "-" + fiyat);
                sw.Close();
            }
        }
        void Kaydet(string isim)// burada kaydet yazılanı kaydetmek için
        {
            string path = @"C:\Users\by_nu\Desktop\Gider\kayitli.txt";

            if (!File.Exists(path))
            {
                FileStream yaz = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(yaz);
                sw.WriteLine(isim.ToUpper());
                sw.Close();
            }
            else
            {
                FileStream yaz = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(yaz);
                sw.WriteLine(isim.ToUpper());
                sw.Close();
            }
        }
        void Sil(int index, int kontrol)
        {
            if (kontrol == 1)
            {
                string path = @"C:\Users\by_nu\Desktop\Gider\kayitli.txt";

                if (index != -1)
                {
                    listBox_kayıtlı.Items.RemoveAt(index);

                    File.Delete(path);

                    string[] listekayitli = new string[listBox_kayıtlı.Items.Count];

                    for (int i = 0; i < listBox_kayıtlı.Items.Count; i++)
                    {
                        listekayitli[i] = listBox_kayıtlı.Items[i].ToString();
                    }

                    Kaydet(listekayitli, 1);
                }
                else
                {
                    MessageBox.Show("Lütfen Seçim Yapınız...");
                }
            }
            else if (kontrol == 2)
            {
                string path = @"C:\Users\by_nu\Desktop\Gider\odenen.txt";

                if (index != -1)
                {
                    listBox_odenmis.Items.RemoveAt(index);

                    File.Delete(path);

                    string[] listeodenen = new string[listBox_odenmis.Items.Count];

                    for (int i = 0; i < listBox_odenmis.Items.Count; i++)
                    {
                        listeodenen[i] = listBox_odenmis.Items[i].ToString();
                    }

                    Kaydet(listeodenen, 2);
                }
                else
                {
                    MessageBox.Show("Lütfen Seçim Yapınız...");
                }
            }


        }
        void Kaydet(string[] isim, int kontrol)//burada silindiğinde bir veri kalanları tekrardan kaydetmek için
        {
            if (kontrol == 1)
            {
                string path = @"C:\Users\by_nu\Desktop\Gider\kayitli.txt";

                if (!File.Exists(path))
                {
                    FileStream yaz = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(yaz);

                    foreach (var item in isim)
                    {
                        sw.WriteLine(item);
                    }

                    sw.Close();
                }
                else
                {
                    FileStream yaz = new FileStream(path, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(yaz);

                    foreach (var item in isim)
                    {
                        sw.WriteLine(item);
                    }

                    sw.Close();
                }
            }
            else if (kontrol == 2)
            {
                string path = @"C:\Users\by_nu\Desktop\Gider\odenen.txt";

                if (!File.Exists(path))
                {
                    FileStream yaz = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(yaz);

                    foreach (var item in isim)
                    {
                        sw.WriteLine(item);
                    }

                    sw.Close();
                }
                else
                {
                    FileStream yaz = new FileStream(path, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(yaz);

                    foreach (var item in isim)
                    {
                        sw.WriteLine(item);
                    }

                    sw.Close();
                }
            }

        }
        void Karsılastır(string metin)
        {
            string path = @"C:\Users\by_nu\Desktop\Gider\kayitli.txt";

            if (File.Exists(path))
            {
                string[] kayitliliste = File.ReadAllLines(path);

                for (int i = 0; i < kayitliliste.Length; i++)
                {
                    if (!metin.Equals(kayitliliste[i], StringComparison.CurrentCultureIgnoreCase))
                    {
                        Kaydet(metin);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Zaten Var!");
                        break;
                    }
                }
            }
        }
        void Ara(int kontrol)
        {
            if (kontrol == 1)
            {
                if (txt_odenen_ara.Text != "")
                {
                    listBox_odenmis.Items.Clear();

                    string path = @"C:\Users\by_nu\Desktop\Gider\odenen.txt";

                    if (File.Exists(path))
                    {
                        string[] odenenliste = File.ReadAllLines(path);

                        string[] yeniliste = new string[3];

                        for (int i = 0; i < odenenliste.Length; i++)
                        {
                            yeniliste = odenenliste[i].Split('-');

                            for (int j = 0; j < yeniliste.Length; j++)
                            {
                                if (txt_odenen_ara.Text.ToUpper().Contains(yeniliste[1]))
                                {
                                    listBox_odenmis.Items.Add(odenenliste[i]);
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Yenile();
                }
            }
            else if (kontrol == 2)
            {
                listBox_odenmis.Items.Clear();

                string path = @"C:\Users\by_nu\Desktop\Gider\odenen.txt";

                if (File.Exists(path))
                {
                    string[] odenenliste = File.ReadAllLines(path);

                    string[] yeniliste = new string[3];

                    string[] zaman = dateTimePicker1.Value.ToString().Split(' ');


                    for (int i = 0; i < odenenliste.Length; i++)
                    {
                        yeniliste = odenenliste[i].Split('-');

                        for (int j = 0; j < yeniliste.Length; j++)
                        {
                            if (zaman[0].Contains(yeniliste[0]))
                            {
                                listBox_odenmis.Items.Add(odenenliste[i]);
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
        void Yenile()
        {
            listBox_odenmis.Items.Clear();
            listBox_kayıtlı.Items.Clear();
            txt_odenen_ara.Clear();

            string path = @"C:\Users\by_nu\Desktop\Gider\odenen.txt";
            string[] listeOde = null;

            if (File.Exists(path))
            {
                listeOde = File.ReadAllLines(path);

                //tersden listelmesi için for döngüsü kullandım
                for (int i = listeOde.Length; i > 0; i--)
                {
                    listBox_odenmis.Items.Add(listeOde[i - 1]);
                }
            }

            string path2 = @"C:\Users\by_nu\Desktop\Gider\kayitli.txt";
            string[] listekayitli = null;

            if (File.Exists(path2))
            {
                listekayitli = File.ReadAllLines(path2);

                foreach (var item in listekayitli)
                {
                    listBox_kayıtlı.Items.Add(item);
                }
            }
        }
        void Temizle()
        {
            txt_isim.Clear();
            txt_tutar.Clear();
        }

    }
}
