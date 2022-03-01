using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_1
{
    public delegate bool TypeSort(int[] a, int[] b);
    public delegate void Sort(ref int[][] arr, TypeSort asc);
    public class Matrix
    {
        public int[][] matrix = new int[][] { new int[] { 2, 0, 0 }, new int[] { 5, 4, -3 }, new int[] { 0, -15, 20 } };
        private Sort Alg { get; set; }
        private TypeSort AlgType { get; set; }

        public Matrix(IAlgorythm alg, Type type)
        {
            Alg = new Sort(alg.SortMatrix);
            AlgType = type.IsCorrect;
        }

        public Matrix(IAlgorythm alg)
        {
            Alg = new Sort(alg.SortMatrix);
        }

        public Matrix( Type type)
        {
            AlgType = type.IsCorrect;
        }

        public Matrix () {}

        public void setAlgorythm(IAlgorythm arg)
        {
            Alg = new Sort(arg.SortMatrix);
        }

        public void setType(Type arg)
        {
            AlgType=arg.IsCorrect;
        }

        public void SortMatrix()
        {
            if (Alg == null || AlgType == null)
            {
                return;
            }
            Alg(ref matrix, AlgType);
        }

        public void Show ()
        {
            string[] str = new string[matrix.Length];
            for (int i =0; i < matrix.Length; i++)
            {
                str[i] = String.Join(" ", matrix[i]);
            }
            Console.WriteLine("( {0} )", String.Join(" | ", str));
        }
    }
   
}
