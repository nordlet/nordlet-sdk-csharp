using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DocumentsExtractCaptureResponseExtractionDocumentType.DocumentsExtractCaptureResponseExtractionDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct DocumentsExtractCaptureResponseExtractionDocumentType : IStringEnum
{
    public static readonly DocumentsExtractCaptureResponseExtractionDocumentType Invoice = new(
        Values.Invoice
    );

    public static readonly DocumentsExtractCaptureResponseExtractionDocumentType CreditNote = new(
        Values.CreditNote
    );

    public DocumentsExtractCaptureResponseExtractionDocumentType(string value)
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
    public static DocumentsExtractCaptureResponseExtractionDocumentType FromCustom(string value)
    {
        return new DocumentsExtractCaptureResponseExtractionDocumentType(value);
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
        DocumentsExtractCaptureResponseExtractionDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsExtractCaptureResponseExtractionDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsExtractCaptureResponseExtractionDocumentType value
    ) => value.Value;

    public static explicit operator DocumentsExtractCaptureResponseExtractionDocumentType(
        string value
    ) => new(value);

    internal class DocumentsExtractCaptureResponseExtractionDocumentTypeSerializer
        : JsonConverter<DocumentsExtractCaptureResponseExtractionDocumentType>
    {
        public override DocumentsExtractCaptureResponseExtractionDocumentType Read(
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
            return new DocumentsExtractCaptureResponseExtractionDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsExtractCaptureResponseExtractionDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsExtractCaptureResponseExtractionDocumentType ReadAsPropertyName(
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
            return new DocumentsExtractCaptureResponseExtractionDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsExtractCaptureResponseExtractionDocumentType value,
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
