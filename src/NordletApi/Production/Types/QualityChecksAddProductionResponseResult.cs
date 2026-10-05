using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(QualityChecksAddProductionResponseResult.QualityChecksAddProductionResponseResultSerializer)
)]
[Serializable]
public readonly record struct QualityChecksAddProductionResponseResult : IStringEnum
{
    public static readonly QualityChecksAddProductionResponseResult Pending = new(Values.Pending);

    public static readonly QualityChecksAddProductionResponseResult Passed = new(Values.Passed);

    public static readonly QualityChecksAddProductionResponseResult Failed = new(Values.Failed);

    public QualityChecksAddProductionResponseResult(string value)
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
    public static QualityChecksAddProductionResponseResult FromCustom(string value)
    {
        return new QualityChecksAddProductionResponseResult(value);
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
        QualityChecksAddProductionResponseResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        QualityChecksAddProductionResponseResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(QualityChecksAddProductionResponseResult value) =>
        value.Value;

    public static explicit operator QualityChecksAddProductionResponseResult(string value) =>
        new(value);

    internal class QualityChecksAddProductionResponseResultSerializer
        : JsonConverter<QualityChecksAddProductionResponseResult>
    {
        public override QualityChecksAddProductionResponseResult Read(
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
            return new QualityChecksAddProductionResponseResult(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            QualityChecksAddProductionResponseResult value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override QualityChecksAddProductionResponseResult ReadAsPropertyName(
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
            return new QualityChecksAddProductionResponseResult(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            QualityChecksAddProductionResponseResult value,
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
