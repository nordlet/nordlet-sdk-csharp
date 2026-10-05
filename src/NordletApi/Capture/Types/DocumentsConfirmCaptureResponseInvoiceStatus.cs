using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DocumentsConfirmCaptureResponseInvoiceStatus.DocumentsConfirmCaptureResponseInvoiceStatusSerializer)
)]
[Serializable]
public readonly record struct DocumentsConfirmCaptureResponseInvoiceStatus : IStringEnum
{
    public static readonly DocumentsConfirmCaptureResponseInvoiceStatus Draft = new(Values.Draft);

    public static readonly DocumentsConfirmCaptureResponseInvoiceStatus Registered = new(
        Values.Registered
    );

    public DocumentsConfirmCaptureResponseInvoiceStatus(string value)
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
    public static DocumentsConfirmCaptureResponseInvoiceStatus FromCustom(string value)
    {
        return new DocumentsConfirmCaptureResponseInvoiceStatus(value);
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
        DocumentsConfirmCaptureResponseInvoiceStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsConfirmCaptureResponseInvoiceStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsConfirmCaptureResponseInvoiceStatus value) =>
        value.Value;

    public static explicit operator DocumentsConfirmCaptureResponseInvoiceStatus(string value) =>
        new(value);

    internal class DocumentsConfirmCaptureResponseInvoiceStatusSerializer
        : JsonConverter<DocumentsConfirmCaptureResponseInvoiceStatus>
    {
        public override DocumentsConfirmCaptureResponseInvoiceStatus Read(
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
            return new DocumentsConfirmCaptureResponseInvoiceStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseInvoiceStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsConfirmCaptureResponseInvoiceStatus ReadAsPropertyName(
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
            return new DocumentsConfirmCaptureResponseInvoiceStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseInvoiceStatus value,
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
