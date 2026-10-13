using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesCreateSalesResponseDocumentType.InvoiceTemplatesCreateSalesResponseDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesCreateSalesResponseDocumentType : IStringEnum
{
    public static readonly InvoiceTemplatesCreateSalesResponseDocumentType Invoice = new(
        Values.Invoice
    );

    public static readonly InvoiceTemplatesCreateSalesResponseDocumentType CreditNote = new(
        Values.CreditNote
    );

    public InvoiceTemplatesCreateSalesResponseDocumentType(string value)
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
    public static InvoiceTemplatesCreateSalesResponseDocumentType FromCustom(string value)
    {
        return new InvoiceTemplatesCreateSalesResponseDocumentType(value);
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
        InvoiceTemplatesCreateSalesResponseDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesCreateSalesResponseDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesCreateSalesResponseDocumentType value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesCreateSalesResponseDocumentType(string value) =>
        new(value);

    internal class InvoiceTemplatesCreateSalesResponseDocumentTypeSerializer
        : JsonConverter<InvoiceTemplatesCreateSalesResponseDocumentType>
    {
        public override InvoiceTemplatesCreateSalesResponseDocumentType Read(
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
            return new InvoiceTemplatesCreateSalesResponseDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesCreateSalesResponseDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesCreateSalesResponseDocumentType ReadAsPropertyName(
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
            return new InvoiceTemplatesCreateSalesResponseDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesCreateSalesResponseDocumentType value,
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
