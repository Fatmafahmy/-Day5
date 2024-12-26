internal class Program
{

    public static void Swap(int x, int y)
    {
        int Tamp = x;
        x = y;
        y = Tamp;
    }

    public static void Swap(ref int x, ref int y)
    {
        int Tamp = x;
        x = y;
        y = Tamp;
    }

    public static int SumArray(int[] Arr)
    {
        int sum = 0;
        Arr[0] = 100;
        for (int i = 0; i < Arr.Length; i++)
        {
            sum += Arr[i];
        }
        return sum;
    }

    public static int SumArray(ref int[] Arr)
    {
        int sum = 0;
        Arr[0] = 100;
        for (int i = 0; i < Arr.Length; i++)
        {
            sum += Arr[i];
        }
        return sum;
    }

    public static void SumDef(int num1, int num2, int num3, int num4, out int Sum, out int Differance)
    {
        Sum = num1 + num2 + num3 + num4;
        Differance = num1 - num2 - num3 - num4;

    }

    public static int SmDigit(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    public static void MinMaxArray(int[] array, ref int min, ref int max)
    {
        min = array[0];
        max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
            if (array[i] > max)
                max = array[i];
        }
    }

    public static long Factorial(int number)
    {
        long Factorial = 1;
        for (int i = 1; i < number; i++)
        {
            Factorial *= number;
        }
        return Factorial;
    }

    public static string ChangeChar(string str, char ch)
    {
        return ch + str.Substring(1);
    }
    private static void Main(string[] args)
    {
        #region Q1 Value Type Parameters

        //Value will not change but Referance will Change
        #region By Value
        //int A = 5;
        //int B = 9;
        //Console.WriteLine(A);
        //Console.WriteLine(B);
        //Swap(A, B);
        //Console.WriteLine(A);
        //Console.WriteLine(B);
        #endregion

        #region By Referance
        //int A = 5;
        //int B = 9;
        //Console.WriteLine(A);
        //Console.WriteLine(B);
        //Swap(ref A, ref B);
        //Console.WriteLine(A);
        //Console.WriteLine(B);
        #endregion
        #endregion

        #region Q2 Referance Type 
        //Will have the same value
        #region By Value
        //int[] Numbers = { 1, 2, 3 };
        //Console.WriteLine(Numbers); //105
        //Console.WriteLine(Numbers[0]);//100
        #endregion

        #region by ref
        //int[] Numbers = { 1, 2, 3 };
        //Console.WriteLine(Numbers); //105
        //Console.WriteLine(Numbers[0]);//100
        #endregion
        #endregion

        #region Q3 Get Sum Defference
        //Console.WriteLine("Enter first Number");
        //int numb1 =int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter second Number");
        //int numb2 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter third Number");
        //int numb3 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter fourth Number");
        //int numb4 = int.Parse(Console.ReadLine());
        //int Sum, Differance;

        //SumDef(numb1,numb2,numb3,numb4 ,out Sum, out Differance);
        //Console.WriteLine(Sum);
        //Console.WriteLine(Differance);
        #endregion


        #region Q4 calculate the sum of the individual digits of a given numbe
        //Console.WriteLine("Enter The Number");
        //int number =int.Parse(Console.ReadLine());

        //int result = SmDigit( number);
        //Console.WriteLine(result);
        #endregion

        #region Q5 Isprime nom or not
        //Console.WriteLine("Enter The Number");
        //int number =int.Parse(Console.ReadLine());

        //bool result = IsPrime( number);
        //Console.WriteLine(result);
        #endregion

        #region Q6 MinMax
        //int[] numbers = { 66,77,99,44 };
        //int min = 0, max = 0;
        //MinMaxArray(numbers, ref min, ref max);
        //Console.WriteLine(min + " " + max);
        #endregion

        #region Q7   Factorial
        //Console.WriteLine("Enter The Number");
        //int number =int.Parse(Console.ReadLine());

        //long result = Factorial( number);
        //Console.WriteLine(result);
        #endregion

        #region Q8 ChangeChar
        //Console.WriteLine("Enter the Word");
        //string input = Console.ReadLine();
        //Console.WriteLine("Enter the new Word");
        //char newword = Console.ReadLine()[0];
        //string result =ChangeChar (input,newword);
        //Console.WriteLine(result);
        #endregion
    }
}