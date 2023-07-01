using Microsoft.AspNetCore.Mvc;

namespace Highway.Gate.Microservice.Entities
{
    public class EntryRegistry
    {
        /// <summary>
        /// Database identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Licence plate of the car
        /// </summary>
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
