using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AccountsCreateBankRequestType.AccountsCreateBankRequestTypeSerializer))]
[Serializable]
public readonly record struct AccountsCreateBankRequestType : IStringEnum
{
    public static readonly AccountsCreateBankRequestType Bank = new(Values.Bank);

    public static readonly AccountsCreateBankRequestType Stripe = new(Values.Stripe);

    public AccountsCreateBankRequestType(string value)
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
    public static AccountsCreateBankRequestType FromCustom(string value)
    {
        return new AccountsCreateBankRequestType(value);
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

    public static bool operator ==(AccountsCreateBankRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsCreateBankRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsCreateBankRequestType value) => value.Value;

    public static explicit operator AccountsCreateBankRequestType(string value) => new(value);

    internal class AccountsCreateBankRequestTypeSerializer
        : JsonConverter<AccountsCreateBankRequestType>
    {
        public override AccountsCreateBankRequestType Read(
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
            return new AccountsCreateBankRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountsCreateBankRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountsCreateBankRequestType ReadAsPropertyName(
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
            return new AccountsCreateBankRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountsCreateBankRequestType value,
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
