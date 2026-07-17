using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceBanksListRequestFilterItemOp.PostV1ReferenceBanksListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceBanksListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1ReferenceBanksListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1ReferenceBanksListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1ReferenceBanksListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1ReferenceBanksListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1ReferenceBanksListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1ReferenceBanksListRequestFilterItemOp In = new(Values.In);

    public PostV1ReferenceBanksListRequestFilterItemOp(string value)
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
    public static PostV1ReferenceBanksListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1ReferenceBanksListRequestFilterItemOp(value);
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
        PostV1ReferenceBanksListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceBanksListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReferenceBanksListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1ReferenceBanksListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1ReferenceBanksListRequestFilterItemOpSerializer
        : JsonConverter<PostV1ReferenceBanksListRequestFilterItemOp>
    {
        public override PostV1ReferenceBanksListRequestFilterItemOp Read(
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
            return new PostV1ReferenceBanksListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceBanksListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceBanksListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1ReferenceBanksListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceBanksListRequestFilterItemOp value,
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
