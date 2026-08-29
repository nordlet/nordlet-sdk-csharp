using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BillingAccountSetPlanRequestPlan.PostV1BillingAccountSetPlanRequestPlanSerializer)
)]
[Serializable]
public readonly record struct PostV1BillingAccountSetPlanRequestPlan : IStringEnum
{
    public static readonly PostV1BillingAccountSetPlanRequestPlan Starter = new(Values.Starter);

    public static readonly PostV1BillingAccountSetPlanRequestPlan Business = new(Values.Business);

    public static readonly PostV1BillingAccountSetPlanRequestPlan Scale = new(Values.Scale);

    public PostV1BillingAccountSetPlanRequestPlan(string value)
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
    public static PostV1BillingAccountSetPlanRequestPlan FromCustom(string value)
    {
        return new PostV1BillingAccountSetPlanRequestPlan(value);
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

    public static bool operator ==(PostV1BillingAccountSetPlanRequestPlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BillingAccountSetPlanRequestPlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BillingAccountSetPlanRequestPlan value) =>
        value.Value;

    public static explicit operator PostV1BillingAccountSetPlanRequestPlan(string value) =>
        new(value);

    internal class PostV1BillingAccountSetPlanRequestPlanSerializer
        : JsonConverter<PostV1BillingAccountSetPlanRequestPlan>
    {
        public override PostV1BillingAccountSetPlanRequestPlan Read(
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
            return new PostV1BillingAccountSetPlanRequestPlan(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BillingAccountSetPlanRequestPlan value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BillingAccountSetPlanRequestPlan ReadAsPropertyName(
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
            return new PostV1BillingAccountSetPlanRequestPlan(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BillingAccountSetPlanRequestPlan value,
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
