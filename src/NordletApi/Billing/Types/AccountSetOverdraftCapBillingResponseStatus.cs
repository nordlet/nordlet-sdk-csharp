using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetOverdraftCapBillingResponseStatus.AccountSetOverdraftCapBillingResponseStatusSerializer)
)]
[Serializable]
public readonly record struct AccountSetOverdraftCapBillingResponseStatus : IStringEnum
{
    public static readonly AccountSetOverdraftCapBillingResponseStatus Trial = new(Values.Trial);

    public static readonly AccountSetOverdraftCapBillingResponseStatus Active = new(Values.Active);

    public static readonly AccountSetOverdraftCapBillingResponseStatus Suspended = new(
        Values.Suspended
    );

    public AccountSetOverdraftCapBillingResponseStatus(string value)
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
    public static AccountSetOverdraftCapBillingResponseStatus FromCustom(string value)
    {
        return new AccountSetOverdraftCapBillingResponseStatus(value);
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
        AccountSetOverdraftCapBillingResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AccountSetOverdraftCapBillingResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetOverdraftCapBillingResponseStatus value) =>
        value.Value;

    public static explicit operator AccountSetOverdraftCapBillingResponseStatus(string value) =>
        new(value);

    internal class AccountSetOverdraftCapBillingResponseStatusSerializer
        : JsonConverter<AccountSetOverdraftCapBillingResponseStatus>
    {
        public override AccountSetOverdraftCapBillingResponseStatus Read(
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
            return new AccountSetOverdraftCapBillingResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetOverdraftCapBillingResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetOverdraftCapBillingResponseStatus ReadAsPropertyName(
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
            return new AccountSetOverdraftCapBillingResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetOverdraftCapBillingResponseStatus value,
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
        public const string Trial = "trial";

        public const string Active = "active";

        public const string Suspended = "suspended";
    }
}
