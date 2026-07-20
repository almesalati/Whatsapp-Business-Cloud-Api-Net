using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WhatsappBusiness.CloudApi.Response
{
	public class InAppSignUpResponse
	{
		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("waba_id")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string WabaId { get; set; }

		[JsonPropertyName("signup_message")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string SignupMessage { get; set; }

		[JsonPropertyName("confirmation_message")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string ConfirmationMessage { get; set; }

		[JsonPropertyName("privacy_policy_url")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PrivacyPolicyUrl { get; set; }

		[JsonPropertyName("promo_code")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PromoCode { get; set; }

		[JsonPropertyName("status")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string Status { get; set; }

		[JsonPropertyName("display_name")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string DisplayName { get; set; }

		[JsonPropertyName("website_url")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string WebsiteUrl { get; set; }

		[JsonPropertyName("data")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public List<InAppSignUpData> Data { get; set; }

		[JsonPropertyName("paging")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public InAppSignUpPaging Paging { get; set; }
	}

	public class InAppSignUpData
	{
		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("signup_message")]
		public string SignupMessage { get; set; }

		[JsonPropertyName("status")]
		public string Status { get; set; }
	}

	public class InAppSignUpPaging
	{
		[JsonPropertyName("cursors")]
		public InAppSignUpCursors Cursors { get; set; }

		[JsonPropertyName("next")]
		public string Next { get; set; }
	}

	public class InAppSignUpCursors
	{
		[JsonPropertyName("before")]
		public string Before { get; set; }

		[JsonPropertyName("after")]
		public string After { get; set; }
	}
}
