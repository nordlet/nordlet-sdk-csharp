using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SeriesListReferenceRequestFilterItemOp.SeriesListReferenceRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct SeriesListReferenceRequestFilterItemOp : IStringEnum
{
    public static readonly SeriesListReferenceRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly SeriesListReferenceRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly SeriesListReferenceRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly SeriesListReferenceRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly SeriesListReferenceRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly SeriesListReferenceRequestFilterItemOp In = new(Values.In);

    public SeriesListReferenceRequestFilterItemOp(string value)
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
    public static SeriesListReferenceRequestFilterItemOp FromCustom(string value)
    {
        return new SeriesListReferenceRequestFilterItemOp(value);
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

    public static bool operator ==(SeriesListReferenceRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SeriesListReferenceRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SeriesListReferenceRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator SeriesListReferenceRequestFilterItemOp(string value) =>
        new(value);

    internal class SeriesListReferenceRequestFilterItemOpSerializer
        : JsonConverter<SeriesListReferenceRequestFilterItemOp>
    {
        public override SeriesListReferenceRequestFilterItemOp Read(
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
            return new SeriesListReferenceRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SeriesListReferenceRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SeriesListReferenceRequestFilterItemOp ReadAsPropertyName(
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
            return new SeriesListReferenceRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SeriesListReferenceRequestFilterItemOp value,
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
