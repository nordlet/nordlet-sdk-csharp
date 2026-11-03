using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetAutoTopUpBillingResponseSite.AccountSetAutoTopUpBillingResponseSiteSerializer)
)]
[Serializable]
public readonly record struct AccountSetAutoTopUpBillingResponseSite : IStringEnum
{
    public static readonly AccountSetAutoTopUpBillingResponseSite App = new(Values.App);

    public static readonly AccountSetAutoTopUpBillingResponseSite Invoice = new(Values.Invoice);

    public AccountSetAutoTopUpBillingResponseSite(string value)
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
    public static AccountSetAutoTopUpBillingResponseSite FromCustom(string value)
    {
        return new AccountSetAutoTopUpBillingResponseSite(value);
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

    public static bool operator ==(AccountSetAutoTopUpBillingResponseSite value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountSetAutoTopUpBillingResponseSite value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetAutoTopUpBillingResponseSite value) =>
        value.Value;

    public static explicit operator AccountSetAutoTopUpBillingResponseSite(string value) =>
        new(value);

    internal class AccountSetAutoTopUpBillingResponseSiteSerializer
        : JsonConverter<AccountSetAutoTopUpBillingResponseSite>
    {
        public override AccountSetAutoTopUpBillingResponseSite Read(
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
            return new AccountSetAutoTopUpBillingResponseSite(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetAutoTopUpBillingResponseSite value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetAutoTopUpBillingResponseSite ReadAsPropertyName(
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
            return new AccountSetAutoTopUpBillingResponseSite(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetAutoTopUpBillingResponseSite value,
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
