using System.Text.Json.Serialization;

namespace WhatsappBusiness.CloudApi.Messages.Requests
{
	public class DirectSendMessageRequest
	{
		[JsonPropertyName("messaging_product")]
		[JsonInclude]
		public string MessagingProduct { get; private set; } = "whatsapp";

		[JsonPropertyName("recipient_type")]
		[JsonInclude]
		public string RecipientType { get; private set; } = "individual";

		[JsonPropertyName("to")]
		public string To { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("text")]
		public DirectSendMessageText Text { get; set; }

		[JsonPropertyName("category")]
		public string Category { get; set; }
	}

	public class DirectSendMessageText
	{
		[JsonPropertyName("body")]
		public string Body { get; set; }
	}
}
