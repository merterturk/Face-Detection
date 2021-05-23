using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Bu sınıftan türetilen nesne sayesinde görsel içindeki yüzleri tanıma, belirleme işlemini yapabilirim.
          CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        private void btnFaceDetection_Click(object sender, EventArgs e)
        {
            //Butona bastığımda open file dialog penceresinin açılmasını sağlıyorum. Burada çoklu seçime izin vermedim. Filtreleme kısmında da JPEG ve jpg dosyalarını filtreledim.
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "*.JPEG | *.jpg" })
            {

                //Eğer bir dosya seçilmiş ise bu dosyayı pictureboxa ekliyorum. Pictureboxa eklediğim görseli Bitmap sınfından türettiğim nesnenin içine atıyorum.
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctFace.Image = Image.FromFile(ofd.FileName);
                    Bitmap gorsel = new Bitmap(pctFace.Image);

                    //Görselin dönüşüm işlemini (byte) yapıyorum.
                    Image<Bgr, byte> goruntu = new Image<Bgr, byte>(gorsel);

                    //Dikdörtgen sınıfından neste türetiyorum
                    Rectangle[] cerceveler = cascadeClassifier.DetectMultiScale(goruntu, 1.4, 0);

                    foreach (Rectangle cerceve in cerceveler)
                    {
                        //Didörtgen çizdiriyorum.
                        using (Graphics grafik = Graphics.FromImage(gorsel))
                        {
                            using (Pen kalem = new Pen(Color.DarkRed, 1))
                            {
                                grafik.DrawRectangle(kalem, cerceve);
                            }
                        }
                    }

                    pctFace.Image = gorsel;

                }
            }
        }

       
    }
}
    
