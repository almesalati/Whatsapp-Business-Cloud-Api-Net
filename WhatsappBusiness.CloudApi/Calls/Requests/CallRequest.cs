using System.Text.Json.Serialization;

namespace WhatsappBusiness.CloudApi.Calls.Requests
{
	public class CallRequest
	{
		[JsonPropertyName("messaging_product")]
		[JsonInclude]
		public string MessagingProduct { get; private set; } = "whatsapp";

		[JsonPropertyName("to")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string To { get; set; }

		[JsonPropertyName("recipient")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string Recipient { get; set; }

		[JsonPropertyName("call_id")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string CallId { get; set; }

		[JsonPropertyName("action")]
		public string Action { get; set; }

		[JsonPropertyName("session")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public CallSession Session { get; set; }

		[JsonPropertyName("recording")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public CallRecording Recording { get; set; }

		[JsonPropertyName("transcription")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public CallTranscription Transcription { get; set; }

		[JsonPropertyName("biz_opaque_callback_data")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string BizOpaqueCallbackData { get; set; }
	}

	public class CallSession
	{
		[JsonPropertyName("sdp_type")]
		[JsonInclude]
		public string SdpType { get; private set; } = "offer";

		[JsonPropertyName("sdp")]
		public string Sdp { get; set; }
	}

	public class CallRecording
	{
		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("purpose")]
		public string Purpose { get; set; }

		[JsonPropertyName("announcement_language")]
		public string AnnouncementLanguage { get; set; }
	}

	public class CallTranscription
	{
		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("purpose")]
		public string Purpose { get; set; }

		[JsonPropertyName("announcement_language")]
		public string AnnouncementLanguage { get; set; }
	}
}
