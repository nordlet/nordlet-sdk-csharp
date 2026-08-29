using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesCreateRequestScheme.PostV1BankMandatesCreateRequestSchemeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesCreateRequestScheme : IStringEnum
{
    public static readonly PostV1BankMandatesCreateRequestScheme Core = new(Values.Core);

    public static readonly PostV1BankMandatesCreateRequestScheme B2B = new(Values.B2B);

    public PostV1BankMandatesCreateRequestScheme(string value)
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
    public static PostV1BankMandatesCreateRequestScheme FromCustom(string value)
    {
        return new PostV1BankMandatesCreateRequestScheme(value);
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

    public static bool operator ==(PostV1BankMandatesCreateRequestScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BankMandatesCreateRequestScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankMandatesCreateRequestScheme value) =>
        value.Value;

    public static explicit operator PostV1BankMandatesCreateRequestScheme(string value) =>
        new(value);

    internal class PostV1BankMandatesCreateRequestSchemeSerializer
        : JsonConverter<PostV1BankMandatesCreateRequestScheme>
    {
        public override PostV1BankMandatesCreateRequestScheme Read(
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
            return new PostV1BankMandatesCreateRequestScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesCreateRequestScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesCreateRequestScheme ReadAsPropertyName(
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
            return new PostV1BankMandatesCreateRequestScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesCreateRequestScheme value,
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
