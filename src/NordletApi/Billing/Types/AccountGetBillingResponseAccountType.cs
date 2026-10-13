using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountGetBillingResponseAccountType.AccountGetBillingResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct AccountGetBillingResponseAccountType : IStringEnum
{
    public static readonly AccountGetBillingResponseAccountType FlatRate = new(Values.FlatRate);

    public static readonly AccountGetBillingResponseAccountType PerRequest = new(Values.PerRequest);

    public AccountGetBillingResponseAccountType(string value)
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
    public static AccountGetBillingResponseAccountType FromCustom(string value)
    {
        return new AccountGetBillingResponseAccountType(value);
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

    public static bool operator ==(AccountGetBillingResponseAccountType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountGetBillingResponseAccountType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountGetBillingResponseAccountType value) =>
        value.Value;

    public static explicit operator AccountGetBillingResponseAccountType(string value) =>
        new(value);

    internal class AccountGetBillingResponseAccountTypeSerializer
        : JsonConverter<AccountGetBillingResponseAccountType>
    {
        public override AccountGetBillingResponseAccountType Read(
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
            return new AccountGetBillingResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountGetBillingResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountGetBillingResponseAccountType ReadAsPropertyName(
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
            return new AccountGetBillingResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountGetBillingResponseAccountType value,
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
