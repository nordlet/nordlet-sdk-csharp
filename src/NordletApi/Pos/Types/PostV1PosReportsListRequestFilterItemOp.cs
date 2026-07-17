using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PosReportsListRequestFilterItemOp.PostV1PosReportsListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1PosReportsListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1PosReportsListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1PosReportsListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1PosReportsListRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly PostV1PosReportsListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1PosReportsListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1PosReportsListRequestFilterItemOp In = new(Values.In);

    public PostV1PosReportsListRequestFilterItemOp(string value)
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
    public static PostV1PosReportsListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1PosReportsListRequestFilterItemOp(value);
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

    public static bool operator ==(PostV1PosReportsListRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1PosReportsListRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PosReportsListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1PosReportsListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1PosReportsListRequestFilterItemOpSerializer
        : JsonConverter<PostV1PosReportsListRequestFilterItemOp>
    {
        public override PostV1PosReportsListRequestFilterItemOp Read(
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
            return new PostV1PosReportsListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PosReportsListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PosReportsListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1PosReportsListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PosReportsListRequestFilterItemOp value,
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
