using System;
using System.Collections.Generic;

class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo(int tuSo, int mauSo)
    {
        TuSo = tuSo;
        MauSo = mauSo;
    }

    public void NhapPhanSo()
    {
        Console.Write("Ban hay nhap tu so: ");
        TuSo = int.Parse(Console.ReadLine());

        Console.Write("Ban hay nhap mau so: ");
        MauSo = int.Parse(Console.ReadLine());
        while (MauSo == 0)
        {
            Console.WriteLine("Mau so khong the bang 0. Ban hay nhap lai.");
            Console.Write("Ban hay nhap lai mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }
    }

    public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
    {
        int tuSo = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
        int mauSo = ps1.MauSo * ps2.MauSo;
        return new PhanSo(tuSo, mauSo);
    }

    public override string ToString()
    {
        return $"{TuSo}/{MauSo}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<PhanSo> listPhanSo = new List<PhanSo>();
        int soPhanSo;

        Console.Write("Ban hay nhap so luong phan so: ");
        soPhanSo = int.Parse(Console.ReadLine());

        for (int i = 0; i < soPhanSo; i++)
        {
            Console.WriteLine($"Ban hay nhap phan so thu nhat {i + 1}:");
            PhanSo ps = new PhanSo(0, 1);
            ps.NhapPhanSo();
            listPhanSo.Add(ps);
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (var ps in listPhanSo)
        {
            tong += ps;
        }

        Console.WriteLine("Tong cac phan so la: " + tong);
    }
}