using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tempar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FishCollection.SelectedItem = "Семга";
        }
        string min, max;

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveme = new SaveFileDialog();
            saveme.Filter = "txt files (.txt)|.txt|All files (.)|.";
            if (saveme.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = saveme.FileName;
                    File.WriteAllText(filename, $"{TextAfter.Text} {FishCollection.Text}");
                }
                catch
                {
                    MessageBox.Show("Something wrong with your save file");
                }
            }
        }

        /// <summary>
        /// Проблема с вылетом приложения и вставкой текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRun_Click(object sender, EventArgs e)
        {
            if (TextBefore.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }

            string Time1 = TextBefore.Lines[0].ToString();
            string Temp = TextBefore.Lines[1].ToString();

            

            min = minTemp.Text;
            max = maxTemp.Text;

            string[] nextTemp = Temp.Split(' ');

            int[] a = Temp.Split(' ').Select(x => int.Parse(x)).ToArray();

            int[] numbers = a;

            int minNumber = a[0];
            int maxNumber = a[0];
            /// <summary>
            /// Проблема со вставкой текста решена
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            for (int i = 0;i<a.Length;i++)
            {
                
                if (a[i] < minNumber)
                {
                    minNumber = a[i];
                }
                if (a[i] > maxNumber)
                {
                    maxNumber = a[i];
                }
            }
            /// <summary>
            /// Доработать if, не работает нормальный отбор!
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            for (int i = 0; i < a.Length; i++)
            {
                if (minNumber <= Convert.ToInt32(min))
                {
                    string result = (string.Format("Порог максимальной температуры нарушен! '{0}'", min));
                    TextAfter.Text = result + Environment.NewLine + Time1 + Environment.NewLine;
                    MessageBox.Show("Есть нарушения в хранении");
                    break;
                }
                if (maxNumber >= Convert.ToInt32(max))
                {
                    string result = (string.Format("Порог минимальной температуры нарушен! '{0}'", max));
                    TextAfter.Text = result + Environment.NewLine + Time1 + Environment.NewLine;
                    MessageBox.Show("Есть нарушения в хранении");
                    break;
                }
                /*if (maxNumber != Convert.ToInt32(min) && maxNumber >= Convert.ToInt32(max) && minNumber != Convert.ToInt32(max) && minNumber <= Convert.ToInt32(min))
                {
                    TextAfter.Text = "Все идеально";
                }*/

                
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Backup 2
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            try
            {
                if (o.ShowDialog() == DialogResult.OK)
                {
                    TextBefore.Text = File.ReadAllText(o.FileName, Encoding.Default);
                }
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
        }

        private void FishCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// <summary>
            /// Backup 1
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            switch (FishCollection.Text)
            {
                case "Семга":
                    maxTemp.Text = "-5";
                    minTemp.Text = "-3";
                    timeMax.Text = "20";
                    timeMin.Text = "60";
                    break;
                case "Минтай":
                    maxTemp.Text = "-5";
                    minTemp.Text = "";
                    timeMax.Text = "20";
                    timeMin.Text = "";

                    minTemp.Clear();
                    timeMin.Clear();
                    break;
            }
        }
    }
}
