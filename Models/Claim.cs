using System.Data;
using ContractMonthlyClaimSystem.Models;
using FluentValidation;

namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public int HoursWorked { get; set;}
        public double HourlyRate { get; set; }
        public string? AdditionalNotes { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public string? SupportingDocument { get; set; }
        public string? Status { get; set; }

    }

    public class ClaimValidator : AbstractValidator<Claim>
    {
        public ClaimValidator()
        {
            RuleFor(claim => claim.Id).NotEmpty();

            RuleFor(claim => claim.HourlyRate).GreaterThanOrEqualTo(0);
            RuleFor(claim => claim.HoursWorked).GreaterThanOrEqualTo(0);
            
        }
    }

}