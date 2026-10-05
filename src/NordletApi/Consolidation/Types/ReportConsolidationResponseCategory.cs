using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReportConsolidationResponseCategory.ReportConsolidationResponseCategorySerializer)
)]
[Serializable]
public readonly record struct ReportConsolidationResponseCategory : IStringEnum
{
    public static readonly ReportConsolidationResponseCategory Micro = new(Values.Micro);

    public static readonly ReportConsolidationResponseCategory Small = new(Values.Small);

    public static readonly ReportConsolidationResponseCategory Medium = new(Values.Medium);

    public static readonly ReportConsolidationResponseCategory Large = new(Values.Large);

    public ReportConsolidationResponseCategory(string value)
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
    public static ReportConsolidationResponseCategory FromCustom(string value)
    {
        return new ReportConsolidationResponseCategory(value);
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

    public static bool operator ==(ReportConsolidationResponseCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportConsolidationResponseCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportConsolidationResponseCategory value) =>
        value.Value;

    public static explicit operator ReportConsolidationResponseCategory(string value) => new(value);

    internal class ReportConsolidationResponseCategorySerializer
        : JsonConverter<ReportConsolidationResponseCategory>
    {
        public override ReportConsolidationResponseCategory Read(
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
            return new ReportConsolidationResponseCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReportConsolidationResponseCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReportConsolidationResponseCategory ReadAsPropertyName(
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
            return new ReportConsolidationResponseCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReportConsolidationResponseCategory value,
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
