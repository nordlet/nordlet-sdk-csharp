using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetPlanBillingResponsePlan.AccountSetPlanBillingResponsePlanSerializer)
)]
[Serializable]
public readonly record struct AccountSetPlanBillingResponsePlan : IStringEnum
{
    public static readonly AccountSetPlanBillingResponsePlan Starter = new(Values.Starter);

    public static readonly AccountSetPlanBillingResponsePlan Business = new(Values.Business);

    public static readonly AccountSetPlanBillingResponsePlan Scale = new(Values.Scale);

    public AccountSetPlanBillingResponsePlan(string value)
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
    public static AccountSetPlanBillingResponsePlan FromCustom(string value)
    {
        return new AccountSetPlanBillingResponsePlan(value);
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

    public static bool operator ==(AccountSetPlanBillingResponsePlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountSetPlanBillingResponsePlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetPlanBillingResponsePlan value) => value.Value;

    public static explicit operator AccountSetPlanBillingResponsePlan(string value) => new(value);

    internal class AccountSetPlanBillingResponsePlanSerializer
        : JsonConverter<AccountSetPlanBillingResponsePlan>
    {
        public override AccountSetPlanBillingResponsePlan Read(
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
            return new AccountSetPlanBillingResponsePlan(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetPlanBillingResponsePlan value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetPlanBillingResponsePlan ReadAsPropertyName(
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
            return new AccountSetPlanBillingResponsePlan(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetPlanBillingResponsePlan value,
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
