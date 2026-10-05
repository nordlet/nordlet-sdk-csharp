using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(QualityChecksListProductionResponseRowsItemResult.QualityChecksListProductionResponseRowsItemResultSerializer)
)]
[Serializable]
public readonly record struct QualityChecksListProductionResponseRowsItemResult : IStringEnum
{
    public static readonly QualityChecksListProductionResponseRowsItemResult Pending = new(
        Values.Pending
    );

    public static readonly QualityChecksListProductionResponseRowsItemResult Passed = new(
        Values.Passed
    );

    public static readonly QualityChecksListProductionResponseRowsItemResult Failed = new(
        Values.Failed
    );

    public QualityChecksListProductionResponseRowsItemResult(string value)
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
    public static QualityChecksListProductionResponseRowsItemResult FromCustom(string value)
    {
        return new QualityChecksListProductionResponseRowsItemResult(value);
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
        QualityChecksListProductionResponseRowsItemResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        QualityChecksListProductionResponseRowsItemResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        QualityChecksListProductionResponseRowsItemResult value
    ) => value.Value;

    public static explicit operator QualityChecksListProductionResponseRowsItemResult(
        string value
    ) => new(value);

    internal class QualityChecksListProductionResponseRowsItemResultSerializer
        : JsonConverter<QualityChecksListProductionResponseRowsItemResult>
    {
        public override QualityChecksListProductionResponseRowsItemResult Read(
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
            return new QualityChecksListProductionResponseRowsItemResult(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            QualityChecksListProductionResponseRowsItemResult value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override QualityChecksListProductionResponseRowsItemResult ReadAsPropertyName(
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
            return new QualityChecksListProductionResponseRowsItemResult(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            QualityChecksListProductionResponseRowsItemResult value,
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
