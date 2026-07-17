using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationReportRequestCategory.PostV1ConsolidationReportRequestCategorySerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationReportRequestCategory : IStringEnum
{
    public static readonly PostV1ConsolidationReportRequestCategory Micro = new(Values.Micro);

    public static readonly PostV1ConsolidationReportRequestCategory Small = new(Values.Small);

    public static readonly PostV1ConsolidationReportRequestCategory Medium = new(Values.Medium);

    public static readonly PostV1ConsolidationReportRequestCategory Large = new(Values.Large);

    public PostV1ConsolidationReportRequestCategory(string value)
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
    public static PostV1ConsolidationReportRequestCategory FromCustom(string value)
    {
        return new PostV1ConsolidationReportRequestCategory(value);
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
        PostV1ConsolidationReportRequestCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationReportRequestCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ConsolidationReportRequestCategory value) =>
        value.Value;

    public static explicit operator PostV1ConsolidationReportRequestCategory(string value) =>
        new(value);

    internal class PostV1ConsolidationReportRequestCategorySerializer
        : JsonConverter<PostV1ConsolidationReportRequestCategory>
    {
        public override PostV1ConsolidationReportRequestCategory Read(
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
            return new PostV1ConsolidationReportRequestCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationReportRequestCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationReportRequestCategory ReadAsPropertyName(
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
            return new PostV1ConsolidationReportRequestCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationReportRequestCategory value,
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
        public const string Micro = "micro";

        public const string Small = "small";

        public const string Medium = "medium";

        public const string Large = "large";
    }
}
