using System.ComponentModel.DataAnnotations;
namespace NguyenVanSon_02.Models;
public class NhaCungCap
{
    [Key]
    public string MaNCC { get; set; }
    public string TenNCC { get; set; }
}