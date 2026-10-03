using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsPlKsefReceiptResponseState.PostV1DeclarationsPlKsefReceiptResponseStateSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsPlKsefReceiptResponseState : IStringEnum
{
    public static readonly PostV1DeclarationsPlKsefReceiptResponseState Sent = new(Values.Sent);

    public static readonly PostV1DeclarationsPlKsefReceiptResponseState Accepted = new(
        Values.Accepted
    );

    public static readonly PostV1DeclarationsPlKsefReceiptResponseState Rejected = new(
        Values.Rejected
    );

    public PostV1DeclarationsPlKsefReceiptResponseState(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static PostV1DeclarationsPlKsefReceiptResponseState FromCustom(string value)
    {
        return new PostV1DeclarationsPlKsefReceiptResponseState(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(
        PostV1DeclarationsPlKsefReceiptResponseState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsPlKsefReceiptResponseState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsPlKsefReceiptResponseState value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsPlKsefReceiptResponseState(string value) =>
        new(value);

    internal class PostV1DeclarationsPlKsefReceiptResponseStateSerializer
        : JsonConverter<PostV1DeclarationsPlKsefReceiptResponseState>
    {
        public override PostV1DeclarationsPlKsefReceiptResponseState Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new PostV1DeclarationsPlKsefReceiptResponseState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsPlKsefReceiptResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsPlKsefReceiptResponseState ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new PostV1DeclarationsPlKsefReceiptResponseState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsPlKsefReceiptResponseState value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Sent = "sent";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
