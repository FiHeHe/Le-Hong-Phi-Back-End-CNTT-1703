<<<<<<< HEAD
﻿using System;

public class Bai5
{
    // Viet ham hoan vi 2 so nguyen a va b nhap tu ban phim.
    public static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen a: ");
        int a;
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Gia tri khong hop le cho a.");
            return;
        }

        Console.Write("Nhap so nguyen b: ");
        int b;
        if (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Gia tri khong hop le cho b.");
            return;
        }

        Console.WriteLine($"Truoc hoan vi: a = {a}, b = {b}");
        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau hoan vi: a = {a}, b = {b}");

        Console.ReadKey();
    }
=======
﻿using System;

public class Bai5
{
    // Viet ham hoan vi 2 so nguyen a va b nhap tu ban phim.
    public static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen a: ");
        int a;
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Gia tri khong hop le cho a.");
            return;
        }

        Console.Write("Nhap so nguyen b: ");
        int b;
        if (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Gia tri khong hop le cho b.");
            return;
        }

        Console.WriteLine($"Truoc hoan vi: a = {a}, b = {b}");
        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau hoan vi: a = {a}, b = {b}");

        Console.ReadKey();
    }
>>>>>>> 08c81bc (fisrt commit)
}