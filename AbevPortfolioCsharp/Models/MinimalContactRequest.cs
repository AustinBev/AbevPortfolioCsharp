using System.ComponentModel.DataAnnotations;

namespace AbevPortfolioCsharp.Models
{
    public class MinimalContactRequest
    {
        [Required, StringLength(80)] public string Name { get; set; } = "";
        [Required, EmailAddress, StringLength(120)] public string Email { get; set; } = "";
        // Proof link: LinkedIn/GitHub/company/JD
        [Required, Url, StringLength(300)] public string VerificationUrl { get; set; } = "";
        [StringLength(500)] public string? Message { get; set; }

        // Anti-abuse
        public string? Hp { get; set; }
        public int SecondsToSubmit { get; set; }
        public string? TurnstileToken { get; set; }
    }
}
