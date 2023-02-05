using Microsoft.VisualBasic;
namespace Monopoly_Mini
{
    public partial class Form1 : Form
    {
        Random rnd = new();
        List<string> oyuncular = new List<string>() {
            "Oyuncu 1",
            "Oyuncu 2",
            "Oyuncu 3",
            "Oyuncu 4",
            "Oyuncu 5",
            "Oyuncu 6",
            "Oyuncu 7",
            "Oyuncu 8" };
        int tut = 0;

        string Arsa1 = "Ba�c�lar:\n\nGe�i� �creti : 2$\nTam Set �creti : 4$\n1 Ev Kiras� : 10$\n2 Ev Kiras� : 30$\n3 Ev Kiras� : 90$\n4 Ev Kiras� : 160$\nOtel Kiras� : 250$\n-------------\nEvin Maliyeti : 50$\nOtelin Maliyeti : 50$\n-------------\n�potek Bedeli: 30$\n�potekten ��karma Maliyeti : 33$";
        string Arsa2 = "Esenler:\n\nGe�i� �creti : 4$\nTam Set �creti : 8$\n1 Ev Kiras� : 20$\n2 Ev Kiras� : 60$\n3 Ev Kiras� : 180$\n4 Ev Kiras� : 320$\nOtel Kiras� : 450$\n-------------\nEvin Maliyeti : 50$\nOtelin Maliyeti : 50$\n-------------\n�potek Bedeli: 30$\n�potekten ��karma Maliyeti : 33$";
        string Arsa3 = "Tuzla:\n\nGe�i� �creti : 6$\nTam Set �creti : 12$\n1 Ev Kiras� : 30$\n2 Ev Kiras� : 90$\n3 Ev Kiras� : 270$\n4 Ev Kiras� : 400$\nOtel Kiras� : 550$\n-------------\nEvin Maliyeti : 50$\nOtelin Maliyeti : 50$\n-------------\n�potek Bedeli: 50$\n�potekten ��karma Maliyeti : 55$";
        string Arsa4 = "Pendik:\n\nGe�i� �creti : 6$\nTam Set �creti : 12$\n1 Ev Kiras� : 30$\n2 Ev Kiras� : 90$\n3 Ev Kiras� : 270$\n4 Ev Kiras� : 400$\nOtel Kiras� : 550$\n-------------\nEvin Maliyeti : 50$\nOtelin Maliyeti : 50$\n-------------\n�potek Bedeli: 50$\n�potekten ��karma Maliyeti : 55$";
        string Arsa5 = "Kartal:\n\nGe�i� �creti : 8$\nTam Set �creti : 16$\n1 Ev Kiras� : 40$\n2 Ev Kiras� : 100$\n3 Ev Kiras� : 300$\n4 Ev Kiras� : 450$\nOtel Kiras� : 600$\n-------------\nEvin Maliyeti : 50$\nOtelin Maliyeti : 50$\n-------------\n�potek Bedeli: 60$\n�potekten ��karma Maliyeti : 66$";
        string Arsa6 = "Beyo�lu:\n\nGe�i� �creti : 10$\nTam Set �creti : 20$\n1 Ev Kiras� : 50$\n2 Ev Kiras� : 150$\n3 Ev Kiras� : 450$\n4 Ev Kiras� : 625$\nOtel Kiras� : 750$\n-------------\nEvin Maliyeti : 100$\nOtelin Maliyeti : 100$\n-------------\n�potek Bedeli: 70$\n�potekten ��karma Maliyeti : 77$";
        string Arsa7 = "Ka��thane:\n\nGe�i� �creti : 10$\nTam Set �creti : 20$\n1 Ev Kiras� : 50$\n2 Ev Kiras� : 150$\n3 Ev Kiras� : 450$\n4 Ev Kiras� : 625$\nOtel Kiras� : 750$\n-------------\nEvin Maliyeti : 100$\nOtelin Maliyeti : 100$\n-------------\n�potek Bedeli: 70$\n�potekten ��karma Maliyeti : 77$";
        string Arsa8 = "�i�li:\n\nGe�i� �creti : 12$\nTam Set �creti : 24$\n1 Ev Kiras� : 60$\n2 Ev Kiras� : 180$\n3 Ev Kiras� : 500$\n4 Ev Kiras� : 700$\nOtel Kiras� : 900$\n-------------\nEvin Maliyeti : 100$\nOtelin Maliyeti : 100$\n-------------\n�potek Bedeli: 80$\n�potekten ��karma Maliyeti : 88$";
        string Arsa9 = "Ba�ak�ehir :\n\nGe�i� �creti : 14$\nTam Set �creti : 28$\n1 Ev Kiras� : 70$\n2 Ev Kiras� : 200$\n3 Ev Kiras� : 550$\n4 Ev Kiras� : 750$\nOtel Kiras� : 950$\n-------------\nEvin Maliyeti : 100$\nOtelin Maliyeti : 100$\n-------------\n�potek Bedeli: 90$\n�potekten ��karma Maliyeti : 99$";
        string Arsa10 = "Zeytinburnu :\n\nGe�i� �creti : 14$\nTam Set �creti : 28$\n1 Ev Kiras� : 70$\n2 Ev Kiras� : 200$\n3 Ev Kiras� : 550$\n4 Ev Kiras� : 750$\nOtel Kiras� : 950$\n-------------\nEvin Maliyeti : 100$\nOtelin Maliyeti : 100$\n-------------\n�potek Bedeli: 90$\n�potekten ��karma Maliyeti : 99$";
        string Arsa11 = "B�y�k�ekmece:\n\nGe�i� �creti : 16$\nTam Set �creti : 32$\n1 Ev Kiras� : 80$\n2 Ev Kiras� : 220$\n3 Ev Kiras� : 600$\n4 Ev Kiras� : 800$\nOtel Kiras� : 1000$\n-------------\nEvin Maliyeti : 100$\nOtelin Maliyeti : 100$\n-------------\n�potek Bedeli: 100$\n�potekten ��karma Maliyeti : 110$";
        string Arsa12 = "Kad�k�y :\n\nGe�i� �creti : 18$\nTam Set �creti : 36$\n1 Ev Kiras� : 90$\n2 Ev Kiras� : 250$\n3 Ev Kiras� : 700$\n4 Ev Kiras� : 875$\nOtel Kiras� : 1050$\n-------------\nEvin Maliyeti : 150$\nOtelin Maliyeti : 150$\n-------------\n�potek Bedeli: 110$\n�potekten ��karma Maliyeti : 121$";
        string Arsa13 = "Sar�yer :\n\nGe�i� �creti : 18$\nTam Set �creti : 36$\n1 Ev Kiras� : 90$\n2 Ev Kiras� : 250$\n3 Ev Kiras� : 700$\n4 Ev Kiras� : 875$\nOtel Kiras� : 1050$\n-------------\nEvin Maliyeti : 150$\nOtelin Maliyeti : 150$\n-------------\n�potek Bedeli: 110$\n�potekten ��karma Maliyeti : 121$";
        string Arsa14 = "Sancaktepe:\n\nGe�i� �creti : 20$\nTam Set �creti : 40$\n1 Ev Kiras� : 100$\n2 Ev Kiras� : 300$\n3 Ev Kiras� : 750$\n4 Ev Kiras� : 925$\nOtel Kiras� : 1100$\n-------------\nEvin Maliyeti : 150$\nOtelin Maliyeti : 150$\n-------------\n�potek Bedeli: 120$\n�potekten ��karma Maliyeti : 132$";
        string Arsa15 = "Be�ikta� :\n\nGe�i� �creti : 22$\nTam Set �creti : 44$\n1 Ev Kiras� : 110$\n2 Ev Kiras� : 330$\n3 Ev Kiras� : 800$\n4 Ev Kiras� : 975$\nOtel Kiras� : 1150$\n-------------\nEvin Maliyeti : 150$\nOtelin Maliyeti : 150$\n-------------\n�potek Bedeli: 130$\n�potekten ��karma Maliyeti : 143$";
        string Arsa16 = "Ata�ehir :\n\nGe�i� �creti : 22$\nTam Set �creti : 44$\n1 Ev Kiras� : 110$\n2 Ev Kiras� : 330$\n3 Ev Kiras� : 800$\n4 Ev Kiras� : 975$\nOtel Kiras� : 1150$\n-------------\nEvin Maliyeti : 150$\nOtelin Maliyeti : 150$\n-------------\n�potek Bedeli: 130$\n�potekten ��karma Maliyeti : 143$";
        string Arsa17 = "�sk�dar :\n\nGe�i� �creti : 24$\nTam Set �creti : 48$\n1 Ev Kiras� : 120$\n2 Ev Kiras� : 360$\n3 Ev Kiras� : 850$\n4 Ev Kiras� : 1025$\nOtel Kiras� : 1200$\n-------------\nEvin Maliyeti : 150$\nOtelin Maliyeti : 150$\n-------------\n�potek Bedeli: 140$\n�potekten ��karma Maliyeti : 154$";
        string Arsa18 = "Fatih :\n\nGe�i� �creti : 26$\nTam Set �creti :52$\n1 Ev Kiras� : 130$\n2 Ev Kiras� : 390$\n3 Ev Kiras� : 900$\n4 Ev Kiras� : 1100$\nOtel Kiras� : 1275$\n-------------\nEvin Maliyeti : 200$\nOtelin Maliyeti : 200$\n-------------\n�potek Bedeli: 150$\n�potekten ��karma Maliyeti : 165$";
        string Arsa19 = "Silivri :\n\nGe�i� �creti : 26$\nTam Set �creti :52$\n1 Ev Kiras� : 130$\n2 Ev Kiras� : 390$\n3 Ev Kiras� : 900$\n4 Ev Kiras� : 1100$\nOtel Kiras� : 1275$\n-------------\nEvin Maliyeti : 200$\nOtelin Maliyeti : 200$\n-------------\n�potek Bedeli: 150$\n�potekten ��karma Maliyeti : 165$";
        string Arsa20 = "Adalar :\n\nGe�i� �creti : 28$\nTam Set �creti : 56$\n1 Ev Kiras� : 150$\n2 Ev Kiras� : 450$\n3 Ev Kiras� : 1000$\n4 Ev Kiras� : 1200$\nOtel Kiras� : 1400$\n-------------\nEvin Maliyeti : 200$\nOtelin Maliyeti : 200$\n-------------\n�potek Bedeli: 160$\n�potekten ��karma Maliyeti : 176$";
        string Arsa21 = "Etiler :\n\nGe�i� �creti : 35$\nTam Set �creti : 70$\n1 Ev Kiras� : 175$\n2 Ev Kiras� : 500$\n3 Ev Kiras� : 1100$\n4 Ev Kiras� : 1300$\nOtel Kiras� : 1500$\n-------------\nEvin Maliyeti : 200$\nOtelin Maliyeti : 200$\n-------------\n�potek Bedeli: 175$\n�potekten ��karma Maliyeti : 193$";
        string Arsa22 = "Ni�anta�� :\n\nGe�i� �creti : 50$\nTam Set �creti : 100$\n1 Ev Kiras� : 200$\n2 Ev Kiras� : 600$\n3 Ev Kiras� : 1400$\n4 Ev Kiras� : 1700$\nOtel Kiras� : 2000$\n-------------\nEvin Maliyeti : 200$\nOtelin Maliyeti : 200$\n-------------\n�potek Bedeli: 200$\n�potekten ��karma Maliyeti : 220$";

