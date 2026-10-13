using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetAutoTopUpBillingResponseAccountType.AccountSetAutoTopUpBillingResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct AccountSetAutoTopUpBillingResponseAccountType : IStringEnum
{
    public static readonly AccountSetAutoTopUpBillingResponseAccountType FlatRate = new(
        Values.FlatRate
    );

    public static readonly AccountSetAutoTopUpBillingResponseAccountType PerRequest = new(
        Values.PerRequest
    );

    public AccountSetAutoTopUpBillingResponseAccountType(string value)
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
    public static AccountSetAutoTopUpBillingResponseAccountType FromCustom(string value)
    {
        return new AccountSetAutoTopUpBillingResponseAccountType(value);
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
        AccountSetAutoTopUpBillingResponseAccountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AccountSetAutoTopUpBillingResponseAccountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetAutoTopUpBillingResponseAccountType value) =>
        value.Value;

    public static explicit operator AccountSetAutoTopUpBillingResponseAccountType(string value) =>
        new(value);

    internal class AccountSetAutoTopUpBillingResponseAccountTypeSerializer
        : JsonConverter<AccountSetAutoTopUpBillingResponseAccountType>
    {
        public override AccountSetAutoTopUpBillingResponseAccountType Read(
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
            return new AccountSetAutoTopUpBillingResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetAutoTopUpBillingResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetAutoTopUpBillingResponseAccountType ReadAsPropertyName(
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
            return new AccountSetAutoTopUpBillingResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetAutoTopUpBillingResponseAccountType value,
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
