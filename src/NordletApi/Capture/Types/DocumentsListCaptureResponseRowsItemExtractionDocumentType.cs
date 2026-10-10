using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DocumentsListCaptureResponseRowsItemExtractionDocumentType.DocumentsListCaptureResponseRowsItemExtractionDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct DocumentsListCaptureResponseRowsItemExtractionDocumentType
    : IStringEnum
{
    public static readonly DocumentsListCaptureResponseRowsItemExtractionDocumentType Invoice = new(
        Values.Invoice
    );

    public static readonly DocumentsListCaptureResponseRowsItemExtractionDocumentType CreditNote =
        new(Values.CreditNote);

    public DocumentsListCaptureResponseRowsItemExtractionDocumentType(string value)
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
    public static DocumentsListCaptureResponseRowsItemExtractionDocumentType FromCustom(
        string value
    )
    {
        return new DocumentsListCaptureResponseRowsItemExtractionDocumentType(value);
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
        DocumentsListCaptureResponseRowsItemExtractionDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsListCaptureResponseRowsItemExtractionDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsListCaptureResponseRowsItemExtractionDocumentType value
    ) => value.Value;

    public static explicit operator DocumentsListCaptureResponseRowsItemExtractionDocumentType(
        string value
    ) => new(value);

    internal class DocumentsListCaptureResponseRowsItemExtractionDocumentTypeSerializer
        : JsonConverter<DocumentsListCaptureResponseRowsItemExtractionDocumentType>
    {
        public override DocumentsListCaptureResponseRowsItemExtractionDocumentType Read(
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
            return new DocumentsListCaptureResponseRowsItemExtractionDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsListCaptureResponseRowsItemExtractionDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsListCaptureResponseRowsItemExtractionDocumentType ReadAsPropertyName(
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
            return new DocumentsListCaptureResponseRowsItemExtractionDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsListCaptureResponseRowsItemExtractionDocumentType value,
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
