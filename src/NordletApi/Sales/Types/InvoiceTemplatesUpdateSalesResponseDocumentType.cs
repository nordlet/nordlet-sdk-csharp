using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesUpdateSalesResponseDocumentType.InvoiceTemplatesUpdateSalesResponseDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesUpdateSalesResponseDocumentType : IStringEnum
{
    public static readonly InvoiceTemplatesUpdateSalesResponseDocumentType Invoice = new(
        Values.Invoice
    );

    public static readonly InvoiceTemplatesUpdateSalesResponseDocumentType CreditNote = new(
        Values.CreditNote
    );

    public InvoiceTemplatesUpdateSalesResponseDocumentType(string value)
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
    public static InvoiceTemplatesUpdateSalesResponseDocumentType FromCustom(string value)
    {
        return new InvoiceTemplatesUpdateSalesResponseDocumentType(value);
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
        InvoiceTemplatesUpdateSalesResponseDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesUpdateSalesResponseDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesUpdateSalesResponseDocumentType value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesUpdateSalesResponseDocumentType(string value) =>
        new(value);

    internal class InvoiceTemplatesUpdateSalesResponseDocumentTypeSerializer
        : JsonConverter<InvoiceTemplatesUpdateSalesResponseDocumentType>
    {
        public override InvoiceTemplatesUpdateSalesResponseDocumentType Read(
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
            return new InvoiceTemplatesUpdateSalesResponseDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesUpdateSalesResponseDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesUpdateSalesResponseDocumentType ReadAsPropertyName(
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
            return new InvoiceTemplatesUpdateSalesResponseDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesUpdateSalesResponseDocumentType value,
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
