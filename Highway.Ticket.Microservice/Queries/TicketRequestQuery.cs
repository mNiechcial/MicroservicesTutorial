namespace Highway.Ticket.Microservice.Queries
{
    public class TicketRequestQuery
    {
        public DateTime DateIssued { get; set; }
    }

    public class TicketRequestQueryResult
    {
        public IList<string> LicensePlates { get; set; }
    }
}
