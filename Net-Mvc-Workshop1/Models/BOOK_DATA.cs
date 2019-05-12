//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Net_Mvc_Workshop1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BOOK_DATA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOOK_DATA()
        {
            this.BOOK_KEEPER = "";
        }
        public int BOOK_ID { get; set; }
        [Required(ErrorMessage = "必填")]
        public string BOOK_NAME { get; set; }
        [Required(ErrorMessage = "必填")]
        public string BOOK_CLASS_ID { get; set; }
        [Required(ErrorMessage = "必填")]
        public string BOOK_AUTHOR { get; set; }
        [Required(ErrorMessage = "必填")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> BOOK_BOUGHT_DATE { get; set; }
        [Required(ErrorMessage = "必填")]
        public string BOOK_PUBLISHER { get; set; }
        [Required(ErrorMessage = "必填")]
        public string BOOK_NOTE { get; set; }
        [Required(ErrorMessage = "必填")]
        public string BOOK_STATUS { get; set; }
        public string BOOK_KEEPER { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> MODIFY_DATE { get; set; }
        public string MODIFY_USER { get; set; }
    
        public virtual BOOK_CLASS BOOK_CLASS { get; set; }
        public virtual MEMBER_M MEMBER_M { get; set; }
        public virtual BOOK_CODE BOOK_CODE { get; set; }
    }
}
