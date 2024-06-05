namespace MyWebApiApp.Models
{
    public class HangHoaVM
    {
        public string TenHangHoa {  get; set; }
        public double DonGia {  get; set; }
    }
    public class HanggHoa : HangHoaVM 
    {
      public Guid MaHangHoa { get; set; }
    }
}
