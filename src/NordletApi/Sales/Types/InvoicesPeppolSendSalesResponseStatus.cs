using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesPeppolSendSalesResponseStatus.InvoicesPeppolSendSalesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesPeppolSendSalesResponseStatus : IStringEnum
{
    public static readonly InvoicesPeppolSendSalesResponseStatus Pending = new(Values.Pending);

    public static readonly InvoicesPeppolSendSalesResponseStatus Delivered = new(Values.Delivered);

    public static readonly InvoicesPeppolSendSalesResponseStatus Rejected = new(Values.Rejected);

    public static readonly InvoicesPeppolSendSalesResponseStatus Failed = new(Values.Failed);

    public InvoicesPeppolSendSalesResponseStatus(string value)
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
    public static InvoicesPeppolSendSalesResponseStatus FromCustom(string value)
    {
        return new InvoicesPeppolSendSalesResponseStatus(value);
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

    public static bool operator ==(InvoicesPeppolSendSalesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesPeppolSendSalesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesPeppolSendSalesResponseStatus value) =>
        value.Value;

    public static explicit operator InvoicesPeppolSendSalesResponseStatus(string value) =>
        new(value);

    internal class InvoicesPeppolSendSalesResponseStatusSerializer
        : JsonConverter<InvoicesPeppolSendSalesResponseStatus>
    {
        public override InvoicesPeppolSendSalesResponseStatus Read(
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
            return new InvoicesPeppolSendSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesPeppolSendSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesPeppolSendSalesResponseStatus ReadAsPropertyName(
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
            return new InvoicesPeppolSendSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesPeppolSendSalesResponseStatus value,
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
        public const string Pending = "pending";

        public const string Delivered = "delivered";

        public const string Rejected = "rejected";

        public const string Failed = "failed";
    }
}
