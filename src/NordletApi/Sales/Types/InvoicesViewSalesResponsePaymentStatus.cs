using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesViewSalesResponsePaymentStatus.InvoicesViewSalesResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesViewSalesResponsePaymentStatus : IStringEnum
{
    public static readonly InvoicesViewSalesResponsePaymentStatus Unpaid = new(Values.Unpaid);

    public static readonly InvoicesViewSalesResponsePaymentStatus Partial = new(Values.Partial);

    public static readonly InvoicesViewSalesResponsePaymentStatus Paid = new(Values.Paid);

    public InvoicesViewSalesResponsePaymentStatus(string value)
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
    public static InvoicesViewSalesResponsePaymentStatus FromCustom(string value)
    {
        return new InvoicesViewSalesResponsePaymentStatus(value);
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

    public static bool operator ==(InvoicesViewSalesResponsePaymentStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesViewSalesResponsePaymentStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesViewSalesResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesViewSalesResponsePaymentStatus(string value) =>
        new(value);

    internal class InvoicesViewSalesResponsePaymentStatusSerializer
        : JsonConverter<InvoicesViewSalesResponsePaymentStatus>
    {
        public override InvoicesViewSalesResponsePaymentStatus Read(
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
            return new InvoicesViewSalesResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesViewSalesResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesViewSalesResponsePaymentStatus ReadAsPropertyName(
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
            return new InvoicesViewSalesResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesViewSalesResponsePaymentStatus value,
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
