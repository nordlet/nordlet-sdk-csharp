using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrIncapacityCertificatesListRequestFilterItemOp.PostV1HrIncapacityCertificatesListRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PostV1HrIncapacityCertificatesListRequestFilterItemOp : IStringEnum
{
    public static readonly PostV1HrIncapacityCertificatesListRequestFilterItemOp Eq = new(
        Values.Eq
    );

    public static readonly PostV1HrIncapacityCertificatesListRequestFilterItemOp Ne = new(
        Values.Ne
    );

    public static readonly PostV1HrIncapacityCertificatesListRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly PostV1HrIncapacityCertificatesListRequestFilterItemOp Gte = new(
        Values.Gte
    );

    public static readonly PostV1HrIncapacityCertificatesListRequestFilterItemOp Lte = new(
        Values.Lte
    );

    public static readonly PostV1HrIncapacityCertificatesListRequestFilterItemOp In = new(
        Values.In
    );

    public PostV1HrIncapacityCertificatesListRequestFilterItemOp(string value)
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
    public static PostV1HrIncapacityCertificatesListRequestFilterItemOp FromCustom(string value)
    {
        return new PostV1HrIncapacityCertificatesListRequestFilterItemOp(value);
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
        PostV1HrIncapacityCertificatesListRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrIncapacityCertificatesListRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1HrIncapacityCertificatesListRequestFilterItemOp value
    ) => value.Value;

    public static explicit operator PostV1HrIncapacityCertificatesListRequestFilterItemOp(
        string value
    ) => new(value);

    internal class PostV1HrIncapacityCertificatesListRequestFilterItemOpSerializer
        : JsonConverter<PostV1HrIncapacityCertificatesListRequestFilterItemOp>
    {
        public override PostV1HrIncapacityCertificatesListRequestFilterItemOp Read(
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
            return new PostV1HrIncapacityCertificatesListRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrIncapacityCertificatesListRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrIncapacityCertificatesListRequestFilterItemOp ReadAsPropertyName(
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
            return new PostV1HrIncapacityCertificatesListRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrIncapacityCertificatesListRequestFilterItemOp value,
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
