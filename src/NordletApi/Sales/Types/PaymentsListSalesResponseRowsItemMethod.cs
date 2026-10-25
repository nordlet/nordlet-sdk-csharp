using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PaymentsListSalesResponseRowsItemMethod.PaymentsListSalesResponseRowsItemMethodSerializer)
)]
[Serializable]
public readonly record struct PaymentsListSalesResponseRowsItemMethod : IStringEnum
{
    public static readonly PaymentsListSalesResponseRowsItemMethod BankTransfer = new(
        Values.BankTransfer
    );

    public static readonly PaymentsListSalesResponseRowsItemMethod Card = new(Values.Card);

    public static readonly PaymentsListSalesResponseRowsItemMethod Cash = new(Values.Cash);

    public PaymentsListSalesResponseRowsItemMethod(string value)
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
    public static PaymentsListSalesResponseRowsItemMethod FromCustom(string value)
    {
        return new PaymentsListSalesResponseRowsItemMethod(value);
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

    public static bool operator ==(PaymentsListSalesResponseRowsItemMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PaymentsListSalesResponseRowsItemMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PaymentsListSalesResponseRowsItemMethod value) =>
        value.Value;

    public static explicit operator PaymentsListSalesResponseRowsItemMethod(string value) =>
        new(value);

    internal class PaymentsListSalesResponseRowsItemMethodSerializer
        : JsonConverter<PaymentsListSalesResponseRowsItemMethod>
    {
        public override PaymentsListSalesResponseRowsItemMethod Read(
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
            return new PaymentsListSalesResponseRowsItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PaymentsListSalesResponseRowsItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PaymentsListSalesResponseRowsItemMethod ReadAsPropertyName(
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
            return new PaymentsListSalesResponseRowsItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PaymentsListSalesResponseRowsItemMethod value,
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
        public const string BankTransfer = "bank_transfer";

        public const string Card = "card";

        public const string Cash = "cash";
    }
}
