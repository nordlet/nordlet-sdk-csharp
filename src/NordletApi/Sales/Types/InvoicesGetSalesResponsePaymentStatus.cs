using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesGetSalesResponsePaymentStatus.InvoicesGetSalesResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesGetSalesResponsePaymentStatus : IStringEnum
{
    public static readonly InvoicesGetSalesResponsePaymentStatus Unpaid = new(Values.Unpaid);

    public static readonly InvoicesGetSalesResponsePaymentStatus Partial = new(Values.Partial);

    public static readonly InvoicesGetSalesResponsePaymentStatus Paid = new(Values.Paid);

    public InvoicesGetSalesResponsePaymentStatus(string value)
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
    public static InvoicesGetSalesResponsePaymentStatus FromCustom(string value)
    {
        return new InvoicesGetSalesResponsePaymentStatus(value);
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

    public static bool operator ==(InvoicesGetSalesResponsePaymentStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesGetSalesResponsePaymentStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesGetSalesResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesGetSalesResponsePaymentStatus(string value) =>
        new(value);

    internal class InvoicesGetSalesResponsePaymentStatusSerializer
        : JsonConverter<InvoicesGetSalesResponsePaymentStatus>
    {
        public override InvoicesGetSalesResponsePaymentStatus Read(
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
            return new InvoicesGetSalesResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesGetSalesResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesGetSalesResponsePaymentStatus ReadAsPropertyName(
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
            return new InvoicesGetSalesResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesGetSalesResponsePaymentStatus value,
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
