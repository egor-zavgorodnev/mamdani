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

            LC = new LogicalConclusion(country, background, consequence, X, Y, Ax, A, By, B, R);

            setData();
        }

        string country = "Саудовская Аравия"; //название страны
        string background = "Цена на нефть"; //предпосылка
        string consequence = "Бюджет"; //следствие

        string[] X = new string[] { "10$", "20$", "50$", "80$", "100$", "120$", "150$" }; //цена на нефть в долларах США
        string[] Y = new string[] { "-3%", "-1%", "0%", "1%", "3%", "5%" }; //сбалансированность бюджета в %. 0% - сбалансированный, меньше нуля - дефицитный, больше нуля - профицитный

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

        string[] By = new string[] { "Очень дефицитный",   //следствия
                                    "Дефицитный", 
                                    "Сбалансированный", 
                                    "Профицитный", 
                                    "Очень профицитный" };

        double[][] B = new double[][] { new double[] { 1, 0.7, 0, 0, 0, 0 },
                                        new double[] { 0.8, 1, 0.1, 0, 0, 0 },
                                        new double[] { 0, 0.5, 1, 0.5, 0, 0 },
                                        new double[] { 0, 0, 0.1, 0.9, 0.9, 0.3 },
                                        new double[] { 0, 0, 0, 0.2, 0.7, 1 } };

        string[][] R = new string[][] { new string[] { "Критически низкая", "Очень дефицитный" }, //правила
                                        new string[] { "Очень низкая", "Очень дефицитный" },
                                        new string[] { "Низкая", "Дефицитный" },
                                        new string[] { "Приемлемая", "Дефицитный" },
                                        new string[] { "Ниже среднего", "Сбалансированный" },
                                        new string[] { "Средняя", "Сбалансированный" },
                                        new string[] { "Выше среднего", "Профицитный" },
                                        new string[] { "Высокая", "Профицитный" },
                                        new string[] { "Очень высокая", "Очень профицитный" },
                                        new string[] { "Неимоверно высокая", "Очень профицитный" } };

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



    }
}
