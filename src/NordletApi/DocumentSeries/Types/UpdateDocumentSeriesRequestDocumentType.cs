using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdateDocumentSeriesRequestDocumentType.UpdateDocumentSeriesRequestDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct UpdateDocumentSeriesRequestDocumentType : IStringEnum
{
    public static readonly UpdateDocumentSeriesRequestDocumentType SaleInvoice = new(
        Values.SaleInvoice
    );

    public static readonly UpdateDocumentSeriesRequestDocumentType SaleCreditNote = new(
        Values.SaleCreditNote
    );

    public static readonly UpdateDocumentSeriesRequestDocumentType SaleProforma = new(
        Values.SaleProforma
    );

    public static readonly UpdateDocumentSeriesRequestDocumentType SaleAdvance = new(
        Values.SaleAdvance
    );

    public UpdateDocumentSeriesRequestDocumentType(string value)
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
    public static UpdateDocumentSeriesRequestDocumentType FromCustom(string value)
    {
        return new UpdateDocumentSeriesRequestDocumentType(value);
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

    public static bool operator ==(UpdateDocumentSeriesRequestDocumentType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateDocumentSeriesRequestDocumentType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateDocumentSeriesRequestDocumentType value) =>
        value.Value;

    public static explicit operator UpdateDocumentSeriesRequestDocumentType(string value) =>
        new(value);

    internal class UpdateDocumentSeriesRequestDocumentTypeSerializer
        : JsonConverter<UpdateDocumentSeriesRequestDocumentType>
    {
        public override UpdateDocumentSeriesRequestDocumentType Read(
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
            return new UpdateDocumentSeriesRequestDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateDocumentSeriesRequestDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateDocumentSeriesRequestDocumentType ReadAsPropertyName(
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
            return new UpdateDocumentSeriesRequestDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateDocumentSeriesRequestDocumentType value,
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
