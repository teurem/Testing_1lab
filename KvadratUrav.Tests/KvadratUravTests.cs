namespace testing1lab.Test {

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getRoots()
        {
            // arrange
            double vhodA = 3;
            double vhodB = -14;
            double vhodC = -5;

            string[] roots = new string[] { Convert.ToString(5.000), Convert.ToString(-0.333)};

            // act
            KvadratUrav kvadratUrav = new KvadratUrav();
            string[] actual = kvadratUrav.FindRoots(vhodA, vhodB, vhodC);

            //assert
            CollectionAssert.AreEqual(actual, roots);
        }

        [TestMethod]
        public void getAIsZero()
        {
            double a = 0;
            double b = 6;
            double c = 3;

            string[] message = new string[] { "Уравнение не является квадратным" };

            KvadratUrav kvadratUrav = new KvadratUrav();
            string[] actual = kvadratUrav.FindRoots(a, b, c);

            CollectionAssert.AreEqual(actual, message);

        }

        [TestMethod]
        public void getRootsIsKompleks() 
        {
            double a = 1;
            double b = 2;
            double c = 3;

            string[] message = new string[] { "Корни уравнения комплексные" };

            KvadratUrav kvadratUrav = new KvadratUrav();
            string[] actual = kvadratUrav.FindRoots(a, b, c);

            CollectionAssert.AreEqual(actual, message);
        }

    }
}