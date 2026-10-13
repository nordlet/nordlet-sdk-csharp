using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetAutoTopUpBillingResponseStatus.AccountSetAutoTopUpBillingResponseStatusSerializer)
)]
[Serializable]
public readonly record struct AccountSetAutoTopUpBillingResponseStatus : IStringEnum
{
    public static readonly AccountSetAutoTopUpBillingResponseStatus Trial = new(Values.Trial);

    public static readonly AccountSetAutoTopUpBillingResponseStatus Active = new(Values.Active);

    public static readonly AccountSetAutoTopUpBillingResponseStatus Suspended = new(
        Values.Suspended
    );

    public AccountSetAutoTopUpBillingResponseStatus(string value)
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
    public static AccountSetAutoTopUpBillingResponseStatus FromCustom(string value)
    {
        return new AccountSetAutoTopUpBillingResponseStatus(value);
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
        AccountSetAutoTopUpBillingResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AccountSetAutoTopUpBillingResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetAutoTopUpBillingResponseStatus value) =>
        value.Value;

    public static explicit operator AccountSetAutoTopUpBillingResponseStatus(string value) =>
        new(value);

    internal class AccountSetAutoTopUpBillingResponseStatusSerializer
        : JsonConverter<AccountSetAutoTopUpBillingResponseStatus>
    {
        public override AccountSetAutoTopUpBillingResponseStatus Read(
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
            return new AccountSetAutoTopUpBillingResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetAutoTopUpBillingResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetAutoTopUpBillingResponseStatus ReadAsPropertyName(
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
            return new AccountSetAutoTopUpBillingResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetAutoTopUpBillingResponseStatus value,
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
