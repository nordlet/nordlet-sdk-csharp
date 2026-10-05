using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReportConsolidationRequestCategory.ReportConsolidationRequestCategorySerializer)
)]
[Serializable]
public readonly record struct ReportConsolidationRequestCategory : IStringEnum
{
    public static readonly ReportConsolidationRequestCategory Micro = new(Values.Micro);

    public static readonly ReportConsolidationRequestCategory Small = new(Values.Small);

    public static readonly ReportConsolidationRequestCategory Medium = new(Values.Medium);

    public static readonly ReportConsolidationRequestCategory Large = new(Values.Large);

    public ReportConsolidationRequestCategory(string value)
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
    public static ReportConsolidationRequestCategory FromCustom(string value)
    {
        return new ReportConsolidationRequestCategory(value);
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

    public static bool operator ==(ReportConsolidationRequestCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportConsolidationRequestCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportConsolidationRequestCategory value) => value.Value;

    public static explicit operator ReportConsolidationRequestCategory(string value) => new(value);

    internal class ReportConsolidationRequestCategorySerializer
        : JsonConverter<ReportConsolidationRequestCategory>
    {
        public override ReportConsolidationRequestCategory Read(
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
            return new ReportConsolidationRequestCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReportConsolidationRequestCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReportConsolidationRequestCategory ReadAsPropertyName(
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
            return new ReportConsolidationRequestCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReportConsolidationRequestCategory value,
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
