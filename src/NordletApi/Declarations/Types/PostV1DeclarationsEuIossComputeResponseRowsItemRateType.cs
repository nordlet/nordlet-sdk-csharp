using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsEuIossComputeResponseRowsItemRateType.PostV1DeclarationsEuIossComputeResponseRowsItemRateTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsEuIossComputeResponseRowsItemRateType : IStringEnum
{
    public static readonly PostV1DeclarationsEuIossComputeResponseRowsItemRateType Standard = new(
        Values.Standard
    );

    public static readonly PostV1DeclarationsEuIossComputeResponseRowsItemRateType Reduced = new(
        Values.Reduced
    );

    public PostV1DeclarationsEuIossComputeResponseRowsItemRateType(string value)
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
    public static PostV1DeclarationsEuIossComputeResponseRowsItemRateType FromCustom(string value)
    {
        return new PostV1DeclarationsEuIossComputeResponseRowsItemRateType(value);
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
        PostV1DeclarationsEuIossComputeResponseRowsItemRateType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsEuIossComputeResponseRowsItemRateType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsEuIossComputeResponseRowsItemRateType value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsEuIossComputeResponseRowsItemRateType(
        string value
    ) => new(value);

    internal class PostV1DeclarationsEuIossComputeResponseRowsItemRateTypeSerializer
        : JsonConverter<PostV1DeclarationsEuIossComputeResponseRowsItemRateType>
    {
        public override PostV1DeclarationsEuIossComputeResponseRowsItemRateType Read(
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
            return new PostV1DeclarationsEuIossComputeResponseRowsItemRateType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsEuIossComputeResponseRowsItemRateType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsEuIossComputeResponseRowsItemRateType ReadAsPropertyName(
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
            return new PostV1DeclarationsEuIossComputeResponseRowsItemRateType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsEuIossComputeResponseRowsItemRateType value,
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
        public const string Standard = "STANDARD";

        public const string Reduced = "REDUCED";
    }
}
