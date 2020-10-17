using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopMaker.Domain.Models.User
{
    public class SecurityQuestion
    {
        public SecurityQuestion()
        {

        }

        [Key]
        public int QuestionId { get; set; }

        [DisplayName("سوأل امنیتی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(1024, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string QuestionTitle { get; set; }

        #region Relations
        
        public User Users { get; set; }

        #endregion
    }
}
