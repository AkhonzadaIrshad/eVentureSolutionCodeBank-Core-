namespace MethodOverloadingAndConstructors
{
    class Calculator
    {
        static Calculator()
        {
            pi = 3.14f;
        }

        private static float pi;

        public static float AreaOfCircle(float radius)
        {
            return radius * radius * pi;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static string Add(string a, string b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b;
        }
        public static int Add(int a, float b)
        {
            return a + (int)b;
        }
        public static int Add(float a, int b)
        {
            return (int)a + b;
        }
    }
}