using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetAccountTypeBillingResponseAccountType.AccountSetAccountTypeBillingResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct AccountSetAccountTypeBillingResponseAccountType : IStringEnum
{
    public static readonly AccountSetAccountTypeBillingResponseAccountType FlatRate = new(
        Values.FlatRate
    );

    public static readonly AccountSetAccountTypeBillingResponseAccountType PerRequest = new(
        Values.PerRequest
    );

    public AccountSetAccountTypeBillingResponseAccountType(string value)
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
    public static AccountSetAccountTypeBillingResponseAccountType FromCustom(string value)
    {
        return new AccountSetAccountTypeBillingResponseAccountType(value);
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

    public static bool operator ==(
        AccountSetAccountTypeBillingResponseAccountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AccountSetAccountTypeBillingResponseAccountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetAccountTypeBillingResponseAccountType value) =>
        value.Value;

    public static explicit operator AccountSetAccountTypeBillingResponseAccountType(string value) =>
        new(value);

    internal class AccountSetAccountTypeBillingResponseAccountTypeSerializer
        : JsonConverter<AccountSetAccountTypeBillingResponseAccountType>
    {
        public override AccountSetAccountTypeBillingResponseAccountType Read(
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
            return new AccountSetAccountTypeBillingResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetAccountTypeBillingResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetAccountTypeBillingResponseAccountType ReadAsPropertyName(
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
            return new AccountSetAccountTypeBillingResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetAccountTypeBillingResponseAccountType value,
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
        public const string FlatRate = "flat_rate";

        public const string PerRequest = "per_request";
    }
}
