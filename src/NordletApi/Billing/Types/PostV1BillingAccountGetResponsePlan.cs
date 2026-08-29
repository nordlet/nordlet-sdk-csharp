using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BillingAccountGetResponsePlan.PostV1BillingAccountGetResponsePlanSerializer)
)]
[Serializable]
public readonly record struct PostV1BillingAccountGetResponsePlan : IStringEnum
{
    public static readonly PostV1BillingAccountGetResponsePlan Starter = new(Values.Starter);

    public static readonly PostV1BillingAccountGetResponsePlan Business = new(Values.Business);

    public static readonly PostV1BillingAccountGetResponsePlan Scale = new(Values.Scale);

    public PostV1BillingAccountGetResponsePlan(string value)
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
    public static PostV1BillingAccountGetResponsePlan FromCustom(string value)
    {
        return new PostV1BillingAccountGetResponsePlan(value);
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

    public static bool operator ==(PostV1BillingAccountGetResponsePlan value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BillingAccountGetResponsePlan value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BillingAccountGetResponsePlan value) =>
        value.Value;

    public static explicit operator PostV1BillingAccountGetResponsePlan(string value) => new(value);

    internal class PostV1BillingAccountGetResponsePlanSerializer
        : JsonConverter<PostV1BillingAccountGetResponsePlan>
    {
        public override PostV1BillingAccountGetResponsePlan Read(
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
            return new PostV1BillingAccountGetResponsePlan(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BillingAccountGetResponsePlan value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BillingAccountGetResponsePlan ReadAsPropertyName(
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
            return new PostV1BillingAccountGetResponsePlan(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BillingAccountGetResponsePlan value,
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
