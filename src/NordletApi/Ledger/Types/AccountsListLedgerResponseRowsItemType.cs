using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountsListLedgerResponseRowsItemType.AccountsListLedgerResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct AccountsListLedgerResponseRowsItemType : IStringEnum
{
    public static readonly AccountsListLedgerResponseRowsItemType Asset = new(Values.Asset);

    public static readonly AccountsListLedgerResponseRowsItemType Liability = new(Values.Liability);

    public static readonly AccountsListLedgerResponseRowsItemType Equity = new(Values.Equity);

    public static readonly AccountsListLedgerResponseRowsItemType Income = new(Values.Income);

    public static readonly AccountsListLedgerResponseRowsItemType Expense = new(Values.Expense);

    public AccountsListLedgerResponseRowsItemType(string value)
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
    public static AccountsListLedgerResponseRowsItemType FromCustom(string value)
    {
        return new AccountsListLedgerResponseRowsItemType(value);
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

    public static bool operator ==(AccountsListLedgerResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsListLedgerResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsListLedgerResponseRowsItemType value) =>
        value.Value;

    public static explicit operator AccountsListLedgerResponseRowsItemType(string value) =>
        new(value);

    internal class AccountsListLedgerResponseRowsItemTypeSerializer
        : JsonConverter<AccountsListLedgerResponseRowsItemType>
    {
        public override AccountsListLedgerResponseRowsItemType Read(
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
            return new AccountsListLedgerResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountsListLedgerResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountsListLedgerResponseRowsItemType ReadAsPropertyName(
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
            return new AccountsListLedgerResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountsListLedgerResponseRowsItemType value,
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