        int home1 = 0; int otel1 = 0;
        int home2 = 0; int otel2 = 0;
        int home3 = 0; int otel3 = 0;
        int home4 = 0; int otel4 = 0;
        int home5 = 0; int otel5 = 0;
        int home6 = 0; int otel6 = 0;
        int home7 = 0; int otel7 = 0;
        int home8 = 0; int otel8 = 0;
        int home9 = 0; int otel9 = 0;
        int home10 = 0; int otel10 = 0;
        int home11 = 0; int otel11 = 0;
        int home12 = 0; int otel12 = 0;
        int home13 = 0; int otel13 = 0;
        int home14 = 0; int otel14 = 0;
        int home15 = 0; int otel15 = 0;
        int home16 = 0; int otel16 = 0;
        int home17 = 0; int otel17 = 0;
        int home18 = 0; int otel18 = 0;
        int home19 = 0; int otel19 = 0;
        int home20 = 0; int otel20 = 0;
        int home21 = 0; int otel21 = 0;
        int home22 = 0; int otel22 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> Tapular = new List<string> {"Ba�c�lar","Esenler",
                                                   "Tuzla","Pendik","Kartal",
                                                   "Beyo�lu","Ka��thane","�i�li",
                                                   "Ba�ak�ehir","Zeytinbrnu","B�y�k�ekmece",
                                                   "Kad�k�y","Sar�yer","Sancaktepe",
                                                   "Be�ikta�","Ata�ehir","�sk�dar",
                                                   "Fatih","Silivri","Adalar",
                                                   "Etiler","Ni�anta��"};
            List<string> Oyuncu1 = new();
            List<string> Oyuncu2 = new();
            List<string> Oyuncu3 = new();
            List<string> Oyuncu4 = new();
            List<string> Oyuncu5 = new();
            List<string> Oyuncu6 = new();
            List<string> Oyuncu7 = new();
            List<string> Oyuncu8 = new();

