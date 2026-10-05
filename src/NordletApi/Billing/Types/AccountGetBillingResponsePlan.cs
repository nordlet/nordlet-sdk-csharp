using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AccountGetBillingResponsePlan.AccountGetBillingResponsePlanSerializer))]
[Serializable]
public readonly record struct AccountGetBillingResponsePlan : IStringEnum
{
    public static readonly AccountGetBillingResponsePlan Starter = new(Values.Starter);

    public static readonly AccountGetBillingResponsePlan Business = new(Values.Business);

    public static readonly AccountGetBillingResponsePlan Scale = new(Values.Scale);

    public AccountGetBillingResponsePlan(string value)
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
    public static AccountGetBillingResponsePlan FromCustom(string value)
    {
        return new AccountGetBillingResponsePlan(value);
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

    public static bool operator ==(AccountGetBillingResponsePlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountGetBillingResponsePlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountGetBillingResponsePlan value) => value.Value;

    public static explicit operator AccountGetBillingResponsePlan(string value) => new(value);

    internal class AccountGetBillingResponsePlanSerializer
        : JsonConverter<AccountGetBillingResponsePlan>
    {
        public override AccountGetBillingResponsePlan Read(
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
            return new AccountGetBillingResponsePlan(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountGetBillingResponsePlan value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountGetBillingResponsePlan ReadAsPropertyName(
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
            return new AccountGetBillingResponsePlan(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountGetBillingResponsePlan value,
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
