using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_window1
{
    public partial class MainForm : Form
    {
        Random R = new Random();
        int chislo;
        byte etap_pr ;
        /*
         * Console.Write("Введите до кокого числа бот будет придумивать число: ");
            while (true)
            {
                try
                {
                    max_zagad_chislo = Convert.ToInt32(Console.ReadLine());
                    zagad_chislo = R.Next(0, max_zagad_chislo);
                    return;
                }
                catch
                {
                    WriteError();
                }
            }*/
        public MainForm()
        {
            InitializeComponent();
        }
        private void etap()
        {
            switch (etap_pr)
            {
                case 0:
                    TextMin.Visible = true;
                    TextMax.Visible = true;
                    textBoxMax.Visible = true;
                    textBoxMin.Visible = true;
                    Vvod_the_text.Visible = true;
                    inputBox.Visible = false;
                    TextForm.Visible = true;
                    Play_zanovo.Enabled = true;
                    Vvod_the_text.Enabled = true;
                    inputBox.Enabled = true;
                    TextForm.Enabled = true;
                    Vvod_the_text.Text = "Ввести значения";

                    break;
            
                case 1:
                   
                    inputBox.Visible = true;
                    TextMin.Visible = false;
                    TextMax.Visible = false;
                    textBoxMax.Visible = false;
                    textBoxMin.Visible = false;
                    break;
                case 2:
                    inputBox.Visible = false;
                    TextMin.Visible = false;
                    TextMax.Visible = false;
                    textBoxMax.Visible = false;
                    textBoxMin.Visible = false;
                    Vvod_the_text.Visible = false;
                    Play_zanovo.Visible = true;
                    Play_zanovo.Enabled = true;
                    
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*Play_zanovo.Enabled = true;
            try
            {
                int res = int.Parse(inputBox.Text);
                TextForm.Text = "" + (res + 1);
                TextForm.ForeColor = Color.Green;
            }
            catch (FormatException x)
            {
                TextForm.Text = x.Message;
                TextForm.ForeColor = Color.Red;
            }*/
            switch (etap_pr)
            {
                case 0:
                    if (textBoxMax.Value>textBoxMin.Value)
                    {
                        chislo = R.Next((int)textBoxMin.Value, (int)textBoxMax.Value);
                        TextForm.Text = Convert.ToString(chislo);
                        TextForm.Text = "Введите число, которое по вашему\nмнению загадал бот, в поле ниже.";
                        etap_pr++;
                    }
                    else
                    {
                        TextForm.Text = "Введите так, штоб Max бил\nбольше чем Min";
                    }
                break;

                case 1:
                    if (Convert.ToInt32(inputBox.Value) < chislo)
                    {
                        TextForm.Text = $"{inputBox.Value} меньше загадонова числа,\nпопробуйте снова угадать число";
                    }
                    else if (Convert.ToInt32(inputBox.Value ) > chislo)
                    {
                        TextForm.Text = $"{inputBox.Value} больше загадонова числа,\nпопробуйте снова угадать число";
                    }
                    else if (Convert.ToInt32(inputBox.Value) == chislo)
                    {
                        TextForm.Text = "Молодци ви угадали число!!!\nЕсли хотите сиграть ещо раз нажмите на кнопку ниже";
                        etap_pr=0;

                    }
                    break;
            }
            etap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*int res;
            if (int.TryParse(inputBox.Text, out res))
            {
                TextForm.Text = "" + (res + 1);
                TextForm.ForeColor = Color.Green;
            }
            else
            {
                TextForm.Text = inputBox.Text;
                TextForm.ForeColor = Color.Red;
            }*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            TextMin.Visible = true;
            TextMax.Visible = true;
            textBoxMax.Visible = true;
            textBoxMin.Visible = true;
            Vvod_the_text.Visible = true;
            inputBox.Visible = false;
            TextForm.Visible = true;
            Play_zanovo.Enabled = true;
            Vvod_the_text.Enabled = true;
            inputBox.Enabled = true;
            TextForm.Enabled = true;
            Vvod_the_text.Text = "Ввести значения";
           // TextForm.Text = "Введите диапазон, в котором\nбот будет загадивать число.";
            etap_pr = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void buttonWriteMinMax_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
