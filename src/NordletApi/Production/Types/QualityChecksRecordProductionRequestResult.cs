using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(QualityChecksRecordProductionRequestResult.QualityChecksRecordProductionRequestResultSerializer)
)]
[Serializable]
public readonly record struct QualityChecksRecordProductionRequestResult : IStringEnum
{
    public static readonly QualityChecksRecordProductionRequestResult Passed = new(Values.Passed);

    public static readonly QualityChecksRecordProductionRequestResult Failed = new(Values.Failed);

    public QualityChecksRecordProductionRequestResult(string value)
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
    public static QualityChecksRecordProductionRequestResult FromCustom(string value)
    {
        return new QualityChecksRecordProductionRequestResult(value);
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
        QualityChecksRecordProductionRequestResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        QualityChecksRecordProductionRequestResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(QualityChecksRecordProductionRequestResult value) =>
        value.Value;

    public static explicit operator QualityChecksRecordProductionRequestResult(string value) =>
        new(value);

    internal class QualityChecksRecordProductionRequestResultSerializer
        : JsonConverter<QualityChecksRecordProductionRequestResult>
    {
        public override QualityChecksRecordProductionRequestResult Read(
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
            return new QualityChecksRecordProductionRequestResult(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            QualityChecksRecordProductionRequestResult value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override QualityChecksRecordProductionRequestResult ReadAsPropertyName(
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
            return new QualityChecksRecordProductionRequestResult(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            QualityChecksRecordProductionRequestResult value,
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
        public const string Passed = "passed";

        public const string Failed = "failed";
    }
}
