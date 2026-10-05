using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TrialBalanceReportsResponseRowsItemType.TrialBalanceReportsResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct TrialBalanceReportsResponseRowsItemType : IStringEnum
{
    public static readonly TrialBalanceReportsResponseRowsItemType Asset = new(Values.Asset);

    public static readonly TrialBalanceReportsResponseRowsItemType Liability = new(
        Values.Liability
    );

    public static readonly TrialBalanceReportsResponseRowsItemType Equity = new(Values.Equity);

    public static readonly TrialBalanceReportsResponseRowsItemType Income = new(Values.Income);

    public static readonly TrialBalanceReportsResponseRowsItemType Expense = new(Values.Expense);

    public TrialBalanceReportsResponseRowsItemType(string value)
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
    public static TrialBalanceReportsResponseRowsItemType FromCustom(string value)
    {
        return new TrialBalanceReportsResponseRowsItemType(value);
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

    public static bool operator ==(TrialBalanceReportsResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TrialBalanceReportsResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TrialBalanceReportsResponseRowsItemType value) =>
        value.Value;

    public static explicit operator TrialBalanceReportsResponseRowsItemType(string value) =>
        new(value);

    internal class TrialBalanceReportsResponseRowsItemTypeSerializer
        : JsonConverter<TrialBalanceReportsResponseRowsItemType>
    {
        public override TrialBalanceReportsResponseRowsItemType Read(
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
            return new TrialBalanceReportsResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TrialBalanceReportsResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TrialBalanceReportsResponseRowsItemType ReadAsPropertyName(
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
            return new TrialBalanceReportsResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TrialBalanceReportsResponseRowsItemType value,
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
        public const string Asset = "asset";

        public const string Liability = "liability";

        public const string Equity = "equity";

        public const string Income = "income";

        public const string Expense = "expense";
    }
}
