using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Org.BouncyCastle.Crypto.Agreement;

namespace WebApplicationAbad.Areas.Setting.Data
{
    public class PrivacyModel
    {
        public int Id { get; set; }

       public string?  TermsofService { get; set; }
       public string? PrivacyPolicy { get; set; }
       public string? IntellectualPropertyPolicy { get; set; }
       public string? MainServicesAgreement { get; set; }
       public string? PromotionsPolicy { get; set; }

    }
}
