using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankFeedsConnectionsStartRequestPsuType.PostV1BankFeedsConnectionsStartRequestPsuTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankFeedsConnectionsStartRequestPsuType : IStringEnum
{
    public static readonly PostV1BankFeedsConnectionsStartRequestPsuType Business = new(
        Values.Business
    );

    public static readonly PostV1BankFeedsConnectionsStartRequestPsuType Personal = new(
        Values.Personal
    );

    public PostV1BankFeedsConnectionsStartRequestPsuType(string value)
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
    public static PostV1BankFeedsConnectionsStartRequestPsuType FromCustom(string value)
    {
        return new PostV1BankFeedsConnectionsStartRequestPsuType(value);
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
        PostV1BankFeedsConnectionsStartRequestPsuType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankFeedsConnectionsStartRequestPsuType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankFeedsConnectionsStartRequestPsuType value) =>
        value.Value;

    public static explicit operator PostV1BankFeedsConnectionsStartRequestPsuType(string value) =>
        new(value);

    internal class PostV1BankFeedsConnectionsStartRequestPsuTypeSerializer
        : JsonConverter<PostV1BankFeedsConnectionsStartRequestPsuType>
    {
        public override PostV1BankFeedsConnectionsStartRequestPsuType Read(
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
            return new PostV1BankFeedsConnectionsStartRequestPsuType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsStartRequestPsuType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankFeedsConnectionsStartRequestPsuType ReadAsPropertyName(
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
            return new PostV1BankFeedsConnectionsStartRequestPsuType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankFeedsConnectionsStartRequestPsuType value,
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
