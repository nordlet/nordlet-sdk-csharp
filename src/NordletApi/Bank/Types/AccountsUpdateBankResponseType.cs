using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AccountsUpdateBankResponseType.AccountsUpdateBankResponseTypeSerializer))]
[Serializable]
public readonly record struct AccountsUpdateBankResponseType : IStringEnum
{
    public static readonly AccountsUpdateBankResponseType Bank = new(Values.Bank);

    public static readonly AccountsUpdateBankResponseType Stripe = new(Values.Stripe);

    public AccountsUpdateBankResponseType(string value)
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
    public static AccountsUpdateBankResponseType FromCustom(string value)
    {
        return new AccountsUpdateBankResponseType(value);
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

    public static bool operator ==(AccountsUpdateBankResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsUpdateBankResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsUpdateBankResponseType value) => value.Value;

    public static explicit operator AccountsUpdateBankResponseType(string value) => new(value);

    internal class AccountsUpdateBankResponseTypeSerializer
        : JsonConverter<AccountsUpdateBankResponseType>
    {
        public override AccountsUpdateBankResponseType Read(
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
            return new AccountsUpdateBankResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountsUpdateBankResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountsUpdateBankResponseType ReadAsPropertyName(
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
            return new AccountsUpdateBankResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountsUpdateBankResponseType value,
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
