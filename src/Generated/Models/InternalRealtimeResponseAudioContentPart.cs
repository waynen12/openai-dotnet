// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseAudioContentPart : ConversationContentPart
    {
        internal InternalRealtimeResponseAudioContentPart(string internalTranscriptValue)
        {
            Kind = ConversationContentPartKind.OutputAudio;
            InternalTranscriptValue = internalTranscriptValue;
        }

        internal InternalRealtimeResponseAudioContentPart(ConversationContentPartKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string type, string internalTranscriptValue) : base(kind, serializedAdditionalRawData)
        {
            Type = type;
            InternalTranscriptValue = internalTranscriptValue;
        }

        internal InternalRealtimeResponseAudioContentPart()
        {
        }

        internal string Type { get; set; } = "audio";
    }
}