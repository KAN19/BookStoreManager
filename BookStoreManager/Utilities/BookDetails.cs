using System.Collections.Generic;

namespace BookStoreManage.Utilities
{
    static class BookDetails
    {
        static public List<TypeOfBooks> SelfHelp = new List<TypeOfBooks>();
        static public List<TypeOfBooks> TieuThuyet = new List<TypeOfBooks>();
        static public List<TypeOfBooks> KinhDoanh = new List<TypeOfBooks>();
        static public List<TypeOfBooks> TruyenTranh = new List<TypeOfBooks>();
        static public List<TypeOfBooks> VanPhongPham = new List<TypeOfBooks>();

        static public List<TypeOfBooks> GetSelfHelpBooks()
        {
            SelfHelp.Add(new TypeOfBooks("Self help 1", "Đắc nhân tâm - Dale Carnegie", 74000, BookStoreMange.Properties.Resources.dac_nhan_tam));
            SelfHelp.Add(new TypeOfBooks("Self help 2", "Hành trình về Phương Đông - Baird T. Spalding", 60000, BookStoreMange.Properties.Resources.hanh_trinh_ve_phuong_dong_2));
            SelfHelp.Add(new TypeOfBooks("Self help 3", "Những kẻ xuất chúng - Malcolm Gladwell", 74000, BookStoreMange.Properties.Resources.nhung_ke_xuat_chung));
            SelfHelp.Add(new TypeOfBooks("Self help 4", "Điểm bùng phát - Malcolm Gladwell", 76000, BookStoreMange.Properties.Resources.diem_bung_phat));
            SelfHelp.Add(new TypeOfBooks("Self help 5", "Cà phê cùng Tony - Tony buổi sáng", 59000, BookStoreMange.Properties.Resources.ca_phe_cung_tony));
            SelfHelp.Add(new TypeOfBooks("Self help 6", "Trên đường băng - Tony buổi sáng", 55000, BookStoreMange.Properties.Resources.tren_duong_buong));

            return SelfHelp;
        }


        static public List<TypeOfBooks> GetVanPhongPham()
        {
            VanPhongPham.Add(new TypeOfBooks("Van phong pham 1", "But bi thien long", 5000, BookStoreMange.Properties.Resources.but_bi_thienlong));
            VanPhongPham.Add(new TypeOfBooks("Van phong pham 2", "But chi 4B", 7000, BookStoreMange.Properties.Resources.but___chi));
            VanPhongPham.Add(new TypeOfBooks("Van phong pham 3", "But xoa Thien Long", 14000, BookStoreMange.Properties.Resources.but_xoa));
            VanPhongPham.Add(new TypeOfBooks("Van phong pham 4", "But chi kim", 16000, BookStoreMange.Properties.Resources.but_chi_kim));
          
            return VanPhongPham;
        }
        static public List<TypeOfBooks> GetTieuThuyet()
        {
            TieuThuyet.Add(new TypeOfBooks("Tieu thuyet 1", "Sherlock Homes tuyển tập", 560000, BookStoreMange.Properties.Resources.Homes));
            TieuThuyet.Add(new TypeOfBooks("Tieu thuyet 2", "Tôi là bê tô - Nguyễn Nhật Ánh", 45000, BookStoreMange.Properties.Resources.toi_le_be_to));
            TieuThuyet.Add(new TypeOfBooks("Tieu thuyet 3", "Ngày xưa có một chuyện tình - Nguyễn Nhật Ánh", 65000, BookStoreMange.Properties.Resources.ngay_xua_co_1_chuyen_tinh));
            TieuThuyet.Add(new TypeOfBooks("Tieu thuyet 4", "Chiến binh cầu vòng - Andrea Hirata", 71000, BookStoreMange.Properties.Resources.chien_binh_cau_vong_sap_xuat_ban_240412_2));
           
            return TieuThuyet;
      
        }
        static public List<TypeOfBooks> GetKinhDoanh()
        {
            KinhDoanh.Add(new TypeOfBooks("Kinh doanh 1", "Câu chuyện ly kỳ của cậu bé giao báo", 62000, BookStoreMange.Properties.Resources.cau_be_giao_bao));
            KinhDoanh.Add(new TypeOfBooks("Kinh doanh 2", "Công ty sáng tạo - Ed Catmull", 69000, BookStoreMange.Properties.Resources.cong_ty_sang_tao));
            KinhDoanh.Add(new TypeOfBooks("Kinh doanh 3", "Đừng bao giờ đi ăn một mình", 58000, BookStoreMange.Properties.Resources._285143_dung_bao_gio_di_an_mot_minh_tai_ban_2016));
            KinhDoanh.Add(new TypeOfBooks("Kinh doanh 4", "Thiên nga đen", 98000, BookStoreMange.Properties.Resources.thien_nha_den));
            KinhDoanh.Add(new TypeOfBooks("Kinh doanh 5", "Tuần làm việc 4 giờ", 55000, BookStoreMange.Properties.Resources.tuan_lam_viec_4h));
          
            return KinhDoanh;
        }
        static public List<TypeOfBooks> GetTruyenTranh()
        {
            TruyenTranh.Add(new TypeOfBooks("Truyen tranh 1", "Trạng Quỷnh", 12000, BookStoreMange.Properties.Resources.trangquynh_354));
            TruyenTranh.Add(new TypeOfBooks("Truyen tranh 2", "Conan", 16000, BookStoreMange.Properties.Resources.conan));
            TruyenTranh.Add(new TypeOfBooks("Truyen tranh 3", "Shin cậu bé bút chì", 22000, BookStoreMange.Properties.Resources.cau_be_but_chi));
            TruyenTranh.Add(new TypeOfBooks("Truyen tranh 4", "Doremon", 20000, BookStoreMange.Properties.Resources.doremon));
            TruyenTranh.Add(new TypeOfBooks("Truyen tranh 5", "Ô long viện", 18000, BookStoreMange.Properties.Resources.o_long_vien));
 
            return TruyenTranh;
        }

    }
}
