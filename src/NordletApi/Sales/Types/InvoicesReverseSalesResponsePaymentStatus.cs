using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesReverseSalesResponsePaymentStatus.InvoicesReverseSalesResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesReverseSalesResponsePaymentStatus : IStringEnum
{
    public static readonly InvoicesReverseSalesResponsePaymentStatus Unpaid = new(Values.Unpaid);

    public static readonly InvoicesReverseSalesResponsePaymentStatus Partial = new(Values.Partial);

    public static readonly InvoicesReverseSalesResponsePaymentStatus Paid = new(Values.Paid);

    public InvoicesReverseSalesResponsePaymentStatus(string value)
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
    public static InvoicesReverseSalesResponsePaymentStatus FromCustom(string value)
    {
        return new InvoicesReverseSalesResponsePaymentStatus(value);
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
        InvoicesReverseSalesResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesReverseSalesResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesReverseSalesResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesReverseSalesResponsePaymentStatus(string value) =>
        new(value);

    internal class InvoicesReverseSalesResponsePaymentStatusSerializer
        : JsonConverter<InvoicesReverseSalesResponsePaymentStatus>
    {
        public override InvoicesReverseSalesResponsePaymentStatus Read(
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
            return new InvoicesReverseSalesResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesReverseSalesResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesReverseSalesResponsePaymentStatus ReadAsPropertyName(
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
            return new InvoicesReverseSalesResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesReverseSalesResponsePaymentStatus value,
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
