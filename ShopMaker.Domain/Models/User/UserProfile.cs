using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopMaker.Domain.Models.User
{
    public class UserProfile
    {
        public UserProfile()
        {

        }

        [Key]
        public int ProfileId { get; set; }

        [DisplayName("نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int UserId { get; set; }

        [DisplayName("نام")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [DisplayName("نام خانوادگی")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Family { get; set; }

        [DisplayName("تصویر پروفایل یا آواتار")]
        [MaxLength(128, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Avatar { get; set; }

        [DisplayName("درباره من")]
        [MaxLength(4096, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Biography { get; set; }

        [DisplayName("تاریخ تولد")]
        public DateTime DateOfBirth { get; set; }

        #region All Relations

        #endregion
    }
}
