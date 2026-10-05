using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AccountsCreateLedgerResponseType.AccountsCreateLedgerResponseTypeSerializer))]
[Serializable]
public readonly record struct AccountsCreateLedgerResponseType : IStringEnum
{
    public static readonly AccountsCreateLedgerResponseType Asset = new(Values.Asset);

    public static readonly AccountsCreateLedgerResponseType Liability = new(Values.Liability);

    public static readonly AccountsCreateLedgerResponseType Equity = new(Values.Equity);

    public static readonly AccountsCreateLedgerResponseType Income = new(Values.Income);

    public static readonly AccountsCreateLedgerResponseType Expense = new(Values.Expense);

    public AccountsCreateLedgerResponseType(string value)
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
    public static AccountsCreateLedgerResponseType FromCustom(string value)
    {
        return new AccountsCreateLedgerResponseType(value);
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

    public static bool operator ==(AccountsCreateLedgerResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsCreateLedgerResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsCreateLedgerResponseType value) => value.Value;

    public static explicit operator AccountsCreateLedgerResponseType(string value) => new(value);

    internal class AccountsCreateLedgerResponseTypeSerializer
        : JsonConverter<AccountsCreateLedgerResponseType>
    {
        public override AccountsCreateLedgerResponseType Read(
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
            return new AccountsCreateLedgerResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountsCreateLedgerResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountsCreateLedgerResponseType ReadAsPropertyName(
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
            return new AccountsCreateLedgerResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountsCreateLedgerResponseType value,
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
