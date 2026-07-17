using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationReportResponseStatementsCategory.PostV1ConsolidationReportResponseStatementsCategorySerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationReportResponseStatementsCategory : IStringEnum
{
    public static readonly PostV1ConsolidationReportResponseStatementsCategory Micro = new(
        Values.Micro
    );

    public static readonly PostV1ConsolidationReportResponseStatementsCategory Small = new(
        Values.Small
    );

    public static readonly PostV1ConsolidationReportResponseStatementsCategory Medium = new(
        Values.Medium
    );

    public static readonly PostV1ConsolidationReportResponseStatementsCategory Large = new(
        Values.Large
    );

    public PostV1ConsolidationReportResponseStatementsCategory(string value)
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
    public static PostV1ConsolidationReportResponseStatementsCategory FromCustom(string value)
    {
        return new PostV1ConsolidationReportResponseStatementsCategory(value);
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
        PostV1ConsolidationReportResponseStatementsCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationReportResponseStatementsCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ConsolidationReportResponseStatementsCategory value
    ) => value.Value;

    public static explicit operator PostV1ConsolidationReportResponseStatementsCategory(
        string value
    ) => new(value);

    internal class PostV1ConsolidationReportResponseStatementsCategorySerializer
        : JsonConverter<PostV1ConsolidationReportResponseStatementsCategory>
    {
        public override PostV1ConsolidationReportResponseStatementsCategory Read(
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
            return new PostV1ConsolidationReportResponseStatementsCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationReportResponseStatementsCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationReportResponseStatementsCategory ReadAsPropertyName(
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
            return new PostV1ConsolidationReportResponseStatementsCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationReportResponseStatementsCategory value,
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
