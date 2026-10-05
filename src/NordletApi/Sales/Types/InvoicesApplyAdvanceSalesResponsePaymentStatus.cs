using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesApplyAdvanceSalesResponsePaymentStatus.InvoicesApplyAdvanceSalesResponsePaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesApplyAdvanceSalesResponsePaymentStatus : IStringEnum
{
    public static readonly InvoicesApplyAdvanceSalesResponsePaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly InvoicesApplyAdvanceSalesResponsePaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly InvoicesApplyAdvanceSalesResponsePaymentStatus Paid = new(Values.Paid);

    public InvoicesApplyAdvanceSalesResponsePaymentStatus(string value)
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
    public static InvoicesApplyAdvanceSalesResponsePaymentStatus FromCustom(string value)
    {
        return new InvoicesApplyAdvanceSalesResponsePaymentStatus(value);
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
        InvoicesApplyAdvanceSalesResponsePaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesApplyAdvanceSalesResponsePaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesApplyAdvanceSalesResponsePaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesApplyAdvanceSalesResponsePaymentStatus(string value) =>
        new(value);

    internal class InvoicesApplyAdvanceSalesResponsePaymentStatusSerializer
        : JsonConverter<InvoicesApplyAdvanceSalesResponsePaymentStatus>
    {
        public override InvoicesApplyAdvanceSalesResponsePaymentStatus Read(
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
            return new InvoicesApplyAdvanceSalesResponsePaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponsePaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesApplyAdvanceSalesResponsePaymentStatus ReadAsPropertyName(
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
            return new InvoicesApplyAdvanceSalesResponsePaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponsePaymentStatus value,
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
