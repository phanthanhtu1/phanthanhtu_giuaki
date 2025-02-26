using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phanthanhtu_giuaki
{
    class GiangVien

    {
        public string Maso { get; set; }
        public string Hoten { get; set; }
        public int Namsinh { get; set; }
        public GiangVien()
        {

        }
        public GiangVien(string maso, string hoten, int namsinh)
        {
            maso = maso;
            hoten = hoten;
            namsinh = namsinh;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhập mã số giảng viên");
            Console.ReadLine();
            Console.WriteLine("nhập họ tên giảng viên");
            Console.ReadLine();
            Console.WriteLine("Nhập năm sinh của giảng viên");
            Namsinh = int.Parse(Console.ReadLine());
        }
        public virtual int tinhluong()
        {
            return 0;
        }
        class GiangVienCH : GiangVien
        {
            private float hesoluong;
            public GiangVienCH () :base()
            {
                Hesoluong = 0;
            }   
            public GiangVienCH (string maso, string hoten, int namsinh, float hesoluong)
                :base(maso, hoten, namsinh)
            {
                this.Hesoluong = hesoluong;
            }  
            public float Hesoluong 
            { 
                get { return Hesoluong; }
                set { Hesoluong = value; }
            }
            public override void nhap()
            {
                base.nhap();
                Console.Write("nhập hệ số lương");
                Hesoluong = float.Parse(Console.ReadLine());
            }
            public override int tinhluong()
            {
                return (int)(Hesoluong * 2340000);
            }    
        }    
        public class GiangVienTG : GiangVien
        {
            public int SoTietDay { get; set; }

            public GiangVienTG() : base()
            {
                SoTietDay = 0;
            }    
            public GiangVienTG(string maso, string hoten, int namsinh, int sotietday)
                :base(maso, hoten, namsinh)
            {
                SoTietDay = sotietday;
            }
            public override void nhap()
            {
                base.nhap();
                Console.Write("Nhập số tiết dạy: ");
                SoTietDay = int.Parse(Console.ReadLine());
            }
            public override int tinhluong()
            {
                return SoTietDay * 120000;
            }
            class program
            {
                static void main(string[] args)
                {
                    Console.WriteLine("nhập thông tin giảng viên cơ hữu:");
                    GiangVienCH gvch = new GiangVienCH();
                    gvch.nhap();
                    Console.WriteLine($"lương của giảng viên cơ hữu : {.tinhluong():N0} VNĐ");
                    Console.WriteLine("nhập thông tin giảng viên thỉnh giảng:");
                    GiangVienTG gvtg = new GiangVienTG();
                    gvtg.nhap();
                    Console.WriteLine($"lương của giảng viên thỉnh giảng : {gvtg.tinhluong():N0} VNĐ");
                }
            }    
        }    

    }
}     