using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReportConsolidationResponseStatementsCategory.ReportConsolidationResponseStatementsCategorySerializer)
)]
[Serializable]
public readonly record struct ReportConsolidationResponseStatementsCategory : IStringEnum
{
    public static readonly ReportConsolidationResponseStatementsCategory Micro = new(Values.Micro);

    public static readonly ReportConsolidationResponseStatementsCategory Small = new(Values.Small);

    public static readonly ReportConsolidationResponseStatementsCategory Medium = new(
        Values.Medium
    );

    public static readonly ReportConsolidationResponseStatementsCategory Large = new(Values.Large);

    public ReportConsolidationResponseStatementsCategory(string value)
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
    public static ReportConsolidationResponseStatementsCategory FromCustom(string value)
    {
        return new ReportConsolidationResponseStatementsCategory(value);
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
        ReportConsolidationResponseStatementsCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReportConsolidationResponseStatementsCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ReportConsolidationResponseStatementsCategory value) =>
        value.Value;

    public static explicit operator ReportConsolidationResponseStatementsCategory(string value) =>
        new(value);

    internal class ReportConsolidationResponseStatementsCategorySerializer
        : JsonConverter<ReportConsolidationResponseStatementsCategory>
    {
        public override ReportConsolidationResponseStatementsCategory Read(
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
            return new ReportConsolidationResponseStatementsCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReportConsolidationResponseStatementsCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReportConsolidationResponseStatementsCategory ReadAsPropertyName(
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
            return new ReportConsolidationResponseStatementsCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReportConsolidationResponseStatementsCategory value,
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
