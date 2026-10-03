using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsLtSaftSendRequestDataType.PostV1DeclarationsLtSaftSendRequestDataTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsLtSaftSendRequestDataType : IStringEnum
{
    public static readonly PostV1DeclarationsLtSaftSendRequestDataType F = new(Values.F);

    public static readonly PostV1DeclarationsLtSaftSendRequestDataType Gl = new(Values.Gl);

    public static readonly PostV1DeclarationsLtSaftSendRequestDataType Si = new(Values.Si);

    public static readonly PostV1DeclarationsLtSaftSendRequestDataType Pi = new(Values.Pi);

    public static readonly PostV1DeclarationsLtSaftSendRequestDataType Pa = new(Values.Pa);

    public static readonly PostV1DeclarationsLtSaftSendRequestDataType Mg = new(Values.Mg);

    public static readonly PostV1DeclarationsLtSaftSendRequestDataType As = new(Values.As);

    public PostV1DeclarationsLtSaftSendRequestDataType(string value)
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
    public static PostV1DeclarationsLtSaftSendRequestDataType FromCustom(string value)
    {
        return new PostV1DeclarationsLtSaftSendRequestDataType(value);
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
        PostV1DeclarationsLtSaftSendRequestDataType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsLtSaftSendRequestDataType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsLtSaftSendRequestDataType value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsLtSaftSendRequestDataType(string value) =>
        new(value);

    internal class PostV1DeclarationsLtSaftSendRequestDataTypeSerializer
        : JsonConverter<PostV1DeclarationsLtSaftSendRequestDataType>
    {
        public override PostV1DeclarationsLtSaftSendRequestDataType Read(
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
            return new PostV1DeclarationsLtSaftSendRequestDataType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtSaftSendRequestDataType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsLtSaftSendRequestDataType ReadAsPropertyName(
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
            return new PostV1DeclarationsLtSaftSendRequestDataType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtSaftSendRequestDataType value,
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
        public const string F = "F";

        public const string Gl = "GL";

        public const string Si = "SI";

        public const string Pi = "PI";

        public const string Pa = "PA";

        public const string Mg = "MG";

        public const string As = "AS";
    }
}
