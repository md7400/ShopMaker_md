using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopMaker.Domain.Models.User
{
    public class City
    {
        public City()
        {

        }

        [Key]
        public int CityId { get; set; }

        [DisplayName("نام شهر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(96, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string CityName { get; set; }

        #region Relations City Class

        //public UserAddress UserAddresses { get; set; }

        #endregion
    }
}
