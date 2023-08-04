using System.ComponentModel.DataAnnotations;
namespace NguyenVanSon_02.Models;
public class SanPham
{
    [Key]
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public string MaNCC { get; set; }
}