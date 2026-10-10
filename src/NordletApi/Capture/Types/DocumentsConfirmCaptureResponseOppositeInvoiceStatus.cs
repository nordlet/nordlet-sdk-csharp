using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DocumentsConfirmCaptureResponseOppositeInvoiceStatus.DocumentsConfirmCaptureResponseOppositeInvoiceStatusSerializer)
)]
[Serializable]
public readonly record struct DocumentsConfirmCaptureResponseOppositeInvoiceStatus : IStringEnum
{
    public static readonly DocumentsConfirmCaptureResponseOppositeInvoiceStatus Draft = new(
        Values.Draft
    );

    public static readonly DocumentsConfirmCaptureResponseOppositeInvoiceStatus Registered = new(
        Values.Registered
    );

    public DocumentsConfirmCaptureResponseOppositeInvoiceStatus(string value)
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
    public static DocumentsConfirmCaptureResponseOppositeInvoiceStatus FromCustom(string value)
    {
        return new DocumentsConfirmCaptureResponseOppositeInvoiceStatus(value);
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
        DocumentsConfirmCaptureResponseOppositeInvoiceStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsConfirmCaptureResponseOppositeInvoiceStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsConfirmCaptureResponseOppositeInvoiceStatus value
    ) => value.Value;

    public static explicit operator DocumentsConfirmCaptureResponseOppositeInvoiceStatus(
        string value
    ) => new(value);

    internal class DocumentsConfirmCaptureResponseOppositeInvoiceStatusSerializer
        : JsonConverter<DocumentsConfirmCaptureResponseOppositeInvoiceStatus>
    {
        public override DocumentsConfirmCaptureResponseOppositeInvoiceStatus Read(
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
            return new DocumentsConfirmCaptureResponseOppositeInvoiceStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseOppositeInvoiceStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsConfirmCaptureResponseOppositeInvoiceStatus ReadAsPropertyName(
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
            return new DocumentsConfirmCaptureResponseOppositeInvoiceStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseOppositeInvoiceStatus value,
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
        public const string Draft = "draft";

        public const string Registered = "registered";
    }
}
