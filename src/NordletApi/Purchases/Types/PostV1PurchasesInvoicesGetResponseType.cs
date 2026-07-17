using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesInvoicesGetResponseType.PostV1PurchasesInvoicesGetResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesInvoicesGetResponseType : IStringEnum
{
    public static readonly PostV1PurchasesInvoicesGetResponseType Invoice = new(Values.Invoice);

    public static readonly PostV1PurchasesInvoicesGetResponseType CreditNote = new(
        Values.CreditNote
    );

    public PostV1PurchasesInvoicesGetResponseType(string value)
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
    public static PostV1PurchasesInvoicesGetResponseType FromCustom(string value)
    {
        return new PostV1PurchasesInvoicesGetResponseType(value);
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

    public static bool operator ==(PostV1PurchasesInvoicesGetResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1PurchasesInvoicesGetResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesInvoicesGetResponseType value) =>
        value.Value;

    public static explicit operator PostV1PurchasesInvoicesGetResponseType(string value) =>
        new(value);

    internal class PostV1PurchasesInvoicesGetResponseTypeSerializer
        : JsonConverter<PostV1PurchasesInvoicesGetResponseType>
    {
        public override PostV1PurchasesInvoicesGetResponseType Read(
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
            return new PostV1PurchasesInvoicesGetResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesGetResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesInvoicesGetResponseType ReadAsPropertyName(
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
            return new PostV1PurchasesInvoicesGetResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesInvoicesGetResponseType value,
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
        public const string Invoice = "invoice";

        public const string CreditNote = "credit_note";
    }
}
