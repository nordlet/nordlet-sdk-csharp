using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankImportTemplatesCreateRequestType.PostV1BankImportTemplatesCreateRequestTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankImportTemplatesCreateRequestType : IStringEnum
{
    public static readonly PostV1BankImportTemplatesCreateRequestType Stripe = new(Values.Stripe);

    public static readonly PostV1BankImportTemplatesCreateRequestType Iso20022 = new(
        Values.Iso20022
    );

    public static readonly PostV1BankImportTemplatesCreateRequestType BankConnection = new(
        Values.BankConnection
    );

    public PostV1BankImportTemplatesCreateRequestType(string value)
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
    public static PostV1BankImportTemplatesCreateRequestType FromCustom(string value)
    {
        return new PostV1BankImportTemplatesCreateRequestType(value);
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
        PostV1BankImportTemplatesCreateRequestType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankImportTemplatesCreateRequestType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankImportTemplatesCreateRequestType value) =>
        value.Value;

    public static explicit operator PostV1BankImportTemplatesCreateRequestType(string value) =>
        new(value);

    internal class PostV1BankImportTemplatesCreateRequestTypeSerializer
        : JsonConverter<PostV1BankImportTemplatesCreateRequestType>
    {
        public override PostV1BankImportTemplatesCreateRequestType Read(
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
            return new PostV1BankImportTemplatesCreateRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankImportTemplatesCreateRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankImportTemplatesCreateRequestType ReadAsPropertyName(
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
            return new PostV1BankImportTemplatesCreateRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankImportTemplatesCreateRequestType value,
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
        public const string Stripe = "stripe";

        public const string Iso20022 = "iso20022";

        public const string BankConnection = "bank_connection";
    }
}
