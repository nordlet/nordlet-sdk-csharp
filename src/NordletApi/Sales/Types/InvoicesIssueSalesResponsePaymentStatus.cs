using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesIssueSalesResponsePaymentStatus.InvoicesIssueSalesResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesIssueSalesResponsePaymentStatus : IStringEnum
{
    public static readonly InvoicesIssueSalesResponsePaymentStatus Unpaid = new(Values.Unpaid);

    public static readonly InvoicesIssueSalesResponsePaymentStatus Partial = new(Values.Partial);

    public static readonly InvoicesIssueSalesResponsePaymentStatus Paid = new(Values.Paid);

    public InvoicesIssueSalesResponsePaymentStatus(string value)
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
    public static InvoicesIssueSalesResponsePaymentStatus FromCustom(string value)
    {
        return new InvoicesIssueSalesResponsePaymentStatus(value);
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

    public static bool operator ==(InvoicesIssueSalesResponsePaymentStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesIssueSalesResponsePaymentStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesIssueSalesResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesIssueSalesResponsePaymentStatus(string value) =>
        new(value);

    internal class InvoicesIssueSalesResponsePaymentStatusSerializer
        : JsonConverter<InvoicesIssueSalesResponsePaymentStatus>
    {
        public override InvoicesIssueSalesResponsePaymentStatus Read(
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
            return new InvoicesIssueSalesResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesIssueSalesResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesIssueSalesResponsePaymentStatus ReadAsPropertyName(
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
            return new InvoicesIssueSalesResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesIssueSalesResponsePaymentStatus value,
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
