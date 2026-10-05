using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesCreatePurchasesResponsePaymentStatus.InvoicesCreatePurchasesResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesCreatePurchasesResponsePaymentStatus : IStringEnum
{
    public static readonly InvoicesCreatePurchasesResponsePaymentStatus Unpaid = new(Values.Unpaid);

    public static readonly InvoicesCreatePurchasesResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly InvoicesCreatePurchasesResponsePaymentStatus Paid = new(Values.Paid);

    public InvoicesCreatePurchasesResponsePaymentStatus(string value)
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
    public static InvoicesCreatePurchasesResponsePaymentStatus FromCustom(string value)
    {
        return new InvoicesCreatePurchasesResponsePaymentStatus(value);
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
        InvoicesCreatePurchasesResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesCreatePurchasesResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesCreatePurchasesResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesCreatePurchasesResponsePaymentStatus(string value) =>
        new(value);

    internal class InvoicesCreatePurchasesResponsePaymentStatusSerializer
        : JsonConverter<InvoicesCreatePurchasesResponsePaymentStatus>
    {
        public override InvoicesCreatePurchasesResponsePaymentStatus Read(
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
            return new InvoicesCreatePurchasesResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesCreatePurchasesResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesCreatePurchasesResponsePaymentStatus ReadAsPropertyName(
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
            return new InvoicesCreatePurchasesResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesCreatePurchasesResponsePaymentStatus value,
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
