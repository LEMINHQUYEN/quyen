using System;
namespace baitap
{
    class Kho
    {
        public Kho()
        {
           
        }
          List<Sanpham> kho=new List<Sanpham>();
            Sanpham luutru;
        public void khoitao(Sanpham sanpham1)
        {
            
            kho.Add(sanpham1);

        }
        public void timkiem(string ma)
        {
              int flag=0;
            foreach(var  item in kho)
            {
                if(item.Masp.Equals(ma))
                {
                    flag=1;
                    break;
                }
            }
            if(flag==1)
            {
                Console.Write("\nTim thay");
            }
            else
            {
                Console.Write("\nKhong tim thay");
            }
        }
        public void them(Sanpham sampham1)
        {
            int flag=0;
            
            foreach(var item in kho)
            {
                if(item.Masp.Equals(sampham1.Masp))
                {
                    flag=1;
                    luutru=item;
                    kho.Remove(item);
                    break;
                }
            }
            if(flag==0)
            {
                kho.Add(sampham1);
            }
            else
            {
                luutru.Hangton = luutru.Hangton+ sampham1.Hangton;
                kho.Add(luutru);
            }
        }
        public void xoa(string masp)
        {
             foreach(var  item in kho)
            {
                if(item.Masp.Equals(masp))
                {
                   kho.Remove(item);
                    break;
                }
            }
        }
        public void sua(string masp,string ten)
        {

              foreach(var  item in kho)
            {
                if(item.Masp.Equals(masp))
                {
                    item.Masp=ten;
                    break;
                }
            }
        }

        public void Show()
        {
               foreach(var  item in kho)
            {
                item.Display();
            }
        }
    }
}