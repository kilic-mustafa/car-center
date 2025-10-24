using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace CarCenter.Models
{
    public class CarModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "Model is required")]
        [StringLength(100, ErrorMessage = "Model cannot exceed 100 characters")]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Kilometers is required")]
        [Range(0, 1000000, ErrorMessage = "Kilometers must be between 0 and 1,000,000")]
        public decimal Kilometers { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
    
        [Required(ErrorMessage = "Colour is required")]
        public string Colour { get; set; } = string.Empty;

        [Display(Name = "Fuel Type")]
        [Required(ErrorMessage = "Fuel type is required")]
        public string FuelType { get; set; } = string.Empty;

        [Display(Name = "Gear Type")]
        [Required(ErrorMessage = "Gear type is required")]
        public string GearType { get; set; } = string.Empty;

        [Display(Name = "Engine Power")]
        [Required(ErrorMessage = "Engine Power is required")]
        [Range(0, 113000, ErrorMessage = "Engine Power must be between 0 and 113,000")]
        public int EnginePower { get; set; } 
        
        [Display(Name = "Engine Displacement")]
        [Required(ErrorMessage = "EngineDisplacement is required")]
        [Range(0, 10000, ErrorMessage = "Engine Displacement must be between 0 and 10,000")]
        public int EngineDisplacement { get; set; } 
        
        [Required(ErrorMessage = "Traction is required")]
        public string Traction { get; set; } = string.Empty;

        [Display(Name = "Vehicle Type")]
        [Required(ErrorMessage = "Vehicle Type is required")]
        public string VehicleType { get; set; } = string.Empty;

        [Display(Name = "Number of Doors")]
        [Required(ErrorMessage = "Number of Doors is required")]
        public int NumberOfDoors { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Registration Date")]
        public DateTime? RegistrationDate { get; set; }
    }
}