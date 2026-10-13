using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesGetSalesResponseDocumentType.InvoiceTemplatesGetSalesResponseDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesGetSalesResponseDocumentType : IStringEnum
{
    public static readonly InvoiceTemplatesGetSalesResponseDocumentType Invoice = new(
        Values.Invoice
    );

    public static readonly InvoiceTemplatesGetSalesResponseDocumentType CreditNote = new(
        Values.CreditNote
    );

    public InvoiceTemplatesGetSalesResponseDocumentType(string value)
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
    public static InvoiceTemplatesGetSalesResponseDocumentType FromCustom(string value)
    {
        return new InvoiceTemplatesGetSalesResponseDocumentType(value);
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
        InvoiceTemplatesGetSalesResponseDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesGetSalesResponseDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesGetSalesResponseDocumentType value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesGetSalesResponseDocumentType(string value) =>
        new(value);

    internal class InvoiceTemplatesGetSalesResponseDocumentTypeSerializer
        : JsonConverter<InvoiceTemplatesGetSalesResponseDocumentType>
    {
        public override InvoiceTemplatesGetSalesResponseDocumentType Read(
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
            return new InvoiceTemplatesGetSalesResponseDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesGetSalesResponseDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesGetSalesResponseDocumentType ReadAsPropertyName(
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
            return new InvoiceTemplatesGetSalesResponseDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesGetSalesResponseDocumentType value,
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
