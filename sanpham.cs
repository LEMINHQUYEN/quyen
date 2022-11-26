using System;
namespace baitap
{
    class Sanpham
    {
        private string masp;
        private double gia;
        private int hangton;
        public Sanpham(string masp,double gia,int hangton)
        {
            this.masp=masp;
            this.gia=gia;
            this.hangton=hangton;
        }
        
        public string Masp
        {
            get 
            {
                return masp;
            }
            set
            {
                masp=value;
            }
        }
        public double Gia
        {
            get
            {
                return gia;
            }
            set 
            {
                gia=value;
            }
        }
        public int Hangton
        {
            get
            {
                return hangton;

            }
            set {
                hangton=value;
            }
        }
        public void Display()
        {
            Console.Write($"\n{Masp}\t\t{Gia}\t\t{Hangton}");
        }
    }
}