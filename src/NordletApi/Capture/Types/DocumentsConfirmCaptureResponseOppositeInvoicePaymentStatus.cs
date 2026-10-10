using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus.DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus
    : IStringEnum
{
    public static readonly DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus Partial =
        new(Values.Partial);

    public static readonly DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus Paid = new(
        Values.Paid
    );

    public DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus(string value)
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
    public static DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus FromCustom(
        string value
    )
    {
        return new DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus(value);
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
        DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus value
    ) => value.Value;

    public static explicit operator DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus(
        string value
    ) => new(value);

    internal class DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatusSerializer
        : JsonConverter<DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus>
    {
        public override DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus Read(
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
            return new DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus ReadAsPropertyName(
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
            return new DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsConfirmCaptureResponseOppositeInvoicePaymentStatus value,
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
