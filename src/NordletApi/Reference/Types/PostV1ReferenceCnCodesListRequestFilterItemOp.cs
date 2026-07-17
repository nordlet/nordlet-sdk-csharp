using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceCnCodesListRequestFilterItemOp.PostV1ReferenceCnCodesListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceCnCodesListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1ReferenceCnCodesListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1ReferenceCnCodesListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1ReferenceCnCodesListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1ReferenceCnCodesListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1ReferenceCnCodesListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1ReferenceCnCodesListRequestFilterItemOp In = new(Values.In);

    public PostV1ReferenceCnCodesListRequestFilterItemOp(string value)
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
    public static PostV1ReferenceCnCodesListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1ReferenceCnCodesListRequestFilterItemOp(value);
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
        PostV1ReferenceCnCodesListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceCnCodesListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReferenceCnCodesListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1ReferenceCnCodesListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1ReferenceCnCodesListRequestFilterItemOpSerializer
        : JsonConverter<PostV1ReferenceCnCodesListRequestFilterItemOp>
    {
        public override PostV1ReferenceCnCodesListRequestFilterItemOp Read(
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
            return new PostV1ReferenceCnCodesListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceCnCodesListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceCnCodesListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1ReferenceCnCodesListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceCnCodesListRequestFilterItemOp value,
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
