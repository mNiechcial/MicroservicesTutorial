using System.ComponentModel.DataAnnotations;

namespace Highway.Ticket.Microservice.Entities
{
    public class TicketPayment
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
        /// Date the car was registered
        /// nullable for clock failure
        /// TODO: clock service
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Date the car was registered
        /// nullable for clock failure
        /// TODO: clock service
        /// </summary>
        [Required]
        public DateTime EndDate { get; set; }
    }
}
