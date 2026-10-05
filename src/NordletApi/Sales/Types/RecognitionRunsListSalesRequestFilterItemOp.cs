using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecognitionRunsListSalesRequestFilterItemOp.RecognitionRunsListSalesRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct RecognitionRunsListSalesRequestFilterItemOp : IStringEnum
{
    public static readonly RecognitionRunsListSalesRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly RecognitionRunsListSalesRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly RecognitionRunsListSalesRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly RecognitionRunsListSalesRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly RecognitionRunsListSalesRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly RecognitionRunsListSalesRequestFilterItemOp In = new(Values.In);

    public RecognitionRunsListSalesRequestFilterItemOp(string value)
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
    public static RecognitionRunsListSalesRequestFilterItemOp FromCustom(string value)
    {
        return new RecognitionRunsListSalesRequestFilterItemOp(value);
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
        RecognitionRunsListSalesRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecognitionRunsListSalesRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecognitionRunsListSalesRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator RecognitionRunsListSalesRequestFilterItemOp(string value) =>
        new(value);

    internal class RecognitionRunsListSalesRequestFilterItemOpSerializer
        : JsonConverter<RecognitionRunsListSalesRequestFilterItemOp>
    {
        public override RecognitionRunsListSalesRequestFilterItemOp Read(
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
            return new RecognitionRunsListSalesRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecognitionRunsListSalesRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecognitionRunsListSalesRequestFilterItemOp ReadAsPropertyName(
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
            return new RecognitionRunsListSalesRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecognitionRunsListSalesRequestFilterItemOp value,
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
