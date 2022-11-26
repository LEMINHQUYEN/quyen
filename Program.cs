using System;
namespace baitap
{
    class Program
    {
        public static void Main()
        {
            Sanpham tra=new Sanpham("tra",1000,1);
            Sanpham thuoc=new Sanpham("thuoc",3000,4);
            Sanpham ruou=new Sanpham("Ruou",400,2);
            Kho kho=new Kho();
           
            kho.khoitao(tra);
            kho.khoitao(thuoc);
            kho.khoitao(ruou);
            kho.Show();
            Console.WriteLine();
            kho.timkiem("tra");
            Console.WriteLine();
            Sanpham thuoc1 =new Sanpham("thuoc",3000,2);
            kho.them(thuoc1);
            Sanpham bia=new Sanpham("bia",700,2);
            kho.them(bia);
            kho.Show();
            Console.WriteLine();

            kho.xoa("tra");
            kho.Show();
           Console.WriteLine();
           
            kho.sua("Ruou","Ruounho");

            kho.Show();

        }
    }
}