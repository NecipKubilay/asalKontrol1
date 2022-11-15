using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilenSayi = Convert.ToInt32(textBox1.Text);
            int asalAdet = 0;

            for (int i = 2; i <= girilenSayi; i++)//2 den girilen sayiya kadar sayilari dolaşıyoruz
            {
                int kontrol = 0;//kontrol değişkeni belirledim

                for (int j= 2; j < i; j++)//girilen sayinin 2 den başlayarak girilensayiya kadar olan sayilara bolunup bolunmedıgını kontrol ediyoruz
                {
                    if (i%j==0)
                    {
                        kontrol++;//eger bolunme gerceklesirse kontrol degıskenı 1 artırılır
                        break;//dongu kırılır bır sonrakı sayıya gecmek ıcın
                    }
                }
                
                if (kontrol==0)//eger bolunme gerceklesmezse kontrol degıskenı hıc artmaz 0 a eşit olursa sayi asaldır listboxa ekliyorum
                {
                    listBox1.Items.Add(i);
                    label1.Text = girilenSayi.ToString();
                    asalAdet++;
                }
            }
            label2.Text = asalAdet.ToString();

            
            
           
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}
