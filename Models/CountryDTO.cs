using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelListing.Data;

namespace HotelListing.Models
{
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
    }

    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength:50, ErrorMessage = "Country name is too long")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(maximumLength:3, ErrorMessage = "Short Country name is too long")]
        public string ShortName { get; set; }
        public  IList<HotelDTO> Hotels {get; set;}
    }
    public class AddCountryDTO
    {
        [Required]
        [StringLength(maximumLength:50, ErrorMessage = "Country name is too long")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(maximumLength:3, ErrorMessage = "Short Country name is too long")]
        public string ShortName { get; set; }
    }
}