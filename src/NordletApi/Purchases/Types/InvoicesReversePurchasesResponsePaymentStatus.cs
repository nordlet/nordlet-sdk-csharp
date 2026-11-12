using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesReversePurchasesResponsePaymentStatus.InvoicesReversePurchasesResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesReversePurchasesResponsePaymentStatus : IStringEnum
{
    public static readonly InvoicesReversePurchasesResponsePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly InvoicesReversePurchasesResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly InvoicesReversePurchasesResponsePaymentStatus Paid = new(Values.Paid);

    public InvoicesReversePurchasesResponsePaymentStatus(string value)
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
    public static InvoicesReversePurchasesResponsePaymentStatus FromCustom(string value)
    {
        return new InvoicesReversePurchasesResponsePaymentStatus(value);
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
        InvoicesReversePurchasesResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesReversePurchasesResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesReversePurchasesResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesReversePurchasesResponsePaymentStatus(string value) =>
        new(value);

    internal class InvoicesReversePurchasesResponsePaymentStatusSerializer
        : JsonConverter<InvoicesReversePurchasesResponsePaymentStatus>
    {
        public override InvoicesReversePurchasesResponsePaymentStatus Read(
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
            return new InvoicesReversePurchasesResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesReversePurchasesResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesReversePurchasesResponsePaymentStatus ReadAsPropertyName(
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
            return new InvoicesReversePurchasesResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesReversePurchasesResponsePaymentStatus value,
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
