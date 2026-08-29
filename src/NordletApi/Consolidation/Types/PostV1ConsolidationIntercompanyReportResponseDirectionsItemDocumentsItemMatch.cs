using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch.PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatchSerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch
    : IStringEnum
{
    public static readonly PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch Mirrored =
        new(Values.Mirrored);

    public static readonly PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch MatchedByNumber =
        new(Values.MatchedByNumber);

    public static readonly PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch Missing =
        new(Values.Missing);

    public PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch(
        string value
    )
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
    public static PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch FromCustom(
        string value
    )
    {
        return new PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch(
            value
        );
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
        PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch value
    ) => value.Value;

    public static explicit operator PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch(
        string value
    ) => new(value);

    internal class PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatchSerializer
        : JsonConverter<PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch>
    {
        public override PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch Read(
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
            return new PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch ReadAsPropertyName(
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
            return new PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch value,
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
        public const string Mirrored = "mirrored";

        public const string MatchedByNumber = "matched_by_number";

        public const string Missing = "missing";
    }
}
