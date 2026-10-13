using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesUpdateSalesRequestDocumentType.InvoiceTemplatesUpdateSalesRequestDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesUpdateSalesRequestDocumentType : IStringEnum
{
    public static readonly InvoiceTemplatesUpdateSalesRequestDocumentType Invoice = new(
        Values.Invoice
    );

    public static readonly InvoiceTemplatesUpdateSalesRequestDocumentType CreditNote = new(
        Values.CreditNote
    );

    public InvoiceTemplatesUpdateSalesRequestDocumentType(string value)
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
    public static InvoiceTemplatesUpdateSalesRequestDocumentType FromCustom(string value)
    {
        return new InvoiceTemplatesUpdateSalesRequestDocumentType(value);
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
        InvoiceTemplatesUpdateSalesRequestDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesUpdateSalesRequestDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesUpdateSalesRequestDocumentType value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesUpdateSalesRequestDocumentType(string value) =>
        new(value);

    internal class InvoiceTemplatesUpdateSalesRequestDocumentTypeSerializer
        : JsonConverter<InvoiceTemplatesUpdateSalesRequestDocumentType>
    {
        public override InvoiceTemplatesUpdateSalesRequestDocumentType Read(
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
            return new InvoiceTemplatesUpdateSalesRequestDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesUpdateSalesRequestDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesUpdateSalesRequestDocumentType ReadAsPropertyName(
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
            return new InvoiceTemplatesUpdateSalesRequestDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesUpdateSalesRequestDocumentType value,
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
