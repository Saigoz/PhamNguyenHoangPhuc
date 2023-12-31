using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;


namespace PhamNguyenHoangPhuc
{
    public class ViecCanLam
    {
        public string TenViecLam { get; set; }
        public int DoUuTien { get; set; }
        public string MoTaThongTinCongViec { get; set; }
        public string TrangThai { get; set; }
    }
   public class Program
    {
        static List<ViecCanLam> listVCL = new List<ViecCanLam>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Thong tin viec can lam");
                Console.WriteLine("2.Xoa thong tin viec can lam");
                Console.WriteLine("3.Trang thai viec can lam");
                Console.WriteLine("4.Them viec can lam");
                Console.WriteLine("5.Tim kiem viec can lam");
                Console.WriteLine("6.Viec can lam theo do uu tien giam dan");
                Console.WriteLine("7.Danh sach viec can lam");
                
                Console.WriteLine("Chon chuc nang can thuc hien");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Thong tin viec can lam");
                        break;

                    case 2:
                        Console.WriteLine("Xoa thong tin viec can lam");
                        break;

                    case 3:
                        Console.WriteLine("Trang thai cong viec");
                        break;

                    case 4:
                        Console.WriteLine("Them viec can lam");
                        break;

                    case 5:
                        Console.WriteLine("Tim kiem viec can lam");
                        break;

                    case 6:
                        Console.WriteLine("Viec can lam theo do uu tien giam dan");
                        break;

                    case 7:
                        Console.WriteLine("Danh sach viec can lam");
                        break;

                    case 8:
                        Console.WriteLine("Tuy chon khong hop le");
                        break;
                }
                Console.WriteLine("Nhan Y de thoat");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Y) 
                {
                    break;
                }
                Console.Clear();
            }
        }
        public static void ThongTinViecCanLam()
        {
            Console.Write("Nhap thong tin viec can lam:");
            string thongtinvieccanlam = Console.ReadLine();

            Console.Write("Nhap do uu tien (1-5):");
            int douutien = int.Parse(Console.ReadLine());

            Console.Write("Nhap mo ta viec can lam");
            string motavieccanlam = Console.ReadLine(); 

            ViecCanLam vcl = new ViecCanLam();
            listVCL.Add(vcl);
           
        }
        public static void XoaThongTinViecCanLam() 
        {
            Console.Write("Nhap thong tin viec can xoa: ");
            string thongtinviec = Console.ReadLine();
            listVCL.RemoveAll(_ => _.TenViecLam == thongtinviec);
        }
        public static void TrangThaiCongViec() 
        {
            Console.Write("Nhap vi tri viec can cap nhat trang thai:");
            int position = Convert.ToInt32(Console.ReadLine());
            if(position >= 0 && position < listVCL.Count)
            {
                Console.Write("Nhap trang thai moi (Hoan thanh/Chua hoan thanh):");
                string status = Console.ReadLine();

                listVCL[position].TrangThai = status;
                Console.WriteLine("Trang thai viec can lam da cap nhat thanh cong");
            }
            else 
            {
                Console.WriteLine("Vi tri khong hop le.");
            }
        }
        public static void TimKiemViecCanLam()
        {
            Console.Write("Nhap ten viec can tim kiem");
            string tenvieccantimkiem = Console.ReadLine();

            List<ViecCanLam> ketquatimkiem = listVCL.FindAll(item => item.TenViecLam.Contains(tenvieccantimkiem));

            if (ketquatimkiem.Count > 0)
            {
                Console.WriteLine("Cac viec can lam co ten chua '{0}':,name");

            }
            else
            {
                Console.WriteLine("Khong tim thay viec can lam co ten chua '{0}', name");
            }
        }
        public static void CongViecCanLamTheoDoUuTienGiamDan()
        {
            var temp = listVCL.OrderByDescending (c => c.TenViecLam).ToList();

            foreach (var item in temp) 
            {
                Console.WriteLine("Ten viec can lam", item.TenViecLam);
                Console.WriteLine("Do uu tien", item.DoUuTien);
                Console.WriteLine("Mo ta thong tin viec can lam", item.MoTaThongTinCongViec);
                Console.WriteLine("Trang thai viec can lam", item.TrangThai);
                Console.WriteLine();
            }
        }
        public static void Xemdanhsach()
        {
            foreach(var item in listVCL)
            {
                Console.WriteLine("Ten viec can lam", item.TenViecLam);
                Console.WriteLine("Do uu tien", item.DoUuTien);
                Console.WriteLine("Mo ta thong tin viec can lam", item.MoTaThongTinCongViec);
                Console.WriteLine("Trang thai viec can lam", item.TrangThai);
                Console.WriteLine();
            }
        }
    }
    
}



                
            
            
        
    

