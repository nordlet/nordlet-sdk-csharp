using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesCreateResponseScheme.PostV1BankMandatesCreateResponseSchemeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesCreateResponseScheme : IStringEnum
{
    public static readonly PostV1BankMandatesCreateResponseScheme Core = new(Values.Core);

    public static readonly PostV1BankMandatesCreateResponseScheme B2B = new(Values.B2B);

    public PostV1BankMandatesCreateResponseScheme(string value)
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
    public static PostV1BankMandatesCreateResponseScheme FromCustom(string value)
    {
        return new PostV1BankMandatesCreateResponseScheme(value);
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

    public static bool operator ==(PostV1BankMandatesCreateResponseScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BankMandatesCreateResponseScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankMandatesCreateResponseScheme value) =>
        value.Value;

    public static explicit operator PostV1BankMandatesCreateResponseScheme(string value) =>
        new(value);

    internal class PostV1BankMandatesCreateResponseSchemeSerializer
        : JsonConverter<PostV1BankMandatesCreateResponseScheme>
    {
        public override PostV1BankMandatesCreateResponseScheme Read(
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
            return new PostV1BankMandatesCreateResponseScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesCreateResponseScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesCreateResponseScheme ReadAsPropertyName(
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
            return new PostV1BankMandatesCreateResponseScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesCreateResponseScheme value,
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
        public const string Core = "CORE";

        public const string B2B = "B2B";
    }
}
