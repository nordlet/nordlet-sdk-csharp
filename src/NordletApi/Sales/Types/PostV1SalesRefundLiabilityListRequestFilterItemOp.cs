using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesRefundLiabilityListRequestFilterItemOp.PostV1SalesRefundLiabilityListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesRefundLiabilityListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1SalesRefundLiabilityListRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PostV1SalesRefundLiabilityListRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PostV1SalesRefundLiabilityListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1SalesRefundLiabilityListRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PostV1SalesRefundLiabilityListRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PostV1SalesRefundLiabilityListRequestFilterItemOp In = new(Values.In);

    public PostV1SalesRefundLiabilityListRequestFilterItemOp(string value)
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
    public static PostV1SalesRefundLiabilityListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1SalesRefundLiabilityListRequestFilterItemOp(value);
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
        PostV1SalesRefundLiabilityListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesRefundLiabilityListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1SalesRefundLiabilityListRequestFilterItemOp value
    ) => value.Value;

    public static explicit operator PostV1SalesRefundLiabilityListRequestFilterItemOp(
        string value
    ) => new(value);

    internal class PostV1SalesRefundLiabilityListRequestFilterItemOpSerializer
        : JsonConverter<PostV1SalesRefundLiabilityListRequestFilterItemOp>
    {
        public override PostV1SalesRefundLiabilityListRequestFilterItemOp Read(
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
            return new PostV1SalesRefundLiabilityListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesRefundLiabilityListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesRefundLiabilityListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1SalesRefundLiabilityListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesRefundLiabilityListRequestFilterItemOp value,
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
