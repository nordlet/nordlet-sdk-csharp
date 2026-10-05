using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SizeCategoryReportsResponseCategory.SizeCategoryReportsResponseCategorySerializer)
)]
[Serializable]
public readonly record struct SizeCategoryReportsResponseCategory : IStringEnum
{
    public static readonly SizeCategoryReportsResponseCategory Micro = new(Values.Micro);

    public static readonly SizeCategoryReportsResponseCategory Small = new(Values.Small);

    public static readonly SizeCategoryReportsResponseCategory Medium = new(Values.Medium);

    public static readonly SizeCategoryReportsResponseCategory Large = new(Values.Large);

    public SizeCategoryReportsResponseCategory(string value)
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
    public static SizeCategoryReportsResponseCategory FromCustom(string value)
    {
        return new SizeCategoryReportsResponseCategory(value);
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

    public static bool operator ==(SizeCategoryReportsResponseCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SizeCategoryReportsResponseCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SizeCategoryReportsResponseCategory value) =>
        value.Value;

    public static explicit operator SizeCategoryReportsResponseCategory(string value) => new(value);

    internal class SizeCategoryReportsResponseCategorySerializer
        : JsonConverter<SizeCategoryReportsResponseCategory>
    {
        public override SizeCategoryReportsResponseCategory Read(
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
            return new SizeCategoryReportsResponseCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SizeCategoryReportsResponseCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SizeCategoryReportsResponseCategory ReadAsPropertyName(
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
            return new SizeCategoryReportsResponseCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SizeCategoryReportsResponseCategory value,
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
