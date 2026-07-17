using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1EcommerceOrdersListRequestFilterItemOp.PostV1EcommerceOrdersListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1EcommerceOrdersListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1EcommerceOrdersListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1EcommerceOrdersListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1EcommerceOrdersListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1EcommerceOrdersListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1EcommerceOrdersListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1EcommerceOrdersListRequestFilterItemOp In = new(Values.In);

    public PostV1EcommerceOrdersListRequestFilterItemOp(string value)
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
    public static PostV1EcommerceOrdersListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1EcommerceOrdersListRequestFilterItemOp(value);
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
        PostV1EcommerceOrdersListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1EcommerceOrdersListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1EcommerceOrdersListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1EcommerceOrdersListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1EcommerceOrdersListRequestFilterItemOpSerializer
        : JsonConverter<PostV1EcommerceOrdersListRequestFilterItemOp>
    {
        public override PostV1EcommerceOrdersListRequestFilterItemOp Read(
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
            return new PostV1EcommerceOrdersListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1EcommerceOrdersListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1EcommerceOrdersListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1EcommerceOrdersListRequestFilterItemOp value,
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
