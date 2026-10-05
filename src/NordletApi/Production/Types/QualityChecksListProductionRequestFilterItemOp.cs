using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(QualityChecksListProductionRequestFilterItemOp.QualityChecksListProductionRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct QualityChecksListProductionRequestFilterItemOp : IStringEnum
{
    public static readonly QualityChecksListProductionRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly QualityChecksListProductionRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly QualityChecksListProductionRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly QualityChecksListProductionRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly QualityChecksListProductionRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly QualityChecksListProductionRequestFilterItemOp In = new(Values.In);

    public QualityChecksListProductionRequestFilterItemOp(string value)
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
    public static QualityChecksListProductionRequestFilterItemOp FromCustom(string value)
    {
        return new QualityChecksListProductionRequestFilterItemOp(value);
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
        QualityChecksListProductionRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        QualityChecksListProductionRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(QualityChecksListProductionRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator QualityChecksListProductionRequestFilterItemOp(string value) =>
        new(value);

    internal class QualityChecksListProductionRequestFilterItemOpSerializer
        : JsonConverter<QualityChecksListProductionRequestFilterItemOp>
    {
        public override QualityChecksListProductionRequestFilterItemOp Read(
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
            return new QualityChecksListProductionRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            QualityChecksListProductionRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override QualityChecksListProductionRequestFilterItemOp ReadAsPropertyName(
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
            return new QualityChecksListProductionRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            QualityChecksListProductionRequestFilterItemOp value,
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
        public const string Eq = "eq";

        public const string Ne = "ne";

        public const string Contains = "contains";

        public const string Gte = "gte";

        public const string Lte = "lte";

        public const string In = "in";
    }
}
