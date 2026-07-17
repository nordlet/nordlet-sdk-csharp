using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1FilesListRequestFilterItemOp.PostV1FilesListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1FilesListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1FilesListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1FilesListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1FilesListRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly PostV1FilesListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1FilesListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1FilesListRequestFilterItemOp In = new(Values.In);

    public PostV1FilesListRequestFilterItemOp(string value)
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
    public static PostV1FilesListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1FilesListRequestFilterItemOp(value);
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

    public static bool operator ==(PostV1FilesListRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1FilesListRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1FilesListRequestFilterItemOp value) => value.Value;

    public static explicit operator PostV1FilesListRequestFilterItemOp(string value) => new(value);

    internal class PostV1FilesListRequestFilterItemOpSerializer
        : JsonConverter<PostV1FilesListRequestFilterItemOp>
    {
        public override PostV1FilesListRequestFilterItemOp Read(
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
            return new PostV1FilesListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1FilesListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1FilesListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1FilesListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1FilesListRequestFilterItemOp value,
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
