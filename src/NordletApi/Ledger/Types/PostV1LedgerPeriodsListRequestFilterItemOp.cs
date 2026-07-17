using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerPeriodsListRequestFilterItemOp.PostV1LedgerPeriodsListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerPeriodsListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1LedgerPeriodsListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1LedgerPeriodsListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1LedgerPeriodsListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1LedgerPeriodsListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1LedgerPeriodsListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1LedgerPeriodsListRequestFilterItemOp In = new(Values.In);

    public PostV1LedgerPeriodsListRequestFilterItemOp(string value)
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
    public static PostV1LedgerPeriodsListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1LedgerPeriodsListRequestFilterItemOp(value);
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
        PostV1LedgerPeriodsListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerPeriodsListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LedgerPeriodsListRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PostV1LedgerPeriodsListRequestFilterItemOp(string value) =>
        new(value);

    internal class PostV1LedgerPeriodsListRequestFilterItemOpSerializer
        : JsonConverter<PostV1LedgerPeriodsListRequestFilterItemOp>
    {
        public override PostV1LedgerPeriodsListRequestFilterItemOp Read(
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
            return new PostV1LedgerPeriodsListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerPeriodsListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerPeriodsListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1LedgerPeriodsListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerPeriodsListRequestFilterItemOp value,
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
