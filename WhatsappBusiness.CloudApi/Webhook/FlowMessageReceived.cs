﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WhatsappBusiness.CloudApi.Webhook
{
	public class FlowMessageReceived
	{
		[JsonPropertyName("messages")]
		public List<FlowMessage> Messages { get; set; }
	}

	public class FlowMessage
	{
		[JsonPropertyName("context")]
		public FlowContext Context { get; set; }

		[JsonPropertyName("from")]
		public string From { get; set; }

		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("interactive")]
		public FlowInteractive Interactive { get; set; }

		[JsonPropertyName("timestamp")]
		public string Timestamp { get; set; }
	}

	public class FlowContext
	{
		[JsonPropertyName("from")]
		public string From { get; set; }

		[JsonPropertyName("id")]
		public string Id { get; set; }
	}

	public class FlowInteractive
	{
		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("nfm_reply")]
		public NfmReply NfmReply { get; set; }
	}

	public partial class NfmReply
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("body")]
		public string Body { get; set; }

		[JsonPropertyName("response_json")]
		public string ResponseJson { get; set; }
	}
}
