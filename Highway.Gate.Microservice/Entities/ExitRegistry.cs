using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Highway.Gate.Microservice.Entities
{
    public class ExitRegistry
    {
        /// <summary>
        /// Database identifier
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Licence plate of the car
        /// </summary>
        [Required]
        public string LicencePlate { get; set; }

        /// <summary>
        /// Precentage value how sure is the program that the license plate is correct
        /// </summary>
        public int LicencePlateCorrectness { get; set; }

        /// <summary>
        /// Date the car was registered
        /// nullable for clock failure
        /// TODO: clock service
        /// </summary>
        public DateTime? RegistryDate { get; set; }
    }
}
