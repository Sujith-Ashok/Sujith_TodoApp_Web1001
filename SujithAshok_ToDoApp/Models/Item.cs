using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SujithAshok_ToDoApp.Models
{
    public class Item
    {
        [Key]
        [HiddenInput]
        public int itemID { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please enter valid email address.")]
        [Display(Name = "Email Address")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Please enter title.")]
        [MinLength(2, ErrorMessage = "Title should be atleast 2 characters.")]
        [MaxLength(50, ErrorMessage = "This field takes only maximum of 50 characters.")]
        public string Title { get; set; }

        [MinLength(10, ErrorMessage = "Description should be atleast 10 characters.")]
        [MaxLength(1000, ErrorMessage = "This field takes only maximum of 1000 characters.")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        public bool Done { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Done Date")]
        public DateTime? DoneDate { get; set; }
    }
}
