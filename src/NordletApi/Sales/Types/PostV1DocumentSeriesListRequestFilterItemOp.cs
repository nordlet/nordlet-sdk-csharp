using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DocumentSeriesListRequestFilterItemOp.PostV1DocumentSeriesListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1DocumentSeriesListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1DocumentSeriesListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1DocumentSeriesListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1DocumentSeriesListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1DocumentSeriesListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1DocumentSeriesListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1DocumentSeriesListRequestFilterItemOp In = new(Values.In);

    public PostV1DocumentSeriesListRequestFilterItemOp(string value)
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
    public static PostV1DocumentSeriesListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1DocumentSeriesListRequestFilterItemOp(value);
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
        PostV1DocumentSeriesListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DocumentSeriesListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DocumentSeriesListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1DocumentSeriesListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1DocumentSeriesListRequestFilterItemOpSerializer
        : JsonConverter<PostV1DocumentSeriesListRequestFilterItemOp>
    {
        public override PostV1DocumentSeriesListRequestFilterItemOp Read(
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
            return new PostV1DocumentSeriesListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DocumentSeriesListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DocumentSeriesListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1DocumentSeriesListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DocumentSeriesListRequestFilterItemOp value,
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
