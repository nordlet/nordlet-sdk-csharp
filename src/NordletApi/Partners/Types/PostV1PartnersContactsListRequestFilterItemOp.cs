using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersContactsListRequestFilterItemOp.PostV1PartnersContactsListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersContactsListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1PartnersContactsListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1PartnersContactsListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1PartnersContactsListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1PartnersContactsListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1PartnersContactsListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1PartnersContactsListRequestFilterItemOp In = new(Values.In);

    public PostV1PartnersContactsListRequestFilterItemOp(string value)
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
    public static PostV1PartnersContactsListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1PartnersContactsListRequestFilterItemOp(value);
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
        PostV1PartnersContactsListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PartnersContactsListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersContactsListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1PartnersContactsListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1PartnersContactsListRequestFilterItemOpSerializer
        : JsonConverter<PostV1PartnersContactsListRequestFilterItemOp>
    {
        public override PostV1PartnersContactsListRequestFilterItemOp Read(
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
            return new PostV1PartnersContactsListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersContactsListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersContactsListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1PartnersContactsListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersContactsListRequestFilterItemOp value,
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
