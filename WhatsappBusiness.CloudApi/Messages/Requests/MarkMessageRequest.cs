﻿using System.Text.Json.Serialization;

namespace WhatsappBusiness.CloudApi.Messages.Requests
{
    public class MarkMessageRequest
    {
        [JsonPropertyName("messaging_product")]
        public string MessagingProduct { get; private set; } = "whatsapp";

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
    }
}
