using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Week7CodeChallenge.Models
{
    [MetadataType(typeof(ContactValidation))]
    public partial class AJAX_ContactForm
    {

    }
    public class ContactValidation
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string PhoneNum { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ProjDescription { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string Comment { get; set; }

        public string GetName()
        {
            return String.Concat("{0} {1}", FirstName, LastName);
        }
    }
}