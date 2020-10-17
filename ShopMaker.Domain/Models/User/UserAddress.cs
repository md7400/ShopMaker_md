using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopMaker.Domain.Models.User
{
    public class UserAddress
    {
        public UserAddress()
        {

        }

        [Key]
        public int AddressId { get; set; }

        [DisplayName("کد کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(1024, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public int UserId { get; set; }

        [DisplayName("شهر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(1024, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string CityId { get; set; }

        [DisplayName("آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(2048, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Address { get; set; }

        [DisplayName("کد پستی")]
        [MaxLength(16, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string PostalCode { get; set; }

        #region Relations

        public User Users { get; set; }
        public City Cities { get; set; }

        #endregion

    }
}
