using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReportsSizeCategoryResponseCategory.PostV1ReportsSizeCategoryResponseCategorySerializer)
)]
[Serializable]
public readonly record struct PostV1ReportsSizeCategoryResponseCategory : IStringEnum
{
    public static readonly PostV1ReportsSizeCategoryResponseCategory Micro = new(Values.Micro);

    public static readonly PostV1ReportsSizeCategoryResponseCategory Small = new(Values.Small);

    public static readonly PostV1ReportsSizeCategoryResponseCategory Medium = new(Values.Medium);

    public static readonly PostV1ReportsSizeCategoryResponseCategory Large = new(Values.Large);

    public PostV1ReportsSizeCategoryResponseCategory(string value)
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
    public static PostV1ReportsSizeCategoryResponseCategory FromCustom(string value)
    {
        return new PostV1ReportsSizeCategoryResponseCategory(value);
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
        PostV1ReportsSizeCategoryResponseCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReportsSizeCategoryResponseCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReportsSizeCategoryResponseCategory value) =>
        value.Value;

    public static explicit operator PostV1ReportsSizeCategoryResponseCategory(string value) =>
        new(value);

    internal class PostV1ReportsSizeCategoryResponseCategorySerializer
        : JsonConverter<PostV1ReportsSizeCategoryResponseCategory>
    {
        public override PostV1ReportsSizeCategoryResponseCategory Read(
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
            return new PostV1ReportsSizeCategoryResponseCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReportsSizeCategoryResponseCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReportsSizeCategoryResponseCategory ReadAsPropertyName(
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
            return new PostV1ReportsSizeCategoryResponseCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReportsSizeCategoryResponseCategory value,
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
