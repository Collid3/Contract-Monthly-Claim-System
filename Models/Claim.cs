namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public int HoursWorked { get; set;}
        public double HourlyRate { get; set; }
        public string? AdditionalNotes { get; set; }
        public string? SubmissionDate { get; set; }
        public string? SupportingDocument { get; set; }
        public string? Status { get; set; }

    }

}