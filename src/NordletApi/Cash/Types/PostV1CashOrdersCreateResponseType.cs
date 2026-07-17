using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CashOrdersCreateResponseType.PostV1CashOrdersCreateResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1CashOrdersCreateResponseType : IStringEnum
{
    public static readonly PostV1CashOrdersCreateResponseType Receipt = new(Values.Receipt);

    public static readonly PostV1CashOrdersCreateResponseType Disbursement = new(
        Values.Disbursement
    );

    public PostV1CashOrdersCreateResponseType(string value)
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
    public static PostV1CashOrdersCreateResponseType FromCustom(string value)
    {
        return new PostV1CashOrdersCreateResponseType(value);
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

    public static bool operator ==(PostV1CashOrdersCreateResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1CashOrdersCreateResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CashOrdersCreateResponseType value) => value.Value;

    public static explicit operator PostV1CashOrdersCreateResponseType(string value) => new(value);

    internal class PostV1CashOrdersCreateResponseTypeSerializer
        : JsonConverter<PostV1CashOrdersCreateResponseType>
    {
        public override PostV1CashOrdersCreateResponseType Read(
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
            return new PostV1CashOrdersCreateResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CashOrdersCreateResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CashOrdersCreateResponseType ReadAsPropertyName(
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
            return new PostV1CashOrdersCreateResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CashOrdersCreateResponseType value,
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
        public const string Receipt = "receipt";

        public const string Disbursement = "disbursement";
    }
}
