using System.ComponentModel.DataAnnotations;

namespace AuthWebApplication.Model
{
  public class UserDto
  {
    #region UserName
    [Required(AllowEmptyStrings = false)]
    public string UserName { get; set; } = default!;
    #endregion

    #region Email
    //[Required(AllowEmptyStrings = false)]
    //[EmailAddress]
    //public string UserEmail { get; set; } = default!;
    #endregion

    #region Password
    [Required(AllowEmptyStrings = false)]
    [StringLength(50, MinimumLength = 5)]
    public string Password { get; set; } = default!;
    #endregion
  }
}
