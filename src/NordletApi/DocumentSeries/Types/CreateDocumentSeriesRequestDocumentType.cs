using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreateDocumentSeriesRequestDocumentType.CreateDocumentSeriesRequestDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct CreateDocumentSeriesRequestDocumentType : IStringEnum
{
    public static readonly CreateDocumentSeriesRequestDocumentType SaleInvoice = new(
        Values.SaleInvoice
    );

    public static readonly CreateDocumentSeriesRequestDocumentType SaleCreditNote = new(
        Values.SaleCreditNote
    );

    public static readonly CreateDocumentSeriesRequestDocumentType SaleProforma = new(
        Values.SaleProforma
    );

    public static readonly CreateDocumentSeriesRequestDocumentType SaleAdvance = new(
        Values.SaleAdvance
    );

    public CreateDocumentSeriesRequestDocumentType(string value)
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
    public static CreateDocumentSeriesRequestDocumentType FromCustom(string value)
    {
        return new CreateDocumentSeriesRequestDocumentType(value);
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

    public static bool operator ==(CreateDocumentSeriesRequestDocumentType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateDocumentSeriesRequestDocumentType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateDocumentSeriesRequestDocumentType value) =>
        value.Value;

    public static explicit operator CreateDocumentSeriesRequestDocumentType(string value) =>
        new(value);

    internal class CreateDocumentSeriesRequestDocumentTypeSerializer
        : JsonConverter<CreateDocumentSeriesRequestDocumentType>
    {
        public override CreateDocumentSeriesRequestDocumentType Read(
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
            return new CreateDocumentSeriesRequestDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateDocumentSeriesRequestDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateDocumentSeriesRequestDocumentType ReadAsPropertyName(
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
            return new CreateDocumentSeriesRequestDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateDocumentSeriesRequestDocumentType value,
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
        public const string SaleInvoice = "sale_invoice";

        public const string SaleCreditNote = "sale_credit_note";

        public const string SaleProforma = "sale_proforma";

        public const string SaleAdvance = "sale_advance";
    }
}
