namespace TestClassLibrary
{
    public class TestLibraryClass
    {
        public static int Add(int a, int b)
        {
            return TestInternalClass.Add(a, b);
        }
        public static int Subtract(int a, int b)
        {
            return TestInternalClass.Subtract(a, b);
        }
        public static int Multiply(int a, int b)
        {
            return TestInternalClass.Multiply(a, b);
        }
        public static int Divide(int a, int b)
        {
            return TestInternalClass.Divide(a, b);
        }
    }
    internal class TestInternalClass
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }


    }

    public class TestNonStaticClass
    {
        public TestNonStaticClass()
        {
            Count = 0;
        }
        
        public int Count { get; set; }
        public void MakeProgress()
        {
            Count++;
        }
    }
}