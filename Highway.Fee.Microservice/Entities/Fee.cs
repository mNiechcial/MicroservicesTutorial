using System.ComponentModel.DataAnnotations;

namespace Highway.Fee.Microservice.Entities
{
    public class FeeIssued
    {
        [Key]
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
