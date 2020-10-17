using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopMaker.Domain.Models.User
{
    public class UserDocument
    {
        public UserDocument()
        {

        }

        [Key]
        public int DocumentId { get; set; }

        [DisplayName("نام کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(96, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public int UserId { get; set; }

        [DisplayName("نوع مدرک یا سند")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int DocumentTypeId { get; set; }

        [DisplayName("سند یا مدرک")]
        [MaxLength(128, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Document { get; set; }

        [DisplayName("تاریخ ایجاد سند")]
        public DateTime CreateDocumentDate { get; set; }

        [DisplayName("تأیید سند")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(96, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public bool AcceptedDocument { get; set; }

        #region Relations Document 

        public User User { get; set; }

        public DocumentType DocumentType { get; set; }

        #endregion

    }
}
