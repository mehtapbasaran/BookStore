using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Models.DbModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "You must enter at least 3 and at most 250 characters long.")]
        public string CategoryName { get; set; }
    }
}
