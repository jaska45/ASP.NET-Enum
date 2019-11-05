using System.ComponentModel.DataAnnotations;

namespace RazorEnum.Models
{
  public enum Sport
  {
    [Display(Name = "Soccer")]
    Soccer,

    [Display(Name = "Ice hockey")]
    IceHockey,

    [Display(Name = "Basketball")]
    Basketball
  }
}
