using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountLocaleSetResponseScope.PostV1AccountLocaleSetResponseScopeSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountLocaleSetResponseScope : IStringEnum
{
    public static readonly PostV1AccountLocaleSetResponseScope Membership = new(Values.Membership);

    public static readonly PostV1AccountLocaleSetResponseScope User = new(Values.User);

    public PostV1AccountLocaleSetResponseScope(string value)
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
    public static PostV1AccountLocaleSetResponseScope FromCustom(string value)
    {
        return new PostV1AccountLocaleSetResponseScope(value);
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

    public static bool operator ==(PostV1AccountLocaleSetResponseScope value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1AccountLocaleSetResponseScope value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountLocaleSetResponseScope value) =>
        value.Value;

    public static explicit operator PostV1AccountLocaleSetResponseScope(string value) => new(value);

    internal class PostV1AccountLocaleSetResponseScopeSerializer
        : JsonConverter<PostV1AccountLocaleSetResponseScope>
    {
        public override PostV1AccountLocaleSetResponseScope Read(
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
            return new PostV1AccountLocaleSetResponseScope(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountLocaleSetResponseScope value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountLocaleSetResponseScope ReadAsPropertyName(
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
            return new PostV1AccountLocaleSetResponseScope(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountLocaleSetResponseScope value,
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
        public const string Membership = "membership";

        public const string User = "user";
    }
}
