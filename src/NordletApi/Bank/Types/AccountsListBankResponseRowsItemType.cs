using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountsListBankResponseRowsItemType.AccountsListBankResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct AccountsListBankResponseRowsItemType : IStringEnum
{
    public static readonly AccountsListBankResponseRowsItemType Bank = new(Values.Bank);

    public static readonly AccountsListBankResponseRowsItemType Stripe = new(Values.Stripe);

    public AccountsListBankResponseRowsItemType(string value)
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
    public static AccountsListBankResponseRowsItemType FromCustom(string value)
    {
        return new AccountsListBankResponseRowsItemType(value);
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

    public static bool operator ==(AccountsListBankResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsListBankResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsListBankResponseRowsItemType value) =>
        value.Value;

    public static explicit operator AccountsListBankResponseRowsItemType(string value) =>
        new(value);

    internal class AccountsListBankResponseRowsItemTypeSerializer
        : JsonConverter<AccountsListBankResponseRowsItemType>
    {
        public override AccountsListBankResponseRowsItemType Read(
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
            return new AccountsListBankResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountsListBankResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountsListBankResponseRowsItemType ReadAsPropertyName(
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
            return new AccountsListBankResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountsListBankResponseRowsItemType value,
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
        public const string Bank = "bank";

        public const string Stripe = "stripe";
    }
}
