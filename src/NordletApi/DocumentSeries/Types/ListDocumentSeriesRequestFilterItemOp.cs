using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListDocumentSeriesRequestFilterItemOp.ListDocumentSeriesRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct ListDocumentSeriesRequestFilterItemOp : IStringEnum
{
    public static readonly ListDocumentSeriesRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly ListDocumentSeriesRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly ListDocumentSeriesRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly ListDocumentSeriesRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly ListDocumentSeriesRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly ListDocumentSeriesRequestFilterItemOp In = new(Values.In);

    public ListDocumentSeriesRequestFilterItemOp(string value)
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
    public static ListDocumentSeriesRequestFilterItemOp FromCustom(string value)
    {
        return new ListDocumentSeriesRequestFilterItemOp(value);
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

    public static bool operator ==(ListDocumentSeriesRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListDocumentSeriesRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListDocumentSeriesRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator ListDocumentSeriesRequestFilterItemOp(string value) =>
        new(value);

    internal class ListDocumentSeriesRequestFilterItemOpSerializer
        : JsonConverter<ListDocumentSeriesRequestFilterItemOp>
    {
        public override ListDocumentSeriesRequestFilterItemOp Read(
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
            return new ListDocumentSeriesRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListDocumentSeriesRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListDocumentSeriesRequestFilterItemOp ReadAsPropertyName(
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
            return new ListDocumentSeriesRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListDocumentSeriesRequestFilterItemOp value,
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
