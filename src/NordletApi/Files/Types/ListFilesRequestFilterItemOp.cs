using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ListFilesRequestFilterItemOp.ListFilesRequestFilterItemOpSerializer))]
[Serializable]
public readonly record struct ListFilesRequestFilterItemOp : IStringEnum
{
    public static readonly ListFilesRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly ListFilesRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly ListFilesRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly ListFilesRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly ListFilesRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly ListFilesRequestFilterItemOp In = new(Values.In);

    public ListFilesRequestFilterItemOp(string value)
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
    public static ListFilesRequestFilterItemOp FromCustom(string value)
    {
        return new ListFilesRequestFilterItemOp(value);
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

    public static bool operator ==(ListFilesRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListFilesRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListFilesRequestFilterItemOp value) => value.Value;

    public static explicit operator ListFilesRequestFilterItemOp(string value) => new(value);

    internal class ListFilesRequestFilterItemOpSerializer
        : JsonConverter<ListFilesRequestFilterItemOp>
    {
        public override ListFilesRequestFilterItemOp Read(
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
            return new ListFilesRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListFilesRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListFilesRequestFilterItemOp ReadAsPropertyName(
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
            return new ListFilesRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListFilesRequestFilterItemOp value,
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
