using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(FlatRateCreateBillingRequestPlan.FlatRateCreateBillingRequestPlanSerializer))]
[Serializable]
public readonly record struct FlatRateCreateBillingRequestPlan : IStringEnum
{
    public static readonly FlatRateCreateBillingRequestPlan Starter = new(Values.Starter);

    public static readonly FlatRateCreateBillingRequestPlan Business = new(Values.Business);

    public static readonly FlatRateCreateBillingRequestPlan Scale = new(Values.Scale);

    public FlatRateCreateBillingRequestPlan(string value)
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
    public static FlatRateCreateBillingRequestPlan FromCustom(string value)
    {
        return new FlatRateCreateBillingRequestPlan(value);
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

    public static bool operator ==(FlatRateCreateBillingRequestPlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FlatRateCreateBillingRequestPlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FlatRateCreateBillingRequestPlan value) => value.Value;

    public static explicit operator FlatRateCreateBillingRequestPlan(string value) => new(value);

    internal class FlatRateCreateBillingRequestPlanSerializer
        : JsonConverter<FlatRateCreateBillingRequestPlan>
    {
        public override FlatRateCreateBillingRequestPlan Read(
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
            return new FlatRateCreateBillingRequestPlan(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FlatRateCreateBillingRequestPlan value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FlatRateCreateBillingRequestPlan ReadAsPropertyName(
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
            return new FlatRateCreateBillingRequestPlan(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FlatRateCreateBillingRequestPlan value,
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
