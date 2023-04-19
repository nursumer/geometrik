using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometrik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cevapislem = comboBox2.Text;
            string cevaptip = comboBox3.Text;
            string cevapsekil = comboBox1.Text;
            switch (cevapsekil)
            {
                case ("Üçgen"):


                    if (cevapislem == "Çevre")
                    {

                        if (cevaptip == "Dik Üçgen")
                        {

                            int cevredik = 0;
                            int dik1 = int.Parse(textBox1.Text);
                            int dik2 = int.Parse(textBox2.Text);
                            int dik3 = int.Parse(textBox3.Text);
                            cevredik = dik1 + dik2 + dik3;
                            label7.Text = cevredik.ToString();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();

                        }
                        else if (cevaptip == "Eşkenar Üçgen")
                        {
                            int escev1 = 0;

                            int escev = int.Parse(textBox6.Text);
                            escev1 = 3 * escev;
                            label7.Text = escev1.ToString();
                            textBox6.Clear();

                        }
                        else
                        {
                            int ikizcev = 0;
                            int ikiz = int.Parse(textBox4.Text);
                            int taban = int.Parse(textBox5.Text);
                            ikizcev = 2 * ikiz + taban;
                            label7.Text = ikizcev.ToString();
                            textBox4.Clear();
                            textBox5.Clear();
                        }
                    }
                    else;
                    {
                        int alanüc = 0;
                        int kenarüc = int.Parse(textBox7.Text);
                        int yüküc = int.Parse(textBox8.Text);
                        alanüc = kenarüc * yüküc / 2;
                        label7.Text = alanüc.ToString();
                        textBox7.Clear();
                        textBox8.Clear();
                    }

                        break;
                    
                case ("Dikdörtgen"):
                    int dörken = int.Parse(textBox2.Text);
                    int dörken1 = int.Parse(textBox1.Text);
                    if (cevapislem== "Çevre" )
                    {
                        int dörcev = 0;
                    
                        dörcev = 2 * dörken + 2 * dörken1;
                        label7.Text = dörcev.ToString();
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    else
                    {
                        int döralan = 0;
                        döralan = dörken * dörken1;
                        label7.Text = döralan.ToString();
                        textBox1.Clear();
                        textBox2.Clear();

                    }
                   
                    break;
                case "Kare":
                    int kareken = int.Parse(textBox2.Text);
                    if (cevapislem== "Çevre")
                    {
                        int karecev = 0;
                        karecev = 4 * kareken;
                        label7.Text = karecev.ToString();
                        textBox2.Clear();

                    }
                    else
                    {
                        int karealan = 0;
                        karealan = kareken * kareken;
                        label7.Text = karealan.ToString();
                        textBox2.Clear();
                    }
                    break;
                case "Daire":
                    double yarı = Convert.ToDouble(textBox2.Text);
                    double pi = 3.14;
                    if (cevapislem == "Çevre")
                    {
                        double daicev = 0;

                        daicev = 2 * pi * yarı;
                        label7.Text = daicev.ToString();
                        textBox2.Clear();
                    }
                    else
                    {
                        double dairalan = 0;
                        dairalan = pi * yarı * yarı;
                        label7.Text = dairalan.ToString();
                        textBox2.Clear();
                        
                    }


                    break;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cevapsekil = comboBox1.Text;
            if (cevapsekil == "Üçgen")
            {
                label3.Visible = true;
                comboBox3.Visible = true;
            }
            else
            {
                comboBox3.Visible = false;
                label3.Visible = false;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cevapsek = comboBox1.Text;
            string cevapis = comboBox2.Text;


            switch (cevapsek)
            {
                case "Dikdörtgen":

                    if (cevapis == "Çevre")
                    {
                        comboBox3.Visible = false;
                        label4.Visible = true;
                        label5.Visible = true;
                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                    }
                    else
                    {
                        label4.Visible = true;
                        label5.Visible = true;
                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        comboBox3.Visible = false;
                        label11.Visible = false;
                        textBox6.Visible = false;
                        label7.Visible = true;
                        label8.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                    }

                    break;
                case "Kare":

                    if (cevapis == "Çevre")
                    {
                        comboBox1.Visible = true;
                        comboBox2.Visible = true;
                        comboBox3.Visible = false;
                        label11.Visible = true;
                        label5.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = false;
                        label4.Visible = false;
                        label6.Visible = false;
                        textBox3.Visible = false;
                        textBox5.Visible = false;
                        textBox4.Visible = false;
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        textBox8.Visible = false;

                    }
                    else
                    {
                        comboBox1.Visible = true;
                        comboBox2.Visible = true;
                        comboBox3.Visible = false;
                        label11.Visible = true;
                        label5.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = false;
                        label4.Visible = false;
                        label6.Visible = false;
                        textBox3.Visible = false;
                        textBox5.Visible = false;
                        textBox4.Visible = false;
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        textBox8.Visible = false;

                    }
                    break;
                case "Daire":
                    if (cevapis == "Çevre")
                    {
                        comboBox1.Visible = true;
                        comboBox2.Visible = true;
                        comboBox3.Visible = false;
                        label11.Visible = false;
                        label5.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = false;
                        label4.Visible = false;
                        label6.Visible = false;
                        textBox3.Visible = false;
                        textBox5.Visible = false;
                        textBox4.Visible = false;
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        textBox8.Visible = false;
                        label13.Visible = true;
                    }
                    else
                    {
                        comboBox1.Visible = true;
                        comboBox2.Visible = true;
                        comboBox3.Visible = false;
                        label11.Visible = false;
                        label5.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = false;
                        label4.Visible = false;
                        label6.Visible = false;
                        textBox3.Visible = false;
                        textBox5.Visible = false;
                        textBox4.Visible = false;
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        textBox8.Visible = false;
                        label13.Visible = true;

                    }




                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cevapislem = comboBox2.Text;
            string cevaptip = comboBox3.Text;
            switch (cevapislem)
            {
                case "Çevre":

                    
                        if (cevaptip == "Dik Üçgen")
                        {
                            label4.Visible = true;
                            label5.Visible = true;
                            label6.Visible = true;
                            label7.Visible = true;
                            label8.Visible = true;
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;
                            button1.Visible = true;
                            button2.Visible = true;

                        }



                        else if (cevaptip == "İkizkenar Üçgen")
                        {
                            label7.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;
                            label10.Visible = true;
                            textBox4.Visible = true;
                            textBox5.Visible = true;
                            button1.Visible = true;
                            button2.Visible = true;
                        }
                        else

                        {
                            label7.Visible = true;
                            label8.Visible = true;
                            label11.Visible = true;
                            textBox6.Visible = true;
                            button1.Visible = true;
                            button2.Visible = true;
                        }
                    break;
                    
                case "Alan":

                    label7.Visible = true;
                    label8.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    break;
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
           comboBox3.Visible = false;

            comboBox1.Visible = true;   
            comboBox2.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label12.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
