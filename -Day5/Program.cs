using System.Globalization;

//class
//interface
//enum
//struct
internal class Program
{

    //Function
    //Data

    //types of Function
    //1. Class member function [Static function]
    //2.object membe Function [non static function]

    //public static void PrintShape(int Count, string Pattern)
    //{
    //    for (int i = 0; i < Count; i++)
    //    {
    //        Console.WriteLine(Pattern);
    //    }
    //}

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
    private static void Main(string[] args)
    {
        #region Casting [Boxing- Unboxing]
        //Not Reduse time And take Aplase in Memory Because that its Not Good

        //Referance Type Casting => Convert From Refarance to Referance Type
        //Boxing Casting => Convert From Value Type to Refarence Type
        //UnBoxing Casting => Convert from Referance type To Value Type

        //object obj = new object();
        //obj = "Mostafa"; //Reference Type
        //obj = 2; //Boxing [ Casting from Value Type [int] to Referance Type [Object]]
        #region Boxing[Safe Casting]
        //int x = 10; //Safe Casting
        //object  obj01 = new object();
        //obj01 = x;

        // Console.WriteLine(obj01);
        //Parent = Child
        //Dog Is Animal
        #endregion

        #region UnBoxing[Not Safe Casting]
        //object obj02 = new object(); //Not Safe Casting
        //obj02 = 10;
        //int x =(int) obj02;
        //Console.WriteLine(x);

        //Child =Parent
        //Animals is Dog
        #endregion

        #endregion

        #region Nullable Datatype

        #region Value Type
        // int x = null; // int Number only

        //int? x = null; //int Number and Null
        //Nullable<int> Number; // not used

        //Console.WriteLine(x);

        //int x = 10;
        //int? y = (int?)x;

        // int ? x =null ;
        //int y  ;

        //if (x!=null)
        //{
        //    y = (int)x; //casting
        //}
        //else
        //{
        //    y = 0 ;
        //}
        //Console.WriteLine(y);


        //if (x.HasValue)
        //{
        //    y = x.Value; //Not Casting
        //}
        //else
        //{
        //    y = 0;
        //}

        // y=x.HasValue ? x.Value : 0 ;
        //Console.WriteLine(y);

        #endregion

        #region Referance Type
        //string? Name = null;

        //Console.WriteLine(Name);
        #endregion

        #endregion

        #region Null Propagation Operation
        //int[] Numbers = null;
        ////for (int i = 0;Numbers!=null && i < Numbers.Length; i++) // i should make && long circut

        //for (int i = 0;i < Numbers?.Length; i++)
        //{
        //    Console.WriteLine(Numbers[i]);
        //}

        //if (Numbers != null) // this is best
        //{

        //    for (int i = 0; i < Numbers.Length; i++)
        //    {
        //        Console.WriteLine(Numbers[i]);
        //    }
        //}

        // i <Numbers?.length
        // Numbers => object [length]
        //Numbers =>Null [Null]


        //int length = Numbers?.length ??= 0; 
        #endregion

        #region  Function
        // PrintShape(10, "(*-*)");

        //Console.WriteLine("hallo\nwelcome to\troute");
        // PrintShape(10, @"/*\");
        #endregion

        #region Value Type Parameters
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

        #region Referance Type 
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
    }
}
