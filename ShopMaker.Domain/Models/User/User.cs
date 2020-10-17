using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopMaker.Domain.Models.User
{
    public class User
    {
        public User()
        {

        }

        [Key]
        public int UserId { get; set; }
        
        [DisplayName("سوال امنیتی")]
        public int QuestionId { get; set; }

        [DisplayName("آدرس ایمیل")]
        [MaxLength(256, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "پست الکترونیک وارد شده صحیح نمی باشد")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string Email { get; set; }

        [DisplayName("کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Password { get; set; }

        [DisplayName("موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(16, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Mobile { get; set; }

        [DisplayName("تلفن ثابت")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(16, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Phone { get; set; }

        [DisplayName("کد احراز هویت")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string IdentificationCode { get; set; }

        [DisplayName("کد تأیید")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(12, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string ConfirmationCode { get; set; }

        [DisplayName("IP ثبت نام")]
        [MaxLength(32, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string RegisterIp { get; set; }

        [DisplayName("IP آخرین ورود")]
        [MaxLength(32, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string LastLoginIp { get; set; }

        [DisplayName("تاریخ ثبت نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public DateTime CreateUserDate { get; set; }

        [DisplayName("تاریخ آخرین ورود")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public DateTime LastUserLoginDate { get; set; }

        [DisplayName("وضعیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(64, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public bool StatusUser { get; set; }

        [DisplayName("تاییدیه ایمیل")]
        public bool EmailConfirmation { get; set; }

        [DisplayName("تاییدیه موبایل")]
        public bool MobileConfirmation { get; set; }

        [DisplayName("تاییدیه تلفن ثابت")]
        public bool PhoneConfirmation { get; set; }

        [DisplayName("ورود دو مرحله ای")]
        public bool TwoFactorAuthentication { get; set; }

        [DisplayName("فعال بودن حساب کاربری")]
        public bool IsActive { get; set; }

        [DisplayName("غیرفعال بودن یا حذف حساب کاربری")]
        public bool IsDelete { get; set; }

        #region Relations Class User

        // یک کاربر می تواند چندین پروفایل داشته باشد
        public List<UserProfile> UserProfiles { get; set; }

        public List<UserAddress> UserAddresses { get; set; }

        public List<UserDocument> UserDocuments { get; set; }

        #endregion

    }
}
