using System;
using System.Collections.Generic;

public abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}

public class HinhTron : Hinh
{
    private double banKinh;

    public HinhTron(double banKinh)
    {
        this.banKinh = banKinh;
    }

    public override double TinhChuVi()
    {
        return 2 * Math.PI * banKinh;
    }

    public override double TinhDienTich()
    {
        return Math.PI * banKinh * banKinh;
    }

    public override string ToString()
    {
        return $"Hinh Tron: Chu vi = {TinhChuVi():F2}, Dien tich = {TinhDienTich():F2}";
    }
}