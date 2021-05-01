using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SII_lr3
{
    public partial class Form1 : Form
    {
        LogicalConclusion LC;

        public Form1()
        {
            InitializeComponent();

            LC = new LogicalConclusion(background, consequence, X, Y, Ax, A, By, B, R);

            setData();
        }

        string background = "Уникальность"; //предпосылка
        string consequence = "Время"; //следствие

        string[] X = new string[] { "10%", "20%", "40%", "60%", "70%", "80%", "100%" }; // уникальность курсовой работы
        string[] Y = new string[] { "3 дня", "5 дней", "10 дней", "15 дней", "30 дней", "60 дней" }; //количество дней до сессии

        string[] Ax = new string[] { "Критически низкая",   //предпосылки
                                    "Очень низкая",
                                    "Низкая",
                                    "Приемлемая",
                                    "Ниже среднего",
                                    "Средняя",
                                    "Выше среднего",
                                    "Высокая",
                                    "Очень высокая", 
                                    "Неимоверно высокая" };

        double[][] A = new double[][] { new double[] { 1, 0.8, 0.1, 0, 0, 0, 0 },
                                        new double[] { 1, 1, 0.3, 0, 0, 0, 0 },
                                        new double[] { 1, 1, 0.7, 0.2, 0, 0, 0 },
                                        new double[] { 0, 0.3, 0.9, 0.1, 0, 0, 0 },
                                        new double[] { 0, 0.4, 0.8, 0.2, 0, 0, 0 },
                                        new double[] { 0, 0.1, 0.7, 1, 0.5, 0, 0 },
                                        new double[] { 0, 0, 0.2, 0.6, 0.9, 0.1, 0 },
                                        new double[] { 0, 0, 0.1, 0.4, 0.6, 0.6, 0.1 },
                                        new double[] { 0, 0, 0, 0.2, 0.5, 0.9, 0.5 },
                                        new double[] { 0, 0, 0, 0.1, 0.3, 0.8, 1 } };

        string[] By = new string[] { "Очень мало",   //следствия
                                    "Мало",
                                    "В дефиците",
                                    "Достаточно",
                                    "Очень достаточно" };

        double[][] B = new double[][] { new double[] { 1, 0.7, 0, 0, 0, 0 },
                                        new double[] { 0.8, 1, 0.1, 0, 0, 0 },
                                        new double[] { 0, 0.5, 1, 0.5, 0, 0 },
                                        new double[] { 0, 0, 0.1, 0.9, 0.9, 0.3 },
                                        new double[] { 0, 0, 0, 0.2, 0.7, 1 } };

        string[][] R = new string[][] { new string[] { "Критически низкая", "Очень мало" }, //правила
                                        new string[] { "Очень низкая", "Очень мало" },
                                        new string[] { "Низкая", "Мало" },
                                        new string[] { "Приемлемая", "Мало" },
                                        new string[] { "Ниже среднего", "В дефиците" },
                                        new string[] { "Средняя", "В дефиците" },
                                        new string[] { "Выше среднего", "Достаточно" },
                                        new string[] { "Высокая", "Достаточно" },
                                        new string[] { "Очень высокая", "Очень достаточно" },
                                        new string[] { "Неимоверно высокая", "Очень достаточно" } };

        private void setData()
        {
            for (int i = 0; i < Ax.Length; i++)
                oilPriceComboBox.Items.Add(Ax[i]);
            oilPriceComboBox.SelectedIndex = 5;

        }

        private void showRulesButton_Click(object sender, EventArgs e)
        {
            rulesListBox.Visible = true;
            hideRulesButton.Visible = true;

            this.Height = 676;

            rulesListBox.Items.Clear();

            foreach(string[] r in R)
            {
                string s = "Если " + background + " " + r[0] + ", то " + consequence + " " + r[1];
                rulesListBox.Items.Add(s);
            }
        }

        private void hideRulesButton_Click(object sender, EventArgs e)
        {
            rulesListBox.Visible = false;
            hideRulesButton.Visible = false;

            this.Height = 250;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string backgr = oilPriceComboBox.SelectedItem.ToString();
       
            ResultTextBox.Text = LC.Algorithm(backgr, "Mamdani");

        }

        private void oilPriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
