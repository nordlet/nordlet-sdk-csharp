using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsConnectionsCompleteResponsePsuType.PostV1BankFeedsConnectionsCompleteResponsePsuTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsConnectionsCompleteResponsePsuType : IStringEnum
{
    public static readonly PostV1BankFeedsConnectionsCompleteResponsePsuType Business = new(
        Values.Business
    );

    public static readonly PostV1BankFeedsConnectionsCompleteResponsePsuType Personal = new(
        Values.Personal
    );

    public PostV1BankFeedsConnectionsCompleteResponsePsuType(string value)
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
    public static PostV1BankFeedsConnectionsCompleteResponsePsuType FromCustom(string value)
    {
        return new PostV1BankFeedsConnectionsCompleteResponsePsuType(value);
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
        PostV1BankFeedsConnectionsCompleteResponsePsuType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsConnectionsCompleteResponsePsuType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankFeedsConnectionsCompleteResponsePsuType value
    ) => value.Value;

    public static explicit operator PostV1BankFeedsConnectionsCompleteResponsePsuType(
        string value
    ) => new(value);

    internal class PostV1BankFeedsConnectionsCompleteResponsePsuTypeSerializer
        : JsonConverter<PostV1BankFeedsConnectionsCompleteResponsePsuType>
    {
        public override PostV1BankFeedsConnectionsCompleteResponsePsuType Read(
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
            return new PostV1BankFeedsConnectionsCompleteResponsePsuType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsCompleteResponsePsuType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsConnectionsCompleteResponsePsuType ReadAsPropertyName(
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
            return new PostV1BankFeedsConnectionsCompleteResponsePsuType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsCompleteResponsePsuType value,
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
        public const string Business = "business";

        public const string Personal = "personal";
    }
}
