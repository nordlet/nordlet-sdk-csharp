using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DocumentsConfirmCaptureResponseCaptureExtractionDocumentType.DocumentsConfirmCaptureResponseCaptureExtractionDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct DocumentsConfirmCaptureResponseCaptureExtractionDocumentType
    : IStringEnum
{
    public static readonly DocumentsConfirmCaptureResponseCaptureExtractionDocumentType Invoice =
        new(Values.Invoice);

    public static readonly DocumentsConfirmCaptureResponseCaptureExtractionDocumentType CreditNote =
        new(Values.CreditNote);

    public DocumentsConfirmCaptureResponseCaptureExtractionDocumentType(string value)
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
    public static DocumentsConfirmCaptureResponseCaptureExtractionDocumentType FromCustom(
        string value
    )
    {
        return new DocumentsConfirmCaptureResponseCaptureExtractionDocumentType(value);
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
        DocumentsConfirmCaptureResponseCaptureExtractionDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsConfirmCaptureResponseCaptureExtractionDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsConfirmCaptureResponseCaptureExtractionDocumentType value
    ) => value.Value;

    public static explicit operator DocumentsConfirmCaptureResponseCaptureExtractionDocumentType(
        string value
    ) => new(value);

    internal class DocumentsConfirmCaptureResponseCaptureExtractionDocumentTypeSerializer
        : JsonConverter<DocumentsConfirmCaptureResponseCaptureExtractionDocumentType>
    {
        public override DocumentsConfirmCaptureResponseCaptureExtractionDocumentType Read(
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
            return new DocumentsConfirmCaptureResponseCaptureExtractionDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseCaptureExtractionDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsConfirmCaptureResponseCaptureExtractionDocumentType ReadAsPropertyName(
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
            return new DocumentsConfirmCaptureResponseCaptureExtractionDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseCaptureExtractionDocumentType value,
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
