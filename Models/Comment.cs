namespace HotelBooking_Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    
    public partial class Comment
    {
        public int Id { get; set; }

        [Required]
        [AllowHtml]
        public string CONTENTS { get; set; }
    }
}
