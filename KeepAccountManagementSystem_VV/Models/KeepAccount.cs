using System.ComponentModel.DataAnnotations;

namespace KeepAccountManagementSystem_VV.Models;

public class KeepAccount
{
    [Required]
    public string Amount { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public string Remark { get; set; }
}