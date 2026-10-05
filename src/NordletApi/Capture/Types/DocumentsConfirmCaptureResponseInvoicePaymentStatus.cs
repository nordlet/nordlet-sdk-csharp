using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DocumentsConfirmCaptureResponseInvoicePaymentStatus.DocumentsConfirmCaptureResponseInvoicePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct DocumentsConfirmCaptureResponseInvoicePaymentStatus : IStringEnum
{
    public static readonly DocumentsConfirmCaptureResponseInvoicePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly DocumentsConfirmCaptureResponseInvoicePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly DocumentsConfirmCaptureResponseInvoicePaymentStatus Paid = new(
        Values.Paid
    );

    public DocumentsConfirmCaptureResponseInvoicePaymentStatus(string value)
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
    public static DocumentsConfirmCaptureResponseInvoicePaymentStatus FromCustom(string value)
    {
        return new DocumentsConfirmCaptureResponseInvoicePaymentStatus(value);
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
        DocumentsConfirmCaptureResponseInvoicePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsConfirmCaptureResponseInvoicePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsConfirmCaptureResponseInvoicePaymentStatus value
    ) => value.Value;

    public static explicit operator DocumentsConfirmCaptureResponseInvoicePaymentStatus(
        string value
    ) => new(value);

    internal class DocumentsConfirmCaptureResponseInvoicePaymentStatusSerializer
        : JsonConverter<DocumentsConfirmCaptureResponseInvoicePaymentStatus>
    {
        public override DocumentsConfirmCaptureResponseInvoicePaymentStatus Read(
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
            return new DocumentsConfirmCaptureResponseInvoicePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseInvoicePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsConfirmCaptureResponseInvoicePaymentStatus ReadAsPropertyName(
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
            return new DocumentsConfirmCaptureResponseInvoicePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseInvoicePaymentStatus value,
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
        public const string Unpaid = "unpaid";

        public const string Partial = "partial";

        public const string Paid = "paid";
    }
}
