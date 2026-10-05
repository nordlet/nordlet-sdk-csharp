using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ListProjectsRequestFilterItemOp.ListProjectsRequestFilterItemOpSerializer))]
[Serializable]
public readonly record struct ListProjectsRequestFilterItemOp : IStringEnum
{
    public static readonly ListProjectsRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly ListProjectsRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly ListProjectsRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly ListProjectsRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly ListProjectsRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly ListProjectsRequestFilterItemOp In = new(Values.In);

    public ListProjectsRequestFilterItemOp(string value)
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
    public static ListProjectsRequestFilterItemOp FromCustom(string value)
    {
        return new ListProjectsRequestFilterItemOp(value);
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

    public static bool operator ==(ListProjectsRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListProjectsRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListProjectsRequestFilterItemOp value) => value.Value;

    public static explicit operator ListProjectsRequestFilterItemOp(string value) => new(value);

    internal class ListProjectsRequestFilterItemOpSerializer
        : JsonConverter<ListProjectsRequestFilterItemOp>
    {
        public override ListProjectsRequestFilterItemOp Read(
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
            return new ListProjectsRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListProjectsRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListProjectsRequestFilterItemOp ReadAsPropertyName(
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
            return new ListProjectsRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListProjectsRequestFilterItemOp value,
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
