using System;
delegate void Procedure();

class DelegateDemo
{
    public static void Method1()
    {
        Console.WriteLine("Hello From Method 1");
    }

    public static void Method2()
    {
        Console.WriteLine("Hello From Method 2");
    }

    public void Method3()
    {
        Console.WriteLine("Hello From Method 3");
    }

    static void Main()
    {
        Procedure p = null;

        p += new Procedure(DelegateDemo.Method1);
        p += new Procedure(Method2);  // Example with omitted class name

        DelegateDemo demo = new DelegateDemo();

        p += new Procedure(demo.Method3);
        p();
    }
}