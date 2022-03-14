using NUnit.Framework;
using OPD_1;
using System.Threading;
namespace Matrix_test
{
    public class Tests
    {
        [Test]
        public void MatrixSumTestSortAsc()
        {
            int[][] matrixSumAsc = new int[][] { new int[] { 5, 3, 1 }, new int[] { 5, 4, -3 }, new int[] { 0, -15, 20 }, new int[] { 2, 0, 1 }, new int[] { 2, 0, 0 } };
           
            Matrix matrix1 = new Matrix();
            matrix1.setAlgorythm(new BubleSort());
            matrix1.setType(new SumType(true));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixSumAsc);
        }
        public void MatrixSumTestSortDesc()
        {
            int[][] matrixSumDesc = new int[][] { new int[] { 2, 0, 0 }, new int[] { 2, 0, 1 }, new int[] { 0, -15, 20 }, new int[] { 5, 4, -3 }, new int[] { 5, 3, 1 } };
            Matrix matrix1 = new Matrix();
            matrix1.setAlgorythm(new BubleSort());
            matrix1.setType(new SumType(false));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixSumDesc);
        }

        [Test]
        public void MatrixMaxTestSortAsc()
        {
            int[][] matrixMaxAsc = new int[][] { new int[] { 0, -15, 20 }, new int[] { 5, 4, -3 }, new int[] { 5, 3, 1 }, new int[] { 2, 0, 0 }, new int[] { 2, 0, 1 } };
            Matrix matrix1 = new Matrix();
            matrix1.setAlgorythm(new BubleSort());
            matrix1.setType(new MaxType(true));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixMaxAsc);
        }
        [Test]
        public void MatrixMaxTestSortDesc()
        {
            int[][] matrixMaxDesc = new int[][] { new int[] { 2, 0, 0 }, new int[] { 2, 0, 1 }, new int[] { 5, 4, -3 }, new int[] { 5, 3, 1 }, new int[] { 0, -15, 20 } };
            Matrix matrix1 = new Matrix();
            matrix1.setAlgorythm(new BubleSort());
            matrix1.setType(new MaxType(false));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixMaxDesc);
        }
        [Test]
        public void MatrixMinTestSortAsc()
        {    
            int[][] matrixMinAsc = new int[][] { new int[] { 5, 3, 1 }, new int[] { 2, 0, 0 }, new int[] { 2, 0, 1 }, new int[] { 5, 4, -3 }, new int[] { 0, -15, 20 } };
            Matrix matrix1 = new Matrix();
            matrix1.setAlgorythm(new BubleSort());
            matrix1.setType(new MinType(true));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixMinAsc);
        }
        [Test]
        public void MatrixMinTestSortDesc()
        {
            int[][] matrixMinDesc = new int[][] { new int[] { 0, -15, 20 }, new int[] { 5, 4, -3 }, new int[] { 2, 0, 0 }, new int[] { 2, 0, 1 }, new int[] { 5, 3, 1 } };           
            Matrix matrix1 = new Matrix();
            matrix1.setAlgorythm(new BubleSort());
            matrix1.setType(new MinType(false));
            matrix1.SortMatrix();
            Assert.AreEqual(matrix1.matrix, matrixMinDesc);
        }

        [Test]
        public void CountdownTest()
        {
            Countdown cd = new Countdown();
            ObserverA a = new ObserverA();
            ObserverB b = new ObserverB();
            ObserverC c = new ObserverC();
            cd.Attach(a);
            cd.Attach(b);
            cd.Attach(c);
            cd.SendMessages("пора обедать!", 5);
            Assert.AreEqual(cd.message, "пора обедать!");
            
        }
    }
}