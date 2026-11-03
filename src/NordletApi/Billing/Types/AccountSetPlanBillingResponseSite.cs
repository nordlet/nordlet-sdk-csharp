using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetPlanBillingResponseSite.AccountSetPlanBillingResponseSiteSerializer)
)]
[Serializable]
public readonly record struct AccountSetPlanBillingResponseSite : IStringEnum
{
    public static readonly AccountSetPlanBillingResponseSite App = new(Values.App);

    public static readonly AccountSetPlanBillingResponseSite Invoice = new(Values.Invoice);

    public AccountSetPlanBillingResponseSite(string value)
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
    public static AccountSetPlanBillingResponseSite FromCustom(string value)
    {
        return new AccountSetPlanBillingResponseSite(value);
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

    public static bool operator ==(AccountSetPlanBillingResponseSite value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountSetPlanBillingResponseSite value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetPlanBillingResponseSite value) => value.Value;

    public static explicit operator AccountSetPlanBillingResponseSite(string value) => new(value);

    internal class AccountSetPlanBillingResponseSiteSerializer
        : JsonConverter<AccountSetPlanBillingResponseSite>
    {
        public override AccountSetPlanBillingResponseSite Read(
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
            return new AccountSetPlanBillingResponseSite(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetPlanBillingResponseSite value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetPlanBillingResponseSite ReadAsPropertyName(
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
            return new AccountSetPlanBillingResponseSite(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetPlanBillingResponseSite value,
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
        public const string App = "app";

        public const string Invoice = "invoice";
    }
}
