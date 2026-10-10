using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesPeppolStatusSalesResponseStatus.InvoicesPeppolStatusSalesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesPeppolStatusSalesResponseStatus : IStringEnum
{
    public static readonly InvoicesPeppolStatusSalesResponseStatus Pending = new(Values.Pending);

    public static readonly InvoicesPeppolStatusSalesResponseStatus Delivered = new(
        Values.Delivered
    );

    public static readonly InvoicesPeppolStatusSalesResponseStatus Rejected = new(Values.Rejected);

    public static readonly InvoicesPeppolStatusSalesResponseStatus Failed = new(Values.Failed);

    public InvoicesPeppolStatusSalesResponseStatus(string value)
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
    public static InvoicesPeppolStatusSalesResponseStatus FromCustom(string value)
    {
        return new InvoicesPeppolStatusSalesResponseStatus(value);
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

    public static bool operator ==(InvoicesPeppolStatusSalesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesPeppolStatusSalesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesPeppolStatusSalesResponseStatus value) =>
        value.Value;

    public static explicit operator InvoicesPeppolStatusSalesResponseStatus(string value) =>
        new(value);

    internal class InvoicesPeppolStatusSalesResponseStatusSerializer
        : JsonConverter<InvoicesPeppolStatusSalesResponseStatus>
    {
        public override InvoicesPeppolStatusSalesResponseStatus Read(
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
            return new InvoicesPeppolStatusSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesPeppolStatusSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesPeppolStatusSalesResponseStatus ReadAsPropertyName(
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
            return new InvoicesPeppolStatusSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesPeppolStatusSalesResponseStatus value,
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
