using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesUpdateResponseScheme.PostV1BankMandatesUpdateResponseSchemeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesUpdateResponseScheme : IStringEnum
{
    public static readonly PostV1BankMandatesUpdateResponseScheme Core = new(Values.Core);

    public static readonly PostV1BankMandatesUpdateResponseScheme B2B = new(Values.B2B);

    public PostV1BankMandatesUpdateResponseScheme(string value)
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
    public static PostV1BankMandatesUpdateResponseScheme FromCustom(string value)
    {
        return new PostV1BankMandatesUpdateResponseScheme(value);
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

    public static bool operator ==(PostV1BankMandatesUpdateResponseScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BankMandatesUpdateResponseScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankMandatesUpdateResponseScheme value) =>
        value.Value;

    public static explicit operator PostV1BankMandatesUpdateResponseScheme(string value) =>
        new(value);

    internal class PostV1BankMandatesUpdateResponseSchemeSerializer
        : JsonConverter<PostV1BankMandatesUpdateResponseScheme>
    {
        public override PostV1BankMandatesUpdateResponseScheme Read(
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
            return new PostV1BankMandatesUpdateResponseScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesUpdateResponseScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesUpdateResponseScheme ReadAsPropertyName(
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
            return new PostV1BankMandatesUpdateResponseScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesUpdateResponseScheme value,
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
