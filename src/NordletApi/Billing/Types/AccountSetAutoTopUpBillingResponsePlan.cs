using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AccountSetAutoTopUpBillingResponsePlan.AccountSetAutoTopUpBillingResponsePlanSerializer)
)]
[Serializable]
public readonly record struct AccountSetAutoTopUpBillingResponsePlan : IStringEnum
{
    public static readonly AccountSetAutoTopUpBillingResponsePlan Starter = new(Values.Starter);

    public static readonly AccountSetAutoTopUpBillingResponsePlan Business = new(Values.Business);

    public static readonly AccountSetAutoTopUpBillingResponsePlan Scale = new(Values.Scale);

    public AccountSetAutoTopUpBillingResponsePlan(string value)
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
    public static AccountSetAutoTopUpBillingResponsePlan FromCustom(string value)
    {
        return new AccountSetAutoTopUpBillingResponsePlan(value);
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

    public static bool operator ==(AccountSetAutoTopUpBillingResponsePlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountSetAutoTopUpBillingResponsePlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountSetAutoTopUpBillingResponsePlan value) =>
        value.Value;

    public static explicit operator AccountSetAutoTopUpBillingResponsePlan(string value) =>
        new(value);

    internal class AccountSetAutoTopUpBillingResponsePlanSerializer
        : JsonConverter<AccountSetAutoTopUpBillingResponsePlan>
    {
        public override AccountSetAutoTopUpBillingResponsePlan Read(
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
            return new AccountSetAutoTopUpBillingResponsePlan(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AccountSetAutoTopUpBillingResponsePlan value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AccountSetAutoTopUpBillingResponsePlan ReadAsPropertyName(
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
            return new AccountSetAutoTopUpBillingResponsePlan(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AccountSetAutoTopUpBillingResponsePlan value,
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
