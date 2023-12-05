using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İngilizce_Kelime
{
    public partial class Form1 : Form
    {

        String[] kelimeler  = {"abort","about","anchor", "archive","backup","capture","combine","compare","compress", "confirmation", "corrupt", "crash", "delay", "disable", "expand", "export", "feature", "fix", "import", "insert", "install", "ignore", "launch", "move", "optimize", "status", "branch", "cache", "configuration", "field" };
        String[] kelimeler_turkce  = { "durdurmak", "hakkında", "bağlayıcı", "arşivlemek", "yedekleme", "yakalamak", "birleştirme", "karşılaştırma", "sıkıştırma", "doğrulama", "bozuk", "çökmek", "gecikme", "devre dışı", "genişletme", "dışarı aktar", "özellik", "düzeltme", "içe aktarma", "ekleme", "kurma", "yoksay", "çalıştır", "taşı", "iyileştirme", "durum", "dal", "önbellek", "yapılandırma", "alan" };
        
        int doğrusayısı = 0;
        int yanlıssayısı = 0;

        public Form1()
        {
            InitializeComponent();
            Random rastgele = new Random();

            int randomındex = rastgele.Next(0, kelimeler.Length);
            string kelime = kelimeler[randomındex];
            label3.Text = kelimeler_turkce[randomındex];
            label1.Text = kelime;

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text.ToLower();
            if (label3.Text == textBox1.Text)
            {
                this.BackColor = Color.Green;
                doğrusayısı++;
                label6.Text=doğrusayısı.ToString();
            }
            else
            {
                this.BackColor = Color.Red;
                label3.Visible = true;
                yanlıssayısı++;
                label7.Text=yanlıssayısı.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
            textBox1.Clear();
            textBox1.Focus();
            label3.Visible = false;

            Random rastgele = new Random();
            
            int randomındex = rastgele.Next(0,kelimeler.Length);
            string kelime = kelimeler[randomındex];
            label3.Text = kelimeler_turkce[randomındex];
            label1.Text = kelime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

     private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer Enter tuşuna basıldıysa ve buton1 odaklandığı kontrol ise
            if (e.KeyCode == Keys.Enter && this.ActiveControl == button1)
            {
                // buton1'in tıklanmasını tetikleyin
                button1.PerformClick();
            }
        }
    }
}
