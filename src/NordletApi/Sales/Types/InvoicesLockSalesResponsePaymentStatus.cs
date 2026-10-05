using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesLockSalesResponsePaymentStatus.InvoicesLockSalesResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesLockSalesResponsePaymentStatus : IStringEnum
{
    public static readonly InvoicesLockSalesResponsePaymentStatus Unpaid = new(Values.Unpaid);

    public static readonly InvoicesLockSalesResponsePaymentStatus Partial = new(Values.Partial);

    public static readonly InvoicesLockSalesResponsePaymentStatus Paid = new(Values.Paid);

    public InvoicesLockSalesResponsePaymentStatus(string value)
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
    public static InvoicesLockSalesResponsePaymentStatus FromCustom(string value)
    {
        return new InvoicesLockSalesResponsePaymentStatus(value);
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

    public static bool operator ==(InvoicesLockSalesResponsePaymentStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesLockSalesResponsePaymentStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesLockSalesResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesLockSalesResponsePaymentStatus(string value) =>
        new(value);

    internal class InvoicesLockSalesResponsePaymentStatusSerializer
        : JsonConverter<InvoicesLockSalesResponsePaymentStatus>
    {
        public override InvoicesLockSalesResponsePaymentStatus Read(
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
            return new InvoicesLockSalesResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesLockSalesResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesLockSalesResponsePaymentStatus ReadAsPropertyName(
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
            return new InvoicesLockSalesResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesLockSalesResponsePaymentStatus value,
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