            for (int i = 0; i < 22; i++)
            {
                cboxTapular.Items.Add(Banka.Items[i]);
                Arsa.Items.Add(Banka.Items[i]);
            }
            for (int i = 0; i < 4; i++)
            {
                cboxTapular.Items.Add(cboxIstasyon.Items[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                cboxTapular.Items.Add(cboxIsDaireleri.Items[i]);
            }
            try
            {
                int oyuncuSayisi = Convert.ToInt32(Interaction.InputBox("Oyuncu Say�s�n� Giriniz : ", "Oyuncu Say�s�"));
                int labelyukseklik = 55;
                oyuncular.Add("Banka");
                cboxIstenen.Items.Add("Banka");
                cboxIsteyen.Items.Add("Banka");

                for (int i = 0; i < oyuncuSayisi; i++)
                {
                    oyuncular[i] = Interaction.InputBox("Oyuncu �smi Giriniz : ", "Oyuncu �simleri Giriliyor");
                    Label label = new();
                    label.Top = labelyukseklik;
                    label.Left = 12;
                    label.Text = oyuncular[i];
                    this.Controls.Add(label);
                    labelyukseklik += 34;
                    cboxIstenen.Items.Add(oyuncular[i]);
                    cboxIsteyen.Items.Add(oyuncular[i]);
                }
            }
            catch { }
        }

        int lokasyonXp1 = 1370; int lokasyonYp1 = 900;
        int lokasyonXp2 = 1370; int lokasyonYp2 = 900;
        int lokasyonXp3 = 1370; int lokasyonYp3 = 900;
        int lokasyonXp4 = 1370; int lokasyonYp4 = 900;
        int lokasyonXp5 = 1370; int lokasyonYp5 = 900;
        int lokasyonXp6 = 1370; int lokasyonYp6 = 900;
        int lokasyonXp7 = 1370; int lokasyonYp7 = 900;
        int lokasyonXp8 = 1370; int lokasyonYp8 = 900;

        //Zar
        private void button1_Click(object sender, EventArgs e)
        {
            tut = rnd.Next(1, 2);
            zarSonuc.Text = tut.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            zarSonuc.Text = rnd.Next(3, 19).ToString();
        }


        //Oyuna Gir
        private void button3_Click(object sender, EventArgs e)
        {
            p1.Location = new Point(1370, 900); button3.Enabled = false; p1b.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            p2.Location = new Point(1370, 900); button4.Enabled = false; p2b.Enabled = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            p3.Location = new Point(1370, 900); button5.Enabled = false; p3b.Enabled = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            p4.Location = new Point(1370, 900); button6.Enabled = false; p4b.Enabled = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            p5.Location = new Point(1370, 900); button7.Enabled = false; p5b.Enabled = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            p6.Location = new Point(1370, 900); button8.Enabled = false; p6b.Enabled = true;
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            p7.Location = new Point(1370, 900); button9.Enabled = false; p7b.Enabled = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            p8.Location = new Point(1370, 900); button10.Enabled = false; p8b.Enabled = true;
        }

        //�lerle
        private void p1b_Click(object sender, EventArgs e)
        {

            for (int q = 0; q < tut; q++)
            {
                if (lokasyonXp1 > 550 && lokasyonYp1 == 900)   //Sola
                {
                    lokasyonXp1 -= 85;
                }
                else if (lokasyonXp1 == 520 && lokasyonYp1 > 50)     //Yukar�
                {
                    lokasyonYp1 -= 85;
                }
                else if (lokasyonXp1 < 1360 && lokasyonXp1 >= 520 && lokasyonYp1 == 50)   //Sa�a
                {
                    lokasyonXp1 += 85;
                }
                else if (lokasyonXp1 == 1370 && lokasyonYp1 >= 50)   //A�a��
                {
                    lokasyonYp1 += 85;
                }
                System.Threading.Thread.Sleep(500);
                p1.Location = new Point(lokasyonXp1, lokasyonYp1);
            }
            if (p1.Location.X == 1370 && p1.Location.Y == 50)    //KODES
            {
                p1.Location = new Point(520, 900);
                lokasyonXp1 = 520; lokasyonYp1 = 900;
            }
        }
        private void p2b_Click(object sender, EventArgs e)
        {

            for (int q = 0; q < tut; q++)
            {
                if (lokasyonXp2 > 550 && lokasyonYp2 == 900)   //Sola
                {
                    lokasyonXp2 -= 85;
                }
                else if (lokasyonXp2 == 520 && lokasyonYp2 > 50)     //Yukar�
                {
                    lokasyonYp2 -= 85;
                }
                else if (lokasyonXp2 < 1360 && lokasyonXp2 >= 520 && lokasyonYp2 == 50)   //Sa�a
                {
                    lokasyonXp2 += 85;
                }
                else if (lokasyonXp2 == 1370 && lokasyonYp2 >= 50)   //A�a��
                {
                    lokasyonYp2 += 85;
                }
                System.Threading.Thread.Sleep(500);
                p2.Location = new Point(lokasyonXp2, lokasyonYp2);

            }
            if (p2.Location.X == 1370 && p2.Location.Y == 50)    //KODES
            {
                p2.Location = new Point(520, 900);
                lokasyonXp2 = 520; lokasyonYp2 = 900;
            }
        }
        private void p3b_Click(object sender, EventArgs e)
        {

            for (int q = 0; q < tut; q++)
            {
                if (lokasyonXp3 > 550 && lokasyonYp3 == 900)   //Sola
                {
                    lokasyonXp3 -= 85;
                }
                else if (lokasyonXp3 == 520 && lokasyonYp3 > 50)     //Yukar�
                {
                    lokasyonYp3 -= 85;
                }
                else if (lokasyonXp3 < 1360 && lokasyonXp3 >= 520 && lokasyonYp3 == 50)   //Sa�a
                {
                    lokasyonXp3 += 85;
                }
                else if (lokasyonXp3 == 1370 && lokasyonYp3 >= 50)   //A�a��
                {
                    lokasyonYp3 += 85;
                }
                System.Threading.Thread.Sleep(500);
                p3.Location = new Point(lokasyonXp3, lokasyonYp3);

            }
            if (p3.Location.X == 1370 && p3.Location.Y == 50)    //KODES
            {
                p3.Location = new Point(520, 900);
                lokasyonXp3 = 520; lokasyonYp3 = 900;
            }
        }
        private void p4b_Click(object sender, EventArgs e)
        {

            for (int q = 0; q < tut; q++)
            {
                if (lokasyonXp4 > 550 && lokasyonYp4 == 900)   //Sola
                {
                    lokasyonXp4 -= 85;
                }
                else if (lokasyonXp4 == 520 && lokasyonYp4 > 50)     //Yukar�
                {
                    lokasyonYp4 -= 85;
                }
                else if (lokasyonXp4 < 1360 && lokasyonXp4 >= 520 && lokasyonYp4 == 50)   //Sa�a
                {
                    lokasyonXp4 += 85;
                }
                else if (lokasyonXp4 == 1370 && lokasyonYp4 >= 50)   //A�a��
                {
                    lokasyonYp4 += 85;
                }
                System.Threading.Thread.Sleep(500);
                p4.Location = new Point(lokasyonXp4, lokasyonYp4);
            }
            if (p4.Location.X == 1370 && p4.Location.Y == 50)    //KODES
            {
                p4.Location = new Point(520, 900);
                lokasyonXp4 = 520; lokasyonYp4 = 900;
            }
        }
        private void p5b_Click(object sender, EventArgs e)
        {

            for (int q = 0; q < tut; q++)
            {
                if (lokasyonXp5 > 550 && lokasyonYp5 == 900)   //Sola
                {
                    lokasyonXp5 -= 85;
                }
                else if (lokasyonXp5 == 520 && lokasyonYp5 > 50)     //Yukar�
                {
                    lokasyonYp5 -= 85;
                }
                else if (lokasyonXp5 < 1360 && lokasyonXp5 >= 520 && lokasyonYp5 == 50)   //Sa�a
                {
                    lokasyonXp5 += 85;
                }
                else if (lokasyonXp5 == 1370 && lokasyonYp5 >= 50)   //A�a��
                {
                    lokasyonYp5 += 85;
                }
                System.Threading.Thread.Sleep(500);
                p5.Location = new Point(lokasyonXp5, lokasyonYp5);
            }
            if (p5.Location.X == 1370 && p5.Location.Y == 50)    //KODES
            {
                p5.Location = new Point(520, 900);
                lokasyonXp5 = 520; lokasyonYp5 = 900;
            }
        }
        private void p6b_Click(object sender, EventArgs e)
        {

            for (int q = 0; q < tut; q++)
            {
                if (lokasyonXp6 > 550 && lokasyonYp6 == 900)   //Sola
                {
                    lokasyonXp6 -= 85;
                }
                else if (lokasyonXp6 == 520 && lokasyonYp6 > 50)     //Yukar�
                {
                    lokasyonYp6 -= 85;
                }
                else if (lokasyonXp6 < 1360 && lokasyonXp6 >= 520 && lokasyonYp6 == 50)   //Sa�a
                {
                    lokasyonXp6 += 85;
                }
                else if (lokasyonXp6 == 1370 && lokasyonYp6 >= 50)  //A�a��
                {
                    lokasyonYp6 += 85;
                }
                System.Threading.Thread.Sleep(500);
                p6.Location = new Point(lokasyonXp6, lokasyonYp6);
            }
            if (p6.Location.X == 1370 && p6.Location.Y == 50)   //KODES
            {
                p6.Location = new Point(520, 900);
                lokasyonXp6 = 520; lokasyonYp6 = 900;
            }
        }
        private void p7b_Click(object sender, EventArgs e)
        {

            for (int q = 0; q < tut; q++)
            {
                if (lokasyonXp7 > 550 && lokasyonYp7 == 900)  //Sola
                {
                    lokasyonXp7 -= 85;
                }
                else if (lokasyonXp7 == 520 && lokasyonYp7 > 50)    //Yukar�
                {
                    lokasyonYp7 -= 85;
                }
                else if (lokasyonXp7 < 1360 && lokasyonXp7 >= 520 && lokasyonYp7 == 50)  //Sa�a
                {
                    lokasyonXp7 += 85;
                }
                else if (lokasyonXp7 == 1370 && lokasyonYp7 >= 50)   //A�a��
                {
                    lokasyonYp7 += 85;
                }
                System.Threading.Thread.Sleep(500);
                p7.Location = new Point(lokasyonXp7, lokasyonYp7);
            }
            if (p7.Location.X == 1370 && p7.Location.Y == 50)    //KODES
            {
                p7.Location = new Point(520, 900);
                lokasyonXp7 = 520; lokasyonYp7 = 900;
            }
        }
        private void p8b_Click(object sender, EventArgs e)
        {

            for (int q = 0; q < tut; q++)
            {
                if (lokasyonXp8 > 550 && lokasyonYp8 == 900)   //Sola
                {
                    lokasyonXp8 -= 85;
                }
                else if (lokasyonXp8 == 520 && lokasyonYp8 > 50)     //Yukar�
                {
                    lokasyonYp8 -= 85;
                }
                else if (lokasyonXp8 < 1360 && lokasyonXp8 >= 520 && lokasyonYp8 == 50)   //Sa�a
                {
                    lokasyonXp8 += 85;
                }
                else if (lokasyonXp8 == 1370 && lokasyonYp8 >= 50)   //A�a��
                {
                    lokasyonYp8 += 85;
                }
                System.Threading.Thread.Sleep(500);
                p8.Location = new Point(lokasyonXp8, lokasyonYp8);
            }
            if (p8.Location.X == 1370 && p8.Location.Y == 50)    //KODES
            {
                p8.Location = new Point(520, 900);
                lokasyonXp8 = 520; lokasyonYp8 = 900;
            }
        }
        //Trasfer
        private void button11_Click(object sender, EventArgs e)
        {
            if (cboxIstenen.SelectedItem.ToString() == "Banka")
            {
                if (Banka.Items.IndexOf(cboxTapular.SelectedItem.ToString()) == -1)
                {
                    MessageBox.Show("Tapu, �stenen Ki�ide Yok.");
                }
                else
                {
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[0])
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[1])
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[2])
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[3])
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[4])
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[5])
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[6])
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[7])
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString()); ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Remove(cboxTapular.SelectedItem.ToString());
                            Banka.Items.Remove(cboxTapular.SelectedItem.ToString());
                            ipotek.Items.Remove(cboxTapular.SelectedItem.ToString());
                        }
                    }
                }
            }
            if (cboxIstenen.SelectedItem.ToString() == oyuncular[0])
            {
                if (oyuncubox1.Items.IndexOf(cboxTapular.SelectedItem.ToString()) == -1)
                {
                    MessageBox.Show("Tapu, �stenen Ki�ide Yok.");
                }
                else
                {
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[1])
                    {
                        oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox1.Items.Remove(cboxTapular.SelectedItem.ToString());

                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[2])
                    {
                        oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox1.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[3])
                    {
                        oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox1.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[4])
                    {
                        oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox1.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[5])
                    {
                        oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox1.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[6])
                    {
                        oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox1.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[7])
                    {
                        oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox1.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == "Banka")
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        oyuncubox1.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                }
            }
            if (cboxIstenen.SelectedItem.ToString() == oyuncular[1])
            {
                if (oyuncubox2.Items.IndexOf(cboxTapular.SelectedItem.ToString()) == -1)
                {
                    MessageBox.Show("Tapu, �stenen Ki�ide Yok.");
                }
                else
                {
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[0])
                    {
                        oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[1])
                    {
                        oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[2])
                    {
                        oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[3])
                    {
                        oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[4])
                    {
                        oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[5])
                    {
                        oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[6])
                    {
                        oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[7])
                    {
                        oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == "Banka")
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                }
            }
            if (cboxIstenen.SelectedItem.ToString() == oyuncular[2])
            {
                if (oyuncubox3.Items.IndexOf(cboxTapular.SelectedItem.ToString()) == -1)
                {
                    MessageBox.Show("Tapu, �stenen Ki�ide Yok.");
                }
                else
                {
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[0])
                    {
                        oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[1])
                    {
                        oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[3])
                    {
                        oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[4])
                    {
                        oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[5])
                    {
                        oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[6])
                    {
                        oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[7])
                    {
                        oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == "Banka")
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                }

            }
            if (cboxIstenen.SelectedItem.ToString() == oyuncular[3])
            {
                if (oyuncubox3.Items.IndexOf(cboxTapular.SelectedItem.ToString()) == -1)
                {
                    MessageBox.Show("Tapu, �stenen Ki�ide Yok.");
                }
                else
                {
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[0])
                    {
                        oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[1])
                    {
                        oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[2])
                    {
                        oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[3])
                    {
                        oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[4])
                    {
                        oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[5])
                    {
                        oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[6])
                    {
                        oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[7])
                    {
                        oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == "Banka")
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                }

            }
            if (cboxIstenen.SelectedItem.ToString() == oyuncular[4])
            {
                if (oyuncubox4.Items.IndexOf(cboxTapular.SelectedItem.ToString()) == -1)
                {
                    MessageBox.Show("Tapu, �stenen Ki�ide Yok.");
                }
                else
                {
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[0])
                    {
                        oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox4.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[1])
                    {
                        oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox4.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[2])
                    {
                        oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox4.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[4])
                    {
                        oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox4.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[5])
                    {
                        oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox4.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[6])
                    {
                        oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox4.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[7])
                    {
                        oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox4.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == "Banka")
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        oyuncubox4.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                }
            }
            if (cboxIstenen.SelectedItem.ToString() == oyuncular[5])
            {
                if (oyuncubox5.Items.IndexOf(cboxTapular.SelectedItem.ToString()) == -1)
                {
                    MessageBox.Show("Tapu, �stenen Ki�ide Yok.");
                }
                else
                {
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[0])
                    {
                        oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox5.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[1])
                    {
                        oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox5.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[2])
                    {
                        oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox5.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[3])
                    {
                        oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox5.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[5])
                    {
                        oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox5.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[6])
                    {
                        oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox5.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[7])
                    {
                        oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox5.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == "Banka")
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        oyuncubox5.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                }

            }
            if (cboxIstenen.SelectedItem.ToString() == oyuncular[6])
            {
                if (oyuncubox6.Items.IndexOf(cboxTapular.SelectedItem.ToString()) == -1)
                {
                    MessageBox.Show("Tapu, �stenen Ki�ide Yok.");
                }
                else
                {
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[0])
                    {
                        oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox6.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[1])
                    {
                        oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox6.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[2])
                    {
                        oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox6.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[3])
                    {
                        oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox6.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[4])
                    {
                        oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox6.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[6])
                    {
                        oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox6.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[7])
                    {
                        oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox6.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == "Banka")
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        oyuncubox6.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                }

            }
            if (cboxIstenen.SelectedItem.ToString() == oyuncular[7])
            {
                if (oyuncubox3.Items.IndexOf(cboxTapular.SelectedItem.ToString()) == -1)
                {
                    MessageBox.Show("Tapu, �stenen Ki�ide Yok.");
                }
                else
                {
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[0])
                    {
                        oyuncubox1.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[1])
                    {
                        oyuncubox2.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[2])
                    {
                        oyuncubox3.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox2.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[3])
                    {
                        oyuncubox4.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[4])
                    {
                        oyuncubox5.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[5])
                    {
                        oyuncubox6.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[6])
                    {
                        oyuncubox7.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == oyuncular[7])
                    {
                        oyuncubox8.Items.Add(cboxTapular.SelectedItem.ToString());
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }
                    if (cboxIsteyen.SelectedItem.ToString() == "Banka")
                    {
                        if (cboxTapular.SelectedItem.ToString() == "Ba�c�lar" || cboxTapular.SelectedItem.ToString() == "Esenler")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxKahverengi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Tuzla" || cboxTapular.SelectedItem.ToString() == "Pendik" || cboxTapular.SelectedItem.ToString() == "Kartal")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxAMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Beyo�lu" || cboxTapular.SelectedItem.ToString() == "Ka��thane" || cboxTapular.SelectedItem.ToString() == "�i�li")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMor.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Ba�ak�ehir" || cboxTapular.SelectedItem.ToString() == "Zeytinburnu" || cboxTapular.SelectedItem.ToString() == "B�y�k�ekmece")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxTuruncu.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Kad�k�y" || cboxTapular.SelectedItem.ToString() == "Sar�yer" || cboxTapular.SelectedItem.ToString() == "Sancaktepe")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxK�rm�z�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Be�ikta�" || cboxTapular.SelectedItem.ToString() == "Ata�ehir" || cboxTapular.SelectedItem.ToString() == "�sk�dar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxSar�.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Fatih" || cboxTapular.SelectedItem.ToString() == "Silivri" || cboxTapular.SelectedItem.ToString() == "Adalar")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxYesil.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Etiler" || cboxTapular.SelectedItem.ToString() == "Ni�anta��")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxMavi.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Sirkeci Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "Halkal� Tren �stasyonu" || cboxTapular.SelectedItem.ToString() == "�stanbul Liman�" || cboxTapular.SelectedItem.ToString() == "Ambarl� Liman�")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIstasyon.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        if (cboxTapular.SelectedItem.ToString() == "Su ��leri" || cboxTapular.SelectedItem.ToString() == "Elektrik ��leri")
                        {
                            ipotek.Items.Add(cboxTapular.SelectedItem.ToString()); Banka.Items.Add(cboxTapular.SelectedItem.ToString());
                            cboxIsDaireleri.Items.Add(cboxTapular.SelectedItem.ToString());
                        }
                        oyuncubox3.Items.Remove(cboxTapular.SelectedItem.ToString());
                    }

                }
            }
        }
        // Tapu Bilgi
        private void button11_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa1);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa2);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa3);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa4);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa5);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa6);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa7);
        }
        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa8);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa9);
        }
        private void button28_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa10);
        }
        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa11);
        }
        private void button29_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa12);
        }
        private void button31_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa13);
        }
        private void button33_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa14);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa15);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa16);
        }
        private void button36_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa17);
        }
        private void button38_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa18);
        }
        private void button39_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa19);
        }
        private void button40_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa20);
        }
        private void button45_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa21);
        }
        private void button46_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Arsa22);
        }
        //Sat�n Al�m  Y�k�m
        private void SatinAlYik_Click(object sender, EventArgs e)
        {
            if (Arsa.SelectedItem.ToString() == "Ba�c�lar")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home1 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home1 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev1.Text = home1.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel1 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel1.Text = otel1.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home1 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home1 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev1.Text = home1.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel1 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel1 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel1.Text = otel1.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Esenler")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home2 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home2 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev2.Text = home2.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel2 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel2.Text = otel2.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home2 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home2 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev2.Text = home2.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel2 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel2 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel2.Text = otel2.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Tuzla")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home3 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home3 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev3.Text = home3.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel3 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel3.Text = otel3.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home3 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home3 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev3.Text = home3.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel3 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel3 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel3.Text = otel3.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Pendik")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home4 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home4 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev4.Text = home4.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel4 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel4.Text = otel4.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home4 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home4 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev4.Text = home4.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel4 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel4 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel4.Text = otel4.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Kartal")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home5 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home5 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev5.Text = home5.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel5 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel5.Text = otel5.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home5 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home5 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev5.Text = home5.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel5 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel5 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel5.Text = otel5.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Beyo�lu")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home6 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home6 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev6.Text = home6.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel6 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel6.Text = otel6.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home6 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home6 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev6.Text = home6.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel6 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel6 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel6.Text = otel6.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Ka��thane")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home7 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home7 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev7.Text = home7.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel7 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel7.Text = otel7.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home7 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home7 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev7.Text = home7.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel7 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel7 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel7.Text = otel7.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "�i�li")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home8 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home8 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev8.Text = home8.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel8 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel8.Text = otel8.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home8 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home8 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev8.Text = home8.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel8 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel8 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel8.Text = otel8.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Ba�ak�ehir")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home9 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home9 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev9.Text = home9.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel9 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel9.Text = otel9.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home9 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home9 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev9.Text = home9.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel9 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel9 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel9.Text = otel9.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Zeytinburnu")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home10 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home10 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev10.Text = home10.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel10 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel10.Text = otel10.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home10 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home10 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev10.Text = home10.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel10 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel10 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel10.Text = otel10.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "B�y�k�ekmece")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home11 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home11 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev11.Text = home11.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel11 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel11.Text = otel11.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home11 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home11 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev11.Text = home11.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel11 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel11 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel11.Text = otel11.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Kad�k�y")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home12 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home12 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev12.Text = home12.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel12 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel12.Text = otel12.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home12 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home12 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev12.Text = home12.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel12 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel12 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel12.Text = otel12.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Sar�yer")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home13 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home13 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev13.Text = home13.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel13 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel13.Text = otel13.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home13 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home13 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev13.Text = home13.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel13 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel13 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel13.Text = otel13.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Sancaktepe")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home14 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home14 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev14.Text = home14.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel14 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel14.Text = otel14.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home14 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home14 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev14.Text = home14.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel14 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel14 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel14.Text = otel14.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Be�ikta�")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home15 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home15 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev15.Text = home15.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel15 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel15.Text = otel15.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home15 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home15 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev15.Text = home15.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel15 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel15 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel15.Text = otel15.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Ata�ehir")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home16 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home16 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev16.Text = home16.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel16 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel16.Text = otel16.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home16 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home16 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev16.Text = home16.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel16 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel16 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel16.Text = otel16.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "�sk�dar")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home17 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home17 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev17.Text = home17.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel17 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel17.Text = otel17.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home17 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home17 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev17.Text = home17.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel17 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel17 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel17.Text = otel17.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Fatih")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home18 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home18 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev18.Text = home18.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel18 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel18.Text = otel18.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home18 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home18 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev18.Text = home18.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel18 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel18 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel18.Text = otel18.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Silivri")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home19 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home19 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev19.Text = home19.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel19 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel19.Text = otel19.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home19 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home19 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev19.Text = home19.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel19 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel19 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel19.Text = otel19.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Adalar")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home20 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home20 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev20.Text = home20.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel20 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel20.Text = otel20.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home20 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home20 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev20.Text = home20.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel20 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel20 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel20.Text = otel20.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Etiler")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home21 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home21 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev21.Text = home21.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel21 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel21.Text = otel21.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home21 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home21 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev21.Text = home21.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel21 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel21 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel21.Text = otel21.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
            if (Arsa.SelectedItem.ToString() == "Ni�anta��")
            {
                if (Secim.SelectedItem.ToString() == "Sat�n Al")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (4 >= home22 + Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home22 += Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev22.Text = home22.ToString();
                        }
                        else
                        {
                            MessageBox.Show("En fazla 4 ev dikebilirsin!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        otel22 += Convert.ToInt32(Adet.SelectedItem.ToString());
                        otelLabel22.Text = otel22.ToString();
                    }
                }
                if (Secim.SelectedItem.ToString() == "Y�k")
                {
                    if (Bina.SelectedItem.ToString() == "Ev")
                    {
                        if (0 <= home22 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            home22 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            ev22.Text = home22.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar evin yok!");
                        }
                    }
                    if (Bina.SelectedItem.ToString() == "Otel")
                    {
                        if (0 <= otel22 - Convert.ToInt32(Adet.SelectedItem.ToString()))
                        {
                            otel22 -= Convert.ToInt32(Adet.SelectedItem.ToString());
                            otelLabel22.Text = otel22.ToString();
                        }
                        else
                        {
                            MessageBox.Show("O kadar otelin yok!");
                        }
                    }
                }
            }
        }
        //I��nla Fonksoynu
        void Is�nla(string a, string b)
        {
            if (a == "Turuncu")
            {
                if (b == "Ba�lang��")
                {
                    lokasyonXp1 = 1370;
                    lokasyonYp1 = 900;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Kodes" || b == "KODES")
                {
                    lokasyonXp1 = 520;
                    lokasyonYp1 = 900;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Ba�c�lar")
                {
                    lokasyonXp1 = 1285;
                    lokasyonYp1 = 900;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Esenler")
                {
                    lokasyonXp1 = 1115;
                    lokasyonYp1 = 900;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Tuzla")
                {
                    lokasyonXp1 = 860;
                    lokasyonYp1 = 900;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Pendik")
                {
                    lokasyonXp1 = 690;
                    lokasyonYp1 = 900;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Kartal")
                {
                    lokasyonXp1 = 605;
                    lokasyonYp1 = 900;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Beyo�lu")
                {
                    lokasyonXp1 = 520;
                    lokasyonYp1 = 815;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Ka��thane")
                {
                    lokasyonXp1 = 520;
                    lokasyonYp1 = 645;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "�i�li")
                {
                    lokasyonXp1 = 520;
                    lokasyonYp1 = 560;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Ba�ak�ehir")
                {
                    lokasyonXp1 = 520;
                    lokasyonYp1 = 390;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Zeytinburnu")
                {
                    lokasyonXp1 = 520;
                    lokasyonYp1 = 220;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "B�y�k�ekmece")
                {
                    lokasyonXp1 = 520;
                    lokasyonYp1 = 135;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Kad�k�y")
                {
                    lokasyonXp1 = 605;
                    lokasyonYp1 = 50;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Sar�yer")
                {
                    lokasyonXp1 = 775;
                    lokasyonYp1 = 50;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Sancaktepe")
                {
                    lokasyonXp1 = 860;
                    lokasyonYp1 = 50;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Be�ikta�")
                {
                    lokasyonXp1 = 1030;
                    lokasyonYp1 = 50;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Ata�ehir")
                {
                    lokasyonXp1 = 1115;
                    lokasyonYp1 = 50;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "�sk�dar")
                {
                    lokasyonXp1 = 1285;
                    lokasyonYp1 = 50;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Fatih")
                {
                    lokasyonXp1 = 1370;
                    lokasyonYp1 = 135;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Silivri")
                {
                    lokasyonXp1 = 1370;
                    lokasyonYp1 = 220;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Adalar")
                {
                    lokasyonXp1 = 1370;
                    lokasyonYp1 = 390;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Etiler")
                {
                    lokasyonXp1 = 1370;
                    lokasyonYp1 = 645;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Ni�anta��")
                {
                    lokasyonXp1 = 1370;
                    lokasyonYp1 = 815;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "�stanbul Liman�")
                {
                    lokasyonXp1 = 945;
                    lokasyonYp1 = 50;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Ambarl� Liman�")
                {
                    lokasyonXp1 = 945;
                    lokasyonYp1 = 900;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Halkal� Tren �stasyonu")
                {
                    lokasyonXp1 = 1370;
                    lokasyonYp1 = 475;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
                if (b == "Sirkeci Tren �stasyonu")
                {
                    lokasyonXp1 = 520;
                    lokasyonYp1 = 475;
                    p1.Location = new Point(lokasyonXp1, lokasyonYp1);
                }
            }
            if (a == "Pembe")
            {
                if (b == "Ba�lang��")
                {
                    lokasyonXp2 = 1370;
                    lokasyonYp2 = 900;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Kodes" || b == "KODES")
                {
                    lokasyonXp2 = 520;
                    lokasyonYp2 = 900;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Ba�c�lar")
                {
                    lokasyonXp2 = 1285;
                    lokasyonYp2 = 900;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Esenler")
                {
                    lokasyonXp2 = 1115;
                    lokasyonYp2 = 900;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Tuzla")
                {
                    lokasyonXp2 = 860;
                    lokasyonYp2 = 900;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Pendik")
                {
                    lokasyonXp2 = 690;
                    lokasyonYp2 = 900;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Kartal")
                {
                    lokasyonXp2 = 605;
                    lokasyonYp2 = 900;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Beyo�lu")
                {
                    lokasyonXp2 = 520;
                    lokasyonYp2 = 815;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Ka��thane")
                {
                    lokasyonXp2 = 520;
                    lokasyonYp2 = 645;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "�i�li")
                {
                    lokasyonXp2 = 520;
                    lokasyonYp2 = 560;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Ba�ak�ehir")
                {
                    lokasyonXp2 = 520;
                    lokasyonYp2 = 390;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Zeytinburnu")
                {
                    lokasyonXp2 = 520;
                    lokasyonYp2 = 220;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "B�y�k�ekmece")
                {
                    lokasyonXp2 = 520;
                    lokasyonYp2 = 135;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Kad�k�y")
                {
                    lokasyonXp2 = 605;
                    lokasyonYp2 = 50;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Sar�yer")
                {
                    lokasyonXp2 = 775;
                    lokasyonYp2 = 50;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Sancaktepe")
                {
                    lokasyonXp2 = 860;
                    lokasyonYp2 = 50;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Be�ikta�")
                {
                    lokasyonXp2 = 1030;
                    lokasyonYp2 = 50;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Ata�ehir")
                {
                    lokasyonXp2 = 1115;
                    lokasyonYp2 = 50;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "�sk�dar")
                {
                    lokasyonXp2 = 1285;
                    lokasyonYp2 = 50;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Fatih")
                {
                    lokasyonXp2 = 1370;
                    lokasyonYp2 = 135;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Silivri")
                {
                    lokasyonXp2 = 1370;
                    lokasyonYp2 = 220;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Adalar")
                {
                    lokasyonXp2 = 1370;
                    lokasyonYp2 = 390;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Etiler")
                {
                    lokasyonXp2 = 1370;
                    lokasyonYp2 = 645;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Ni�anta��")
                {
                    lokasyonXp2 = 1370;
                    lokasyonYp2 = 815;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "�stanbul Liman�")
                {
                    lokasyonXp2 = 945;
                    lokasyonYp2 = 50;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Ambarl� Liman�")
                {
                    lokasyonXp2 = 945;
                    lokasyonYp2 = 900;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Halkal� Tren �stasyonu")
                {
                    lokasyonXp2 = 1370;
                    lokasyonYp2 = 475;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
                if (b == "Sirkeci Tren �stasyonu")
                {
                    lokasyonXp2 = 520;
                    lokasyonYp2 = 475;
                    p2.Location = new Point(lokasyonXp2, lokasyonYp2);
                }
            }
            if (a == "Mor")
            {
                if (b == "Ba�lang��")
                {
                    lokasyonXp3 = 1370;
                    lokasyonYp3 = 900;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Kodes" || b == "KODES")
                {
                    lokasyonXp3 = 520;
                    lokasyonYp3 = 900;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Ba�c�lar")
                {
                    lokasyonXp3 = 1285;
                    lokasyonYp3 = 900;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Esenler")
                {
                    lokasyonXp3 = 1115;
                    lokasyonYp3 = 900;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Tuzla")
                {
                    lokasyonXp3 = 860;
                    lokasyonYp3 = 900;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Pendik")
                {
                    lokasyonXp3 = 690;
                    lokasyonYp3 = 900;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Kartal")
                {
                    lokasyonXp3 = 605;
                    lokasyonYp3 = 900;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Beyo�lu")
                {
                    lokasyonXp3 = 520;
                    lokasyonYp3 = 815;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Ka��thane")
                {
                    lokasyonXp3 = 520;
                    lokasyonYp3 = 645;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "�i�li")
                {
                    lokasyonXp3 = 520;
                    lokasyonYp3 = 560;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Ba�ak�ehir")
                {
                    lokasyonXp3 = 520;
                    lokasyonYp3 = 390;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Zeytinburnu")
                {
                    lokasyonXp3 = 520;
                    lokasyonYp3 = 220;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "B�y�k�ekmece")
                {
                    lokasyonXp3 = 520;
                    lokasyonYp3 = 135;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Kad�k�y")
                {
                    lokasyonXp3 = 605;
                    lokasyonYp3 = 50;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Sar�yer")
                {
                    lokasyonXp3 = 775;
                    lokasyonYp3 = 50;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Sancaktepe")
                {
                    lokasyonXp3 = 860;
                    lokasyonYp3 = 50;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Be�ikta�")
                {
                    lokasyonXp3 = 1030;
                    lokasyonYp3 = 50;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Ata�ehir")
                {
                    lokasyonXp3 = 1115;
                    lokasyonYp3 = 50;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "�sk�dar")
                {
                    lokasyonXp3 = 1285;
                    lokasyonYp3 = 50;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Fatih")
                {
                    lokasyonXp3 = 1370;
                    lokasyonYp3 = 135;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Silivri")
                {
                    lokasyonXp3 = 1370;
                    lokasyonYp3 = 220;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Adalar")
                {
                    lokasyonXp3 = 1370;
                    lokasyonYp3 = 390;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Etiler")
                {
                    lokasyonXp3 = 1370;
                    lokasyonYp3 = 645;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Ni�anta��")
                {
                    lokasyonXp3 = 1370;
                    lokasyonYp3 = 815;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "�stanbul Liman�")
                {
                    lokasyonXp3 = 945;
                    lokasyonYp3 = 50;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Ambarl� Liman�")
                {
                    lokasyonXp3 = 945;
                    lokasyonYp3 = 900;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Halkal� Tren �stasyonu")
                {
                    lokasyonXp3 = 1370;
                    lokasyonYp3 = 475;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
                if (b == "Sirkeci Tren �stasyonu")
                {
                    lokasyonXp3 = 520;
                    lokasyonYp3 = 475;
                    p3.Location = new Point(lokasyonXp3, lokasyonYp3);
                }
            }
            if (a == "Sar�")
            {
                if (b == "Ba�lang��")
                {
                    lokasyonXp4 = 1370;
                    lokasyonYp4 = 900;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Kodes" || b == "KODES")
                {
                    lokasyonXp4 = 520;
                    lokasyonYp4 = 900;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Ba�c�lar")
                {
                    lokasyonXp4 = 1285;
                    lokasyonYp4 = 900;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Esenler")
                {
                    lokasyonXp4 = 1115;
                    lokasyonYp4 = 900;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Tuzla")
                {
                    lokasyonXp4 = 860;
                    lokasyonYp4 = 900;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Pendik")
                {
                    lokasyonXp4 = 690;
                    lokasyonYp4 = 900;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Kartal")
                {
                    lokasyonXp4 = 605;
                    lokasyonYp4 = 900;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Beyo�lu")
                {
                    lokasyonXp4 = 520;
                    lokasyonYp4 = 815;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Ka��thane")
                {
                    lokasyonXp4 = 520;
                    lokasyonYp4 = 645;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "�i�li")
                {
                    lokasyonXp4 = 520;
                    lokasyonYp4 = 560;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Ba�ak�ehir")
                {
                    lokasyonXp4 = 520;
                    lokasyonYp4 = 390;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Zeytinburnu")
                {
                    lokasyonXp4 = 520;
                    lokasyonYp4 = 220;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "B�y�k�ekmece")
                {
                    lokasyonXp4 = 520;
                    lokasyonYp4 = 135;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Kad�k�y")
                {
                    lokasyonXp4 = 605;
                    lokasyonYp4 = 50;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Sar�yer")
                {
                    lokasyonXp4 = 775;
                    lokasyonYp4 = 50;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Sancaktepe")
                {
                    lokasyonXp4 = 860;
                    lokasyonYp4 = 50;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Be�ikta�")
                {
                    lokasyonXp4 = 1030;
                    lokasyonYp4 = 50;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Ata�ehir")
                {
                    lokasyonXp4 = 1115;
                    lokasyonYp4 = 50;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "�sk�dar")
                {
                    lokasyonXp4 = 1285;
                    lokasyonYp4 = 50;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Fatih")
                {
                    lokasyonXp4 = 1370;
                    lokasyonYp4 = 135;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Silivri")
                {
                    lokasyonXp4 = 1370;
                    lokasyonYp4 = 220;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Adalar")
                {
                    lokasyonXp4 = 1370;
                    lokasyonYp4 = 390;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Etiler")
                {
                    lokasyonXp4 = 1370;
                    lokasyonYp4 = 645;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Ni�anta��")
                {
                    lokasyonXp4 = 1370;
                    lokasyonYp4 = 815;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "�stanbul Liman�")
                {
                    lokasyonXp4 = 945;
                    lokasyonYp4 = 50;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Ambarl� Liman�")
                {
                    lokasyonXp4 = 945;
                    lokasyonYp4 = 900;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Halkal� Tren �stasyonu")
                {
                    lokasyonXp4 = 1370;
                    lokasyonYp4 = 475;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
                if (b == "Sirkeci Tren �stasyonu")
                {
                    lokasyonXp4 = 520;
                    lokasyonYp4 = 475;
                    p4.Location = new Point(lokasyonXp4, lokasyonYp4);
                }
            }
            if (a == "Ye�il")
            {
                if (b == "Ba�lang��")
                {
                    lokasyonXp5 = 1370;
                    lokasyonYp5 = 900;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Kodes" || b == "KODES")
                {
                    lokasyonXp5 = 520;
                    lokasyonYp5 = 900;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Ba�c�lar")
                {
                    lokasyonXp5 = 1285;
                    lokasyonYp5 = 900;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Esenler")
                {
                    lokasyonXp5 = 1115;
                    lokasyonYp5 = 900;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Tuzla")
                {
                    lokasyonXp5 = 860;
                    lokasyonYp5 = 900;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Pendik")
                {
                    lokasyonXp5 = 690;
                    lokasyonYp5 = 900;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Kartal")
                {
                    lokasyonXp5 = 605;
                    lokasyonYp5 = 900;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Beyo�lu")
                {
                    lokasyonXp5 = 520;
                    lokasyonYp5 = 815;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Ka��thane")
                {
                    lokasyonXp5 = 520;
                    lokasyonYp5 = 645;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "�i�li")
                {
                    lokasyonXp5 = 520;
                    lokasyonYp5 = 560;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Ba�ak�ehir")
                {
                    lokasyonXp5 = 520;
                    lokasyonYp5 = 390;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Zeytinburnu")
                {
                    lokasyonXp5 = 520;
                    lokasyonYp5 = 220;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "B�y�k�ekmece")
                {
                    lokasyonXp5 = 520;
                    lokasyonYp5 = 135;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Kad�k�y")
                {
                    lokasyonXp5 = 605;
                    lokasyonYp5 = 50;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Sar�yer")
                {
                    lokasyonXp5 = 775;
                    lokasyonYp5 = 50;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Sancaktepe")
                {
                    lokasyonXp5 = 860;
                    lokasyonYp5 = 50;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Be�ikta�")
                {
                    lokasyonXp5 = 1030;
                    lokasyonYp5 = 50;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Ata�ehir")
                {
                    lokasyonXp5 = 1115;
                    lokasyonYp5 = 50;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "�sk�dar")
                {
                    lokasyonXp5 = 1285;
                    lokasyonYp5 = 50;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Fatih")
                {
                    lokasyonXp5 = 1370;
                    lokasyonYp5 = 135;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Silivri")
                {
                    lokasyonXp5 = 1370;
                    lokasyonYp5 = 220;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Adalar")
                {
                    lokasyonXp5 = 1370;
                    lokasyonYp5 = 390;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Etiler")
                {
                    lokasyonXp5 = 1370;
                    lokasyonYp5 = 645;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Ni�anta��")
                {
                    lokasyonXp5 = 1370;
                    lokasyonYp5 = 815;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "�stanbul Liman�")
                {
                    lokasyonXp5 = 945;
                    lokasyonYp5 = 50;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Ambarl� Liman�")
                {
                    lokasyonXp5 = 945;
                    lokasyonYp5 = 900;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Halkal� Tren �stasyonu")
                {
                    lokasyonXp5 = 1370;
                    lokasyonYp5 = 475;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
                if (b == "Sirkeci Tren �stasyonu")
                {
                    lokasyonXp5 = 520;
                    lokasyonYp5 = 475;
                    p5.Location = new Point(lokasyonXp5, lokasyonYp5);
                }
            }
            if (a == "Mavi")
            {
                if (b == "Ba�lang��")
                {
                    lokasyonXp6 = 1370;
                    lokasyonYp6 = 900;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Kodes" || b == "KODES")
                {
                    lokasyonXp6 = 520;
                    lokasyonYp6 = 900;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Ba�c�lar")
                {
                    lokasyonXp6 = 1285;
                    lokasyonYp6 = 900;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Esenler")
                {
                    lokasyonXp6 = 1115;
                    lokasyonYp6 = 900;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Tuzla")
                {
                    lokasyonXp6 = 860;
                    lokasyonYp6 = 900;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Pendik")
                {
                    lokasyonXp6 = 690;
                    lokasyonYp6 = 900;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Kartal")
                {
                    lokasyonXp6 = 605;
                    lokasyonYp6 = 900;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Beyo�lu")
                {
                    lokasyonXp6 = 520;
                    lokasyonYp6 = 815;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Ka��thane")
                {
                    lokasyonXp6 = 520;
                    lokasyonYp6 = 645;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "�i�li")
                {
                    lokasyonXp6 = 520;
                    lokasyonYp6 = 560;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Ba�ak�ehir")
                {
                    lokasyonXp6 = 520;
                    lokasyonYp6 = 390;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Zeytinburnu")
                {
                    lokasyonXp6 = 520;
                    lokasyonYp6 = 220;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "B�y�k�ekmece")
                {
                    lokasyonXp6 = 520;
                    lokasyonYp6 = 135;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Kad�k�y")
                {
                    lokasyonXp6 = 605;
                    lokasyonYp6 = 50;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Sar�yer")
                {
                    lokasyonXp6 = 775;
                    lokasyonYp6 = 50;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Sancaktepe")
                {
                    lokasyonXp6 = 860;
                    lokasyonYp6 = 50;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Be�ikta�")
                {
                    lokasyonXp6 = 1030;
                    lokasyonYp6 = 50;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Ata�ehir")
                {
                    lokasyonXp6 = 1115;
                    lokasyonYp6 = 50;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "�sk�dar")
                {
                    lokasyonXp6 = 1285;
                    lokasyonYp6 = 50;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Fatih")
                {
                    lokasyonXp6 = 1370;
                    lokasyonYp6 = 135;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Silivri")
                {
                    lokasyonXp6 = 1370;
                    lokasyonYp6 = 220;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Adalar")
                {
                    lokasyonXp6 = 1370;
                    lokasyonYp6 = 390;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Etiler")
                {
                    lokasyonXp6 = 1370;
                    lokasyonYp6 = 645;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Ni�anta��")
                {
                    lokasyonXp6 = 1370;
                    lokasyonYp6 = 815;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "�stanbul Liman�")
                {
                    lokasyonXp6 = 945;
                    lokasyonYp6 = 50;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Ambarl� Liman�")
                {
                    lokasyonXp6 = 945;
                    lokasyonYp6 = 900;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Halkal� Tren �stasyonu")
                {
                    lokasyonXp6 = 1370;
                    lokasyonYp6 = 475;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
                if (b == "Sirkeci Tren �stasyonu")
                {
                    lokasyonXp6 = 520;
                    lokasyonYp6 = 475;
                    p6.Location = new Point(lokasyonXp6, lokasyonYp6);
                }
            }
            if (a == "K�rm�z�")
            {
                if (b == "Ba�lang��")
                {
                    lokasyonXp7 = 1370;
                    lokasyonYp7 = 900;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Kodes" || b == "KODES")
                {
                    lokasyonXp7 = 520;
                    lokasyonYp7 = 900;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Ba�c�lar")
                {
                    lokasyonXp7 = 1285;
                    lokasyonYp7 = 900;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Esenler")
                {
                    lokasyonXp7 = 1115;
                    lokasyonYp7 = 900;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Tuzla")
                {
                    lokasyonXp7 = 860;
                    lokasyonYp7 = 900;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Pendik")
                {
                    lokasyonXp7 = 690;
                    lokasyonYp7 = 900;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Kartal")
                {
                    lokasyonXp7 = 605;
                    lokasyonYp7 = 900;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Beyo�lu")
                {
                    lokasyonXp7 = 520;
                    lokasyonYp7 = 815;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Ka��thane")
                {
                    lokasyonXp7 = 520;
                    lokasyonYp7 = 645;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "�i�li")
                {
                    lokasyonXp7 = 520;
                    lokasyonYp7 = 560;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Ba�ak�ehir")
                {
                    lokasyonXp7 = 520;
                    lokasyonYp7 = 390;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Zeytinburnu")
                {
                    lokasyonXp7 = 520;
                    lokasyonYp7 = 220;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "B�y�k�ekmece")
                {
                    lokasyonXp7 = 520;
                    lokasyonYp7 = 135;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Kad�k�y")
                {
                    lokasyonXp7 = 605;
                    lokasyonYp7 = 50;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Sar�yer")
                {
                    lokasyonXp7 = 775;
                    lokasyonYp7 = 50;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Sancaktepe")
                {
                    lokasyonXp7 = 860;
                    lokasyonYp7 = 50;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Be�ikta�")
                {
                    lokasyonXp7 = 1030;
                    lokasyonYp7 = 50;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Ata�ehir")
                {
                    lokasyonXp7 = 1115;
                    lokasyonYp7 = 50;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "�sk�dar")
                {
                    lokasyonXp7 = 1285;
                    lokasyonYp7 = 50;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Fatih")
                {
                    lokasyonXp7 = 1370;
                    lokasyonYp7 = 135;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Silivri")
                {
                    lokasyonXp7 = 1370;
                    lokasyonYp7 = 220;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Adalar")
                {
                    lokasyonXp7 = 1370;
                    lokasyonYp7 = 390;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Etiler")
                {
                    lokasyonXp7 = 1370;
                    lokasyonYp7 = 645;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Ni�anta��")
                {
                    lokasyonXp7 = 1370;
                    lokasyonYp7 = 815;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "�stanbul Liman�")
                {
                    lokasyonXp7 = 945;
                    lokasyonYp7 = 50;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Ambarl� Liman�")
                {
                    lokasyonXp7 = 945;
                    lokasyonYp7 = 900;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Halkal� Tren �stasyonu")
                {
                    lokasyonXp7 = 1370;
                    lokasyonYp7 = 475;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
                if (b == "Sirkeci Tren �stasyonu")
                {
                    lokasyonXp7 = 520;
                    lokasyonYp7 = 475;
                    p7.Location = new Point(lokasyonXp7, lokasyonYp7);
                }
            }
            if (a == "Cyan")
            {
                if (b == "Ba�lang��")
                {
                    lokasyonXp8 = 1370;
                    lokasyonYp8 = 900;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Kodes" || b == "KODES")
                {
                    lokasyonXp8 = 520;
                    lokasyonYp8 = 900;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Ba�c�lar")
                {
                    lokasyonXp8 = 1285;
                    lokasyonYp8 = 900;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Esenler")
                {
                    lokasyonXp8 = 1115;
                    lokasyonYp8 = 900;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Tuzla")
                {
                    lokasyonXp8 = 860;
                    lokasyonYp8 = 900;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Pendik")
                {
                    lokasyonXp8 = 690;
                    lokasyonYp8 = 900;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Kartal")
                {
                    lokasyonXp8 = 605;
                    lokasyonYp8 = 900;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Beyo�lu")
                {
                    lokasyonXp8 = 520;
                    lokasyonYp8 = 815;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Ka��thane")
                {
                    lokasyonXp8 = 520;
                    lokasyonYp8 = 645;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "�i�li")
                {
                    lokasyonXp8 = 520;
                    lokasyonYp8 = 560;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Ba�ak�ehir")
                {
                    lokasyonXp8 = 520;
                    lokasyonYp8 = 390;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Zeytinburnu")
                {
                    lokasyonXp8 = 520;
                    lokasyonYp8 = 220;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "B�y�k�ekmece")
                {
                    lokasyonXp8 = 520;
                    lokasyonYp8 = 135;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Kad�k�y")
                {
                    lokasyonXp8 = 605;
                    lokasyonYp8 = 50;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Sar�yer")
                {
                    lokasyonXp8 = 775;
                    lokasyonYp8 = 50;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Sancaktepe")
                {
                    lokasyonXp8 = 860;
                    lokasyonYp8 = 50;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Be�ikta�")
                {
                    lokasyonXp8 = 1030;
                    lokasyonYp8 = 50;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Ata�ehir")
                {
                    lokasyonXp8 = 1115;
                    lokasyonYp8 = 50;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "�sk�dar")
                {
                    lokasyonXp8 = 1285;
                    lokasyonYp8 = 50;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Fatih")
                {
                    lokasyonXp8 = 1370;
                    lokasyonYp8 = 135;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Silivri")
                {
                    lokasyonXp8 = 1370;
                    lokasyonYp8 = 220;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Adalar")
                {
                    lokasyonXp8 = 1370;
                    lokasyonYp8 = 390;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Etiler")
                {
                    lokasyonXp8 = 1370;
                    lokasyonYp8 = 645;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Ni�anta��")
                {
                    lokasyonXp8 = 1370;
                    lokasyonYp8 = 815;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "�stanbul Liman�")
                {
                    lokasyonXp8 = 945;
                    lokasyonYp8 = 50;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Ambarl� Liman�")
                {
                    lokasyonXp8 = 945;
                    lokasyonYp8 = 900;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Halkal� Tren �stasyonu")
                {
                    lokasyonXp8 = 1370;
                    lokasyonYp8 = 475;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
                if (b == "Sirkeci Tren �stasyonu")
                {
                    lokasyonXp8 = 520;
                    lokasyonYp8 = 475;
                    p8.Location = new Point(lokasyonXp8, lokasyonYp8);
                }
            }
        }
        //I��nla
        private void Is�nlan_Click(object sender, EventArgs e)
        {
            string a = Interaction.InputBox("Kelimelerin Ba� Herflerini B�y�k Yaz�n�z.\nOyuncu Rengi Giriniz : ", "I��nlan");
            string b = Interaction.InputBox("Kelimelerin Ba� Herflerini B�y�k Yaz�n�z.\nI��nlanacak Yeri Giriniz : ", "I��nlan");
            Is�nla(a, b);
        }
    }
}