using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionQualityChecksListRequestFilterItemOp.PostV1ProductionQualityChecksListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionQualityChecksListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1ProductionQualityChecksListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1ProductionQualityChecksListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1ProductionQualityChecksListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1ProductionQualityChecksListRequestFilterItemOp Gte = new(
        Values.Gte
    );

    public static readonly PostV1ProductionQualityChecksListRequestFilterItemOp Lte = new(
        Values.Lte
    );

    public static readonly PostV1ProductionQualityChecksListRequestFilterItemOp In = new(Values.In);

    public PostV1ProductionQualityChecksListRequestFilterItemOp(string value)
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
    public static PostV1ProductionQualityChecksListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1ProductionQualityChecksListRequestFilterItemOp(value);
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
        PostV1ProductionQualityChecksListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionQualityChecksListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ProductionQualityChecksListRequestFilterItemOp value
    ) => value.Value;

    public static explicit operator PostV1ProductionQualityChecksListRequestFilterItemOp(
        string value
    ) => new(value);

    internal class PostV1ProductionQualityChecksListRequestFilterItemOpSerializer
        : JsonConverter<PostV1ProductionQualityChecksListRequestFilterItemOp>
    {
        public override PostV1ProductionQualityChecksListRequestFilterItemOp Read(
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
            return new PostV1ProductionQualityChecksListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionQualityChecksListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1ProductionQualityChecksListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionQualityChecksListRequestFilterItemOp value,
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
