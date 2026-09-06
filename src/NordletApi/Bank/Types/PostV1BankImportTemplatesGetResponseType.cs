using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankImportTemplatesGetResponseType.PostV1BankImportTemplatesGetResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankImportTemplatesGetResponseType : IStringEnum
{
    public static readonly PostV1BankImportTemplatesGetResponseType Stripe = new(Values.Stripe);

    public static readonly PostV1BankImportTemplatesGetResponseType Iso20022 = new(Values.Iso20022);

    public static readonly PostV1BankImportTemplatesGetResponseType BankConnection = new(
        Values.BankConnection
    );

    public PostV1BankImportTemplatesGetResponseType(string value)
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
    public static PostV1BankImportTemplatesGetResponseType FromCustom(string value)
    {
        return new PostV1BankImportTemplatesGetResponseType(value);
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
        PostV1BankImportTemplatesGetResponseType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankImportTemplatesGetResponseType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankImportTemplatesGetResponseType value) =>
        value.Value;

    public static explicit operator PostV1BankImportTemplatesGetResponseType(string value) =>
        new(value);

    internal class PostV1BankImportTemplatesGetResponseTypeSerializer
        : JsonConverter<PostV1BankImportTemplatesGetResponseType>
    {
        public override PostV1BankImportTemplatesGetResponseType Read(
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
            return new PostV1BankImportTemplatesGetResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankImportTemplatesGetResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankImportTemplatesGetResponseType ReadAsPropertyName(
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
            return new PostV1BankImportTemplatesGetResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankImportTemplatesGetResponseType value,
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
