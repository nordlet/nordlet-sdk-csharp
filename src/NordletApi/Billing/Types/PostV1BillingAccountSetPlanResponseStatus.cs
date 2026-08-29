using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BillingAccountSetPlanResponseStatus.PostV1BillingAccountSetPlanResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1BillingAccountSetPlanResponseStatus : IStringEnum
{
    public static readonly PostV1BillingAccountSetPlanResponseStatus Trial = new(Values.Trial);

    public static readonly PostV1BillingAccountSetPlanResponseStatus Active = new(Values.Active);

    public static readonly PostV1BillingAccountSetPlanResponseStatus Suspended = new(
        Values.Suspended
    );

    public PostV1BillingAccountSetPlanResponseStatus(string value)
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
    public static PostV1BillingAccountSetPlanResponseStatus FromCustom(string value)
    {
        return new PostV1BillingAccountSetPlanResponseStatus(value);
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
        PostV1BillingAccountSetPlanResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BillingAccountSetPlanResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BillingAccountSetPlanResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1BillingAccountSetPlanResponseStatus(string value) =>
        new(value);

    internal class PostV1BillingAccountSetPlanResponseStatusSerializer
        : JsonConverter<PostV1BillingAccountSetPlanResponseStatus>
    {
        public override PostV1BillingAccountSetPlanResponseStatus Read(
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
            return new PostV1BillingAccountSetPlanResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BillingAccountSetPlanResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BillingAccountSetPlanResponseStatus ReadAsPropertyName(
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
            return new PostV1BillingAccountSetPlanResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BillingAccountSetPlanResponseStatus value,
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
