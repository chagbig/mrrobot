using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net.Security;
using System.IO;
using Pop3Lib;
using System.Text.RegularExpressions;

namespace mrrobot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string Poisk(string begmatch, string endmatch, string S2)
        {
            string p1 = @""+begmatch.Trim() + "(.*)" + endmatch;
            string match = Regex.Match(S2, p1).ToString();
            match = Regex.Match(match, @"(?<="+begmatch+")(.*)(?="+endmatch+")").ToString();


            match = match.ToString().Replace("+", "").Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
            return match;
            //return @"(?<=" + begmatch.Trim() + ")(.*)(?=" + endmatch.Trim() + ")";
        }

        private void btProverka_Click(object sender, EventArgs e)
        {
            TcpClient mail = new TcpClient();
            SslStream sslStream;
            int bytes = -1;
            String S1 = "От:";
            int i1;
            int i2;
            int i3;
            string S3;
            byte[] buffer = new byte[8364000];
            tbRezult.Clear();
            tbConsole.Clear();

            //mail.Connect("192.168.2.200", 995);
            //sslStream = new SslStream(mail.GetStream());

            //sslStream.AuthenticateAsClient("192.168.2.200");

            Pop3Lib.Client myPop3 = new Pop3Lib.Client("192.168.2.200", "prov@apteca1.ru", "123321");


            // Read the stream to make sure we are connected
            //bytes = sslStream.Read(buffer, 0, buffer.Length);
            //MessageBox.Show(Encoding.ASCII.GetString(buffer, 0, bytes));
            //tbConsole.AppendText(Encoding.ASCII.GetString(buffer, 0, bytes));

            //Send the users login details
            //sslStream.Write(Encoding.ASCII.GetBytes("USER chagbig@apteca1.ru\r\n"));
            //bytes = sslStream.Read(buffer, 0, buffer.Length);
            //MessageBox.Show(Encoding.ASCII.GetString(buffer, 0, bytes));
            //tbConsole.AppendText(Encoding.ASCII.GetString(buffer, 0, bytes));

            //Send the password                        
            //sslStream.Write(Encoding.ASCII.GetBytes("PASS cxzcxz75\r\n"));
            //bytes = sslStream.Read(buffer, 0, buffer.Length);
            //MessageBox.Show(Encoding.ASCII.GetString(buffer, 0, bytes));
            //tbConsole.AppendText(Encoding.ASCII.GetString(buffer, 0, bytes));

            // Список писем в ящике
            //sslStream.Write(Encoding.ASCII.GetBytes("STAT\r\n"));
            //bytes = sslStream.Read(buffer, 0, buffer.Length);
            //MessageBox.Show(Encoding.ASCII.GetString(buffer, 0, bytes));
            //S1 = Encoding.ASCII.GetString(buffer, 0, bytes);
            //tbConsole.AppendText(S1);
            //MessageBox.Show(S1);

            //i1 = 4;
            //S1 = S1.Substring(i1);
            //MessageBox.Show(S1);
            //i1 = S1.IndexOf(' ');
            //S1 = S1.Substring(0,i1);
            //tbRezult.AppendText(S1+"\r\n");
            //i4 = Convert.ToInt32(S1);
            //i5 =4;
            //S1 = "";
            //while (i5++ < i4) 
            Pop3Lib.MailItem m;
            while (myPop3.NextMail(out m))
            {
                S3 = "";
                try
                {
                    tbConsole.AppendText("Письмо от " + m.From + " с темой " + m.Subject + " " + m.Data.ToString() + " " + m.Source);
                    S1 = m.Source.ToString();
                    if (S1.IndexOf("noreply@fitts.ru") != -1)
                    {
                        S3 = Poisk(@"Номер телефона:", "Удобное время:", S1);
                        if (S3.Length != 0)
                        {
                            if (tbRezult.ToString().Contains(S3) == false )
                            {
                                tbRezult.AppendText(S3 + "\r\n");
                            }
                        }
                    }
                    S3 = Poisk(@"<p>Телефон:", "</p>", S1);
                    if (S3.Length != 0)
                    {
                        if (tbRezult.ToString().Contains(S3) == false)
                        {
                            tbRezult.AppendText(S3 + "\r\n");
                        }
                    }
                }
                catch
                {
                    tbConsole.AppendText("Произошла неведомая фигня ");
                }

                //string match = Regex.Match(S1, @"<p>Телефон:(.*)</p>").ToString();
                //match = Regex.Match(match, @"(?<=<p>Телефон:)(.*)(?=</p>)").ToString();
                //match = match.ToString().Replace("+", "").Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
                //tbRezult.AppendText(@"(?<=<p>Телефон:)(.*)(?=</p>)" + "\r\n");
                //if (match.Length != 0)
                //{
                    //tbRezult.AppendText(match+"\r\n");
                //}

            }
        }
            private void tbConsole_TextChanged(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = @"bla bla bla blablaa <p>Телефон: +7 922 989 22 44</p> bla bla bla bla";

            string match = Regex.Match(text, @"<p>Телефон:(.*)</p>").ToString();

            match = Regex.Match(match, @"(?<=<p>Телефон:)(.*)(?=</p>)").ToString();

            tbRezult.AppendText(match);
        }
    }
} 
