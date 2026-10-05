using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesListSalesResponseRowsItemPaymentStatus.InvoicesListSalesResponseRowsItemPaymentStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesListSalesResponseRowsItemPaymentStatus : IStringEnum
{
    public static readonly InvoicesListSalesResponseRowsItemPaymentStatus Unpaid = new(
        Values.Unpaid
    );

    public static readonly InvoicesListSalesResponseRowsItemPaymentStatus Partial = new(
        Values.Partial
    );

    public static readonly InvoicesListSalesResponseRowsItemPaymentStatus Paid = new(Values.Paid);

    public InvoicesListSalesResponseRowsItemPaymentStatus(string value)
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
    public static InvoicesListSalesResponseRowsItemPaymentStatus FromCustom(string value)
    {
        return new InvoicesListSalesResponseRowsItemPaymentStatus(value);
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
        InvoicesListSalesResponseRowsItemPaymentStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesListSalesResponseRowsItemPaymentStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListSalesResponseRowsItemPaymentStatus value) =>
        value.Value;

    public static explicit operator InvoicesListSalesResponseRowsItemPaymentStatus(string value) =>
        new(value);

    internal class InvoicesListSalesResponseRowsItemPaymentStatusSerializer
        : JsonConverter<InvoicesListSalesResponseRowsItemPaymentStatus>
    {
        public override InvoicesListSalesResponseRowsItemPaymentStatus Read(
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
            return new InvoicesListSalesResponseRowsItemPaymentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesListSalesResponseRowsItemPaymentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesListSalesResponseRowsItemPaymentStatus ReadAsPropertyName(
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
            return new InvoicesListSalesResponseRowsItemPaymentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesListSalesResponseRowsItemPaymentStatus value,
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
