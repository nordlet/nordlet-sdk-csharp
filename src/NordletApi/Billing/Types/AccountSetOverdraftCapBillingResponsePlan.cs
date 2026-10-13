using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetOverdraftCapBillingResponsePlan.AccountSetOverdraftCapBillingResponsePlanSerializer)
)]
[Serializable]
public readonly record struct AccountSetOverdraftCapBillingResponsePlan : IStringEnum
{
    public static readonly AccountSetOverdraftCapBillingResponsePlan Starter = new(Values.Starter);

    public static readonly AccountSetOverdraftCapBillingResponsePlan Business = new(
        Values.Business
    );

    public static readonly AccountSetOverdraftCapBillingResponsePlan Scale = new(Values.Scale);

    public AccountSetOverdraftCapBillingResponsePlan(string value)
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
    public static AccountSetOverdraftCapBillingResponsePlan FromCustom(string value)
    {
        return new AccountSetOverdraftCapBillingResponsePlan(value);
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
        AccountSetOverdraftCapBillingResponsePlan value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AccountSetOverdraftCapBillingResponsePlan value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetOverdraftCapBillingResponsePlan value) =>
        value.Value;

    public static explicit operator AccountSetOverdraftCapBillingResponsePlan(string value) =>
        new(value);

    internal class AccountSetOverdraftCapBillingResponsePlanSerializer
        : JsonConverter<AccountSetOverdraftCapBillingResponsePlan>
    {
        public override AccountSetOverdraftCapBillingResponsePlan Read(
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
            return new AccountSetOverdraftCapBillingResponsePlan(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetOverdraftCapBillingResponsePlan value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetOverdraftCapBillingResponsePlan ReadAsPropertyName(
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
            return new AccountSetOverdraftCapBillingResponsePlan(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetOverdraftCapBillingResponsePlan value,
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
        public const string Starter = "starter";

        public const string Business = "business";

        public const string Scale = "scale";
    }
}
