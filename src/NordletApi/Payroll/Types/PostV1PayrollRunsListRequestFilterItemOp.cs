using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PayrollRunsListRequestFilterItemOp.PostV1PayrollRunsListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1PayrollRunsListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1PayrollRunsListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1PayrollRunsListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1PayrollRunsListRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly PostV1PayrollRunsListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1PayrollRunsListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1PayrollRunsListRequestFilterItemOp In = new(Values.In);

    public PostV1PayrollRunsListRequestFilterItemOp(string value)
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
    public static PostV1PayrollRunsListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1PayrollRunsListRequestFilterItemOp(value);
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
        PostV1PayrollRunsListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PayrollRunsListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PayrollRunsListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1PayrollRunsListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1PayrollRunsListRequestFilterItemOpSerializer
        : JsonConverter<PostV1PayrollRunsListRequestFilterItemOp>
    {
        public override PostV1PayrollRunsListRequestFilterItemOp Read(
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
            return new PostV1PayrollRunsListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PayrollRunsListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PayrollRunsListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1PayrollRunsListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PayrollRunsListRequestFilterItemOp value,
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
