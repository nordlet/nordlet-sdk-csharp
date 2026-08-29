using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionQualityChecksListResponseRowsItemResult.PostV1ProductionQualityChecksListResponseRowsItemResultSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionQualityChecksListResponseRowsItemResult : IStringEnum
{
    public static readonly PostV1ProductionQualityChecksListResponseRowsItemResult Pending = new(
        Values.Pending
    );

    public static readonly PostV1ProductionQualityChecksListResponseRowsItemResult Passed = new(
        Values.Passed
    );

    public static readonly PostV1ProductionQualityChecksListResponseRowsItemResult Failed = new(
        Values.Failed
    );

    public PostV1ProductionQualityChecksListResponseRowsItemResult(string value)
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
    public static PostV1ProductionQualityChecksListResponseRowsItemResult FromCustom(string value)
    {
        return new PostV1ProductionQualityChecksListResponseRowsItemResult(value);
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
        PostV1ProductionQualityChecksListResponseRowsItemResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionQualityChecksListResponseRowsItemResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ProductionQualityChecksListResponseRowsItemResult value
    ) => value.Value;

    public static explicit operator PostV1ProductionQualityChecksListResponseRowsItemResult(
        string value
    ) => new(value);

    internal class PostV1ProductionQualityChecksListResponseRowsItemResultSerializer
        : JsonConverter<PostV1ProductionQualityChecksListResponseRowsItemResult>
    {
        public override PostV1ProductionQualityChecksListResponseRowsItemResult Read(
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
            return new PostV1ProductionQualityChecksListResponseRowsItemResult(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksListResponseRowsItemResult value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionQualityChecksListResponseRowsItemResult ReadAsPropertyName(
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
            return new PostV1ProductionQualityChecksListResponseRowsItemResult(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksListResponseRowsItemResult value,
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
        public const string Pending = "pending";

        public const string Passed = "passed";

        public const string Failed = "failed";
    }
}
