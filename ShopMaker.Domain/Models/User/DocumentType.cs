using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ShopMaker.Domain.Models.User
{
    public class DocumentType
    {
        public DocumentType()
        {
            
        }

        [Key]
        public int DocumentTypeId { get; set; }

        [DisplayName("مشخصات سند یا مدرک")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(96, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string TitleDocument { get; set; }

        #region Relations Class DocumentType
        public  UserDocument UserDocuments { get; set; }

        #endregion
    }
}
