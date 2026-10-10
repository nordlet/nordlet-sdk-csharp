using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AccountsUpdateBankRequestType.AccountsUpdateBankRequestTypeSerializer))]
[Serializable]
public readonly record struct AccountsUpdateBankRequestType : IStringEnum
{
    public static readonly AccountsUpdateBankRequestType Bank = new(Values.Bank);

    public static readonly AccountsUpdateBankRequestType Stripe = new(Values.Stripe);

    public AccountsUpdateBankRequestType(string value)
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
    public static AccountsUpdateBankRequestType FromCustom(string value)
    {
        return new AccountsUpdateBankRequestType(value);
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

    public static bool operator ==(AccountsUpdateBankRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsUpdateBankRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsUpdateBankRequestType value) => value.Value;

    public static explicit operator AccountsUpdateBankRequestType(string value) => new(value);

    internal class AccountsUpdateBankRequestTypeSerializer
        : JsonConverter<AccountsUpdateBankRequestType>
    {
        public override AccountsUpdateBankRequestType Read(
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
            return new AccountsUpdateBankRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountsUpdateBankRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountsUpdateBankRequestType ReadAsPropertyName(
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
            return new AccountsUpdateBankRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountsUpdateBankRequestType value,
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
