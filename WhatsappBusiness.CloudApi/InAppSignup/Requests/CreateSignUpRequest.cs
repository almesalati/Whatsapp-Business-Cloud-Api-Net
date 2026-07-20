using System.Text.Json.Serialization;

namespace WhatsappBusiness.CloudApi.InAppSignup.Requests
{
	public class CreateSignUpRequest
	{
		[JsonPropertyName("signup_message")]
		public string SignupMessage { get; set; }

		[JsonPropertyName("confirmation_message")]
		public string ConfirmationMessage { get; set; }

		[JsonPropertyName("privacy_policy_url")]
		public string PrivacyPolicyUrl { get; set; }

		[JsonPropertyName("website_url")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string WebsiteUrl { get; set; }

		[JsonPropertyName("promo_code")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PromoCode { get; set; }

		[JsonPropertyName("display_name")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string DisplayName { get; set; }

		[JsonPropertyName("policy")]
		public InAppSignUpPolicy Policy { get; set; }
	}

	public class InAppSignUpPolicy
	{
		[JsonPropertyName("tos")]
		public string Tos { get; set; }

		[JsonPropertyName("accepted")]
		public bool Accepted { get; set; }
	}
}
