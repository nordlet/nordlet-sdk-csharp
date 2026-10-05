using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecognitionSchedulesListSalesRequestFilterItemOp.RecognitionSchedulesListSalesRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct RecognitionSchedulesListSalesRequestFilterItemOp : IStringEnum
{
    public static readonly RecognitionSchedulesListSalesRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly RecognitionSchedulesListSalesRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly RecognitionSchedulesListSalesRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly RecognitionSchedulesListSalesRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly RecognitionSchedulesListSalesRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly RecognitionSchedulesListSalesRequestFilterItemOp In = new(Values.In);

    public RecognitionSchedulesListSalesRequestFilterItemOp(string value)
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
    public static RecognitionSchedulesListSalesRequestFilterItemOp FromCustom(string value)
    {
        return new RecognitionSchedulesListSalesRequestFilterItemOp(value);
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
        RecognitionSchedulesListSalesRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecognitionSchedulesListSalesRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RecognitionSchedulesListSalesRequestFilterItemOp value
    ) => value.Value;

    public static explicit operator RecognitionSchedulesListSalesRequestFilterItemOp(
        string value
    ) => new(value);

    internal class RecognitionSchedulesListSalesRequestFilterItemOpSerializer
        : JsonConverter<RecognitionSchedulesListSalesRequestFilterItemOp>
    {
        public override RecognitionSchedulesListSalesRequestFilterItemOp Read(
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
            return new RecognitionSchedulesListSalesRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecognitionSchedulesListSalesRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecognitionSchedulesListSalesRequestFilterItemOp ReadAsPropertyName(
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
            return new RecognitionSchedulesListSalesRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecognitionSchedulesListSalesRequestFilterItemOp value,
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
