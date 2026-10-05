using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesGetPurchasesResponsePaymentStatus.InvoicesGetPurchasesResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesGetPurchasesResponsePaymentStatus : IStringEnum
{
    public static readonly InvoicesGetPurchasesResponsePaymentStatus Unpaid = new(Values.Unpaid);

    public static readonly InvoicesGetPurchasesResponsePaymentStatus Partial = new(Values.Partial);

    public static readonly InvoicesGetPurchasesResponsePaymentStatus Paid = new(Values.Paid);

    public InvoicesGetPurchasesResponsePaymentStatus(string value)
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
    public static InvoicesGetPurchasesResponsePaymentStatus FromCustom(string value)
    {
        return new InvoicesGetPurchasesResponsePaymentStatus(value);
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
        InvoicesGetPurchasesResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesGetPurchasesResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesGetPurchasesResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesGetPurchasesResponsePaymentStatus(string value) =>
        new(value);

    internal class InvoicesGetPurchasesResponsePaymentStatusSerializer
        : JsonConverter<InvoicesGetPurchasesResponsePaymentStatus>
    {
        public override InvoicesGetPurchasesResponsePaymentStatus Read(
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
            return new InvoicesGetPurchasesResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesGetPurchasesResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesGetPurchasesResponsePaymentStatus ReadAsPropertyName(
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
            return new InvoicesGetPurchasesResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesGetPurchasesResponsePaymentStatus value,
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
