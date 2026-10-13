using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetPlanBillingResponseAccountType.AccountSetPlanBillingResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct AccountSetPlanBillingResponseAccountType : IStringEnum
{
    public static readonly AccountSetPlanBillingResponseAccountType FlatRate = new(Values.FlatRate);

    public static readonly AccountSetPlanBillingResponseAccountType PerRequest = new(
        Values.PerRequest
    );

    public AccountSetPlanBillingResponseAccountType(string value)
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
    public static AccountSetPlanBillingResponseAccountType FromCustom(string value)
    {
        return new AccountSetPlanBillingResponseAccountType(value);
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
        AccountSetPlanBillingResponseAccountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AccountSetPlanBillingResponseAccountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetPlanBillingResponseAccountType value) =>
        value.Value;

    public static explicit operator AccountSetPlanBillingResponseAccountType(string value) =>
        new(value);

    internal class AccountSetPlanBillingResponseAccountTypeSerializer
        : JsonConverter<AccountSetPlanBillingResponseAccountType>
    {
        public override AccountSetPlanBillingResponseAccountType Read(
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
            return new AccountSetPlanBillingResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetPlanBillingResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetPlanBillingResponseAccountType ReadAsPropertyName(
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
            return new AccountSetPlanBillingResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetPlanBillingResponseAccountType value,
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
