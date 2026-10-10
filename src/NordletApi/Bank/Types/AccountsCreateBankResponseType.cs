using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AccountsCreateBankResponseType.AccountsCreateBankResponseTypeSerializer))]
[Serializable]
public readonly record struct AccountsCreateBankResponseType : IStringEnum
{
    public static readonly AccountsCreateBankResponseType Bank = new(Values.Bank);

    public static readonly AccountsCreateBankResponseType Stripe = new(Values.Stripe);

    public AccountsCreateBankResponseType(string value)
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
    public static AccountsCreateBankResponseType FromCustom(string value)
    {
        return new AccountsCreateBankResponseType(value);
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

    public static bool operator ==(AccountsCreateBankResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsCreateBankResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsCreateBankResponseType value) => value.Value;

    public static explicit operator AccountsCreateBankResponseType(string value) => new(value);

    internal class AccountsCreateBankResponseTypeSerializer
        : JsonConverter<AccountsCreateBankResponseType>
    {
        public override AccountsCreateBankResponseType Read(
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
            return new AccountsCreateBankResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountsCreateBankResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountsCreateBankResponseType ReadAsPropertyName(
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
            return new AccountsCreateBankResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountsCreateBankResponseType value,
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
