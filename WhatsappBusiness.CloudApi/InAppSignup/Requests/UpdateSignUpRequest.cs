using System.Text.Json.Serialization;

namespace WhatsappBusiness.CloudApi.InAppSignup.Requests
{
	public class UpdateSignUpRequest
	{
		[JsonPropertyName("status")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string Status { get; set; }

		[JsonPropertyName("signup_message")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string SignupMessage { get; set; }

		[JsonPropertyName("confirmation_message")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string ConfirmationMessage { get; set; }

		[JsonPropertyName("promo_code")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PromoCode { get; set; }

		[JsonPropertyName("display_name")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string DisplayName { get; set; }

		[JsonPropertyName("website_url")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string WebsiteUrl { get; set; }
	}
}
