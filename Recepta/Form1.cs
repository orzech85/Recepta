using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Recepta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("A1.csv");
            this.Text = "Program Recepta, licencja dla: "+LICENCJA;
            String line;
            int id = 0;
            while (!sr.EndOfStream)
            {
                id++;
                line = sr.ReadLine();
                String[] dane = line.Split(';');
                
                Lek lek = new Lek();

                lek.Id = id.ToString();
                lek.Skladnik = dane[0];
                lek.Nazwa = dane[1];
                lek.Refundacja = dane[2];

                Leki.Add(lek);
            }
            lstRefresh("", 0);
            sr.Close();
        }

        List<Lek> Leki = new List<Lek>();
        int focus = 1;
        string lastFiltr = "a";
        string LICENCJA = "Michal Orzechowski (81620), Grzegorz Sasin (59906) \nPrzykladowy Zaklad Opieki Zdrowotnej \nul. Przykladowa 15/1 \n12-345 Przykladowo";

        void lstRefresh(string Text, int Length)
        {
            if (lastFiltr != Text)
            {
                lstSearch.Items.Clear();

                foreach (Lek lek in Leki)
                {
                    int ok = 1;
                    if (Length != 0)
                    {
                        for (int j = 0; j < Length; j++)
                        {
                            if (lek.Nazwa[j].ToString().ToUpper() != Text[j].ToString().ToUpper()) { ok = 0; break; }
                        }
                    }
                    if (ok == 1) lstSearch.Items.Add(lek.Nazwa);
                }

                lastFiltr = Text;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            lstRefresh(txtSearch.Text, txtSearch.Text.Length);

        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstSearch_DoubleClick(object sender, EventArgs e)
        {
            switch (focus)
            {
                case 1: txtLek1.Text = lstSearch.SelectedItem.ToString();
                    txtOp1.Text = "1";
                    cmbOdpl1.Text = "";
                    cmbOdpl1.Items.Clear();
                    foreach (Lek t in Leki)
                    {
                        if (txtLek1.Text == t.Nazwa) cmbOdpl1.Items.Add(t.Refundacja);
                    }
                    focus = 2;
                    break;
                case 2: txtLek2.Text = lstSearch.SelectedItem.ToString();
                    txtOp2.Text = "1";
                    cmbOdpl2.Text = "";
                    cmbOdpl2.Items.Clear();
                    foreach (Lek t in Leki)
                    {
                        if (txtLek2.Text == t.Nazwa) cmbOdpl2.Items.Add(t.Refundacja);
                    }
                    focus = 3;
                    break;
                case 3: txtLek3.Text = lstSearch.SelectedItem.ToString();
                    txtOp3.Text = "1";
                    cmbOdpl3.Text = "";
                    cmbOdpl3.Items.Clear();
                    foreach (Lek t in Leki)
                    {
                        if (txtLek3.Text == t.Nazwa) cmbOdpl3.Items.Add(t.Refundacja);
                    }
                    focus = 4;
                    break;
                case 4: txtLek4.Text = lstSearch.SelectedItem.ToString();
                    txtOp4.Text = "1";
                    cmbOdpl4.Text = "";
                    cmbOdpl4.Items.Clear();
                    foreach (Lek t in Leki)
                    {
                        if (txtLek4.Text == t.Nazwa) cmbOdpl4.Items.Add(t.Refundacja);
                    }
                    focus = 5;
                    break;
                case 5: txtLek5.Text = lstSearch.SelectedItem.ToString();
                    txtOp5.Text = "1";
                    cmbOdpl5.Text = "";
                    cmbOdpl5.Items.Clear();
                    foreach (Lek t in Leki)
                    {
                        if (txtLek5.Text == t.Nazwa) cmbOdpl5.Items.Add(t.Refundacja);
                    }
                    focus = 0;
                    break;
            }
            lstRefresh("", 0);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {

        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            txtPacjent.Text = "";
            txtPESEL.Text = "";
            cmbUprawnienia.Text = "";
            cmbNFZ.Text = "";
            datOdDnia.Value = DateTime.Now;
            txtOp1.Text = "";
            txtOp2.Text = "";
            txtOp3.Text = "";
            txtOp4.Text = "";
            txtOp5.Text = "";
            txtLek1.Text = "";
            txtLek2.Text = "";
            txtLek3.Text = "";
            txtLek4.Text = "";
            txtLek5.Text = "";
            focus = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void txtLek1_TextChanged(object sender, EventArgs e)
        {
            focus = 1;
            lstRefresh(txtLek1.Text, txtLek1.Text.Length);
        }

        private void txtLek2_TextChanged(object sender, EventArgs e)
        {
            focus = 2;
            lstRefresh(txtLek2.Text, txtLek2.Text.Length);
        }

        private void txtLek3_TextChanged(object sender, EventArgs e)
        {
            focus = 3;
            lstRefresh(txtLek3.Text, txtLek3.Text.Length);
        }

        private void txtLek4_TextChanged(object sender, EventArgs e)
        {
            focus = 4;
            lstRefresh(txtLek4.Text, txtLek4.Text.Length);
        }

        private void txtLek5_TextChanged(object sender, EventArgs e)
        {
            focus = 5;
            lstRefresh(txtLek5.Text, txtLek5.Text.Length);
        }

        private void txtLek1_Click(object sender, EventArgs e)
        {
            focus = 1;
        }

        private void txtLek2_Click(object sender, EventArgs e)
        {
            focus = 2;
        }

        private void txtLek3_Click(object sender, EventArgs e)
        {
            focus = 3;
        }

        private void txtLek4_Click(object sender, EventArgs e)
        {
            focus = 4;
        }

        private void txtLek5_Click(object sender, EventArgs e)
        {
            focus = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLek1.Text = "";
            txtOp1.Text = "";
            cmbOdpl1.Items.Clear();
            cmbOdpl1.Text = "";
            focus = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLek2.Text = "";
            txtOp2.Text = "";
            cmbOdpl2.Items.Clear();
            cmbOdpl2.Text = "";
            focus = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtLek3.Text = "";
            txtOp3.Text = "";
            cmbOdpl3.Items.Clear();
            cmbOdpl3.Text = "";
            focus = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtLek4.Text = "";
            txtOp4.Text = "";
            cmbOdpl4.Items.Clear();
            cmbOdpl4.Text = "";
            focus = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtLek5.Text = "";
            txtOp5.Text = "";
            cmbOdpl5.Items.Clear();
            cmbOdpl5.Text = "";
            focus = 5;
        }

        private void btnDrukuj_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
                printDocument.PrinterSettings = printDialog1.PrinterSettings;
                printDocument.Print();
            }
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Font font = new Font("Arial", 8))
            {
                g.DrawImage(Image.FromFile(@"Recepta.png"), 10, 10, 370, 810);

                g.DrawString(LICENCJA, font, Brushes.Black, 20, 50);

                if (txtLek1.Text != "") g.DrawString(txtLek1.Text + "\n" + txtOp1.Text + " op", font, Brushes.Black, 20, 330);
                if (txtLek2.Text != "") g.DrawString(txtLek2.Text + "\n" + txtOp2.Text + " op", font, Brushes.Black, 20, 385);
                if (txtLek3.Text != "") g.DrawString(txtLek3.Text + "\n" + txtOp3.Text + " op", font, Brushes.Black, 20, 440);
                if (txtLek4.Text != "") g.DrawString(txtLek4.Text + "\n" + txtOp4.Text + " op", font, Brushes.Black, 20, 495);
                if (txtLek5.Text != "") g.DrawString(txtLek5.Text + "\n" + txtOp5.Text + " op", font, Brushes.Black, 20, 550);

                g.DrawString(cmbOdpl1.Text, font, Brushes.Black, 300, 330);
                g.DrawString(cmbOdpl2.Text, font, Brushes.Black, 300, 385);
                g.DrawString(cmbOdpl3.Text, font, Brushes.Black, 300, 440);
                g.DrawString(cmbOdpl4.Text, font, Brushes.Black, 300, 495);
                g.DrawString(cmbOdpl5.Text, font, Brushes.Black, 300, 550);

                g.DrawString(txtPacjent.Text, font, Brushes.Black, 20, 180);

                g.DrawString(txtPESEL.Text, font, Brushes.Black, 70, 262);

                if (cmbNFZ.Text.Length>2) g.DrawString(cmbNFZ.Text.Substring(0,2), font, Brushes.Black, 300, 180);
                g.DrawString(cmbUprawnienia.Text, font, Brushes.Black, 300, 260);

                g.DrawString(DateTime.Now.ToShortDateString(), font, Brushes.Black, 20, 710);

                g.DrawString(datOdDnia.Value.ToShortDateString(), font, Brushes.Black, 20, 780);
            }
        }

        private void datOdDnia_ValueChanged(object sender, EventArgs e)
        {

        }

    }

    public class Lek
    {
        public String Id;
        public String Nazwa;
        public String Skladnik;
        public String Refundacja;
    }
}
