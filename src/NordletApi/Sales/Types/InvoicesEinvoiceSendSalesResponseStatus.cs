using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesEinvoiceSendSalesResponseStatus.InvoicesEinvoiceSendSalesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesEinvoiceSendSalesResponseStatus : IStringEnum
{
    public static readonly InvoicesEinvoiceSendSalesResponseStatus Sent = new(Values.Sent);

    public static readonly InvoicesEinvoiceSendSalesResponseStatus Accepted = new(Values.Accepted);

    public static readonly InvoicesEinvoiceSendSalesResponseStatus Rejected = new(Values.Rejected);

    public InvoicesEinvoiceSendSalesResponseStatus(string value)
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
    public static InvoicesEinvoiceSendSalesResponseStatus FromCustom(string value)
    {
        return new InvoicesEinvoiceSendSalesResponseStatus(value);
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

    public static bool operator ==(InvoicesEinvoiceSendSalesResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesEinvoiceSendSalesResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesEinvoiceSendSalesResponseStatus value) =>
        value.Value;

    public static explicit operator InvoicesEinvoiceSendSalesResponseStatus(string value) =>
        new(value);

    internal class InvoicesEinvoiceSendSalesResponseStatusSerializer
        : JsonConverter<InvoicesEinvoiceSendSalesResponseStatus>
    {
        public override InvoicesEinvoiceSendSalesResponseStatus Read(
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
            return new InvoicesEinvoiceSendSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesEinvoiceSendSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesEinvoiceSendSalesResponseStatus ReadAsPropertyName(
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
            return new InvoicesEinvoiceSendSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesEinvoiceSendSalesResponseStatus value,
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
        public const string Sent = "sent";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
