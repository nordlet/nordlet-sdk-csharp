using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrPositionsListRequestFilterItemOp.PostV1HrPositionsListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1HrPositionsListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1HrPositionsListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1HrPositionsListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1HrPositionsListRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly PostV1HrPositionsListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1HrPositionsListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1HrPositionsListRequestFilterItemOp In = new(Values.In);

    public PostV1HrPositionsListRequestFilterItemOp(string value)
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
    public static PostV1HrPositionsListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1HrPositionsListRequestFilterItemOp(value);
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
        PostV1HrPositionsListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrPositionsListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrPositionsListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1HrPositionsListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1HrPositionsListRequestFilterItemOpSerializer
        : JsonConverter<PostV1HrPositionsListRequestFilterItemOp>
    {
        public override PostV1HrPositionsListRequestFilterItemOp Read(
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
            return new PostV1HrPositionsListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrPositionsListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrPositionsListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1HrPositionsListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrPositionsListRequestFilterItemOp value,
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
