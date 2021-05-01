using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SII_lr3
{
    class LogicalConclusion
    {
        string background; //предпосылка
        string consequence; //следствие

        string[] X; // уникальность курсовой работы
        string[] Y; //количество дней до сессии

        string[] Ax;   //предпосылки

        double[][] A;

        string[] By;   //следствия

        double[][] B;

        string[][] R; //правила

        public LogicalConclusion(string background, string consequence, string[] X, string[] Y, string[] Ax, double[][] A, string[] By, double[][] B, string[][] R)
        {
            this.background = background;
            this.consequence = consequence;
            this.X = X;
            this.Y = Y;
            this.Ax = Ax;
            this.A = A;
            this.By = By;
            this.B = B;
            this.R = R;
        }

        // первоначальная агрегацией правил
        public string Algorithm(string backgr, string implicationType)
        {
            double[][][] R_i = new double[R.GetLength(0)][][];
            for (int k = 0; k < R.GetLength(0); k++)
            {
                R_i[k] = new double[X.Length][];
                for (int i = 0; i < X.Length; i++)
                    R_i[k][i] = new double[Y.Length];
            }

            for (int k = 0; k < R.GetLength(0); k++)
            {
                int a_index = Array.IndexOf(Ax, R[k][0]);
                int b_index = Array.IndexOf(By, R[k][1]);

                Mamdani(A[a_index], B[b_index], R_i[k]);
            }

            double[][] R_agg = new double[X.Length][];
            for (int i = 0; i < X.Length; i++)
                R_agg[i] = new double[Y.Length];

            for (int i = 0; i < X.Length; i++)
                for (int j = 0; j < Y.Length; j++)
                {
                    double max = R_i[0][i][j];
                    for (int k = 1; k < R.GetLength(0); k++)
                        if (R_i[k][i][j] > max) max = R_i[k][i][j];
                    R_agg[i][j] = max;
                }

            double[] B_ = new double[Y.Length];

            int a__index = Array.IndexOf(Ax, backgr);

            Max_Min(A[a__index], R_agg, B_);

            string result = "";

            for (int j = 0; j < Y.Length; j++)
                result += "(" + Y[j] + ")" + "/" + B_[j] + "+";

            if (result.Length > 0)
                result = result.Remove(result.Length - 1);

            return result;
        }


        private void Mamdani(double[] A, double[] B, double[][] R)
        {
            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < B.Length; j++)
                    R[i][j] = Min(A[i], B[j]);
        }


        private double Min(double a, double b)
        {
            if (a <= b)
                return a;
            else
                return b;
        }

        private void Max_Min(double[] A, double[][] R, double[] B)
        {
            List<double> tmpMAX = new List<double>();

            for (int j = 0; j < R[0].GetLength(0); j++)
            {
                tmpMAX.Clear();

                for (int k = 0; k < R.GetLength(0); k++)
                    tmpMAX.Add(Min(A[k], R[k][j]));

                B[j] = tmpMAX.Max();
            }
        }




    }
}
