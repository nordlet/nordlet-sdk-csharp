using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesEinvoiceStatusSalesResponseStatus.InvoicesEinvoiceStatusSalesResponseStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesEinvoiceStatusSalesResponseStatus : IStringEnum
{
    public static readonly InvoicesEinvoiceStatusSalesResponseStatus Sent = new(Values.Sent);

    public static readonly InvoicesEinvoiceStatusSalesResponseStatus Accepted = new(
        Values.Accepted
    );

    public static readonly InvoicesEinvoiceStatusSalesResponseStatus Rejected = new(
        Values.Rejected
    );

    public InvoicesEinvoiceStatusSalesResponseStatus(string value)
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
    public static InvoicesEinvoiceStatusSalesResponseStatus FromCustom(string value)
    {
        return new InvoicesEinvoiceStatusSalesResponseStatus(value);
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
        InvoicesEinvoiceStatusSalesResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesEinvoiceStatusSalesResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesEinvoiceStatusSalesResponseStatus value) =>
        value.Value;

    public static explicit operator InvoicesEinvoiceStatusSalesResponseStatus(string value) =>
        new(value);

    internal class InvoicesEinvoiceStatusSalesResponseStatusSerializer
        : JsonConverter<InvoicesEinvoiceStatusSalesResponseStatus>
    {
        public override InvoicesEinvoiceStatusSalesResponseStatus Read(
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
            return new InvoicesEinvoiceStatusSalesResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesEinvoiceStatusSalesResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesEinvoiceStatusSalesResponseStatus ReadAsPropertyName(
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
            return new InvoicesEinvoiceStatusSalesResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesEinvoiceStatusSalesResponseStatus value,
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
