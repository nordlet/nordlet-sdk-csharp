using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AccountsUpdateLedgerResponseType.AccountsUpdateLedgerResponseTypeSerializer))]
[Serializable]
public readonly record struct AccountsUpdateLedgerResponseType : IStringEnum
{
    public static readonly AccountsUpdateLedgerResponseType Asset = new(Values.Asset);

    public static readonly AccountsUpdateLedgerResponseType Liability = new(Values.Liability);

    public static readonly AccountsUpdateLedgerResponseType Equity = new(Values.Equity);

    public static readonly AccountsUpdateLedgerResponseType Income = new(Values.Income);

    public static readonly AccountsUpdateLedgerResponseType Expense = new(Values.Expense);

    public AccountsUpdateLedgerResponseType(string value)
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
    public static AccountsUpdateLedgerResponseType FromCustom(string value)
    {
        return new AccountsUpdateLedgerResponseType(value);
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

    public static bool operator ==(AccountsUpdateLedgerResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsUpdateLedgerResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsUpdateLedgerResponseType value) => value.Value;

    public static explicit operator AccountsUpdateLedgerResponseType(string value) => new(value);

    internal class AccountsUpdateLedgerResponseTypeSerializer
        : JsonConverter<AccountsUpdateLedgerResponseType>
    {
        public override AccountsUpdateLedgerResponseType Read(
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
            return new AccountsUpdateLedgerResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountsUpdateLedgerResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountsUpdateLedgerResponseType ReadAsPropertyName(
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
            return new AccountsUpdateLedgerResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountsUpdateLedgerResponseType value,
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
