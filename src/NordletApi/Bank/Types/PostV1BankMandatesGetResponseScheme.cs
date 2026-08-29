using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesGetResponseScheme.PostV1BankMandatesGetResponseSchemeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesGetResponseScheme : IStringEnum
{
    public static readonly PostV1BankMandatesGetResponseScheme Core = new(Values.Core);

    public static readonly PostV1BankMandatesGetResponseScheme B2B = new(Values.B2B);

    public PostV1BankMandatesGetResponseScheme(string value)
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
    public static PostV1BankMandatesGetResponseScheme FromCustom(string value)
    {
        return new PostV1BankMandatesGetResponseScheme(value);
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

    public static bool operator ==(PostV1BankMandatesGetResponseScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1BankMandatesGetResponseScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankMandatesGetResponseScheme value) =>
        value.Value;

    public static explicit operator PostV1BankMandatesGetResponseScheme(string value) => new(value);

    internal class PostV1BankMandatesGetResponseSchemeSerializer
        : JsonConverter<PostV1BankMandatesGetResponseScheme>
    {
        public override PostV1BankMandatesGetResponseScheme Read(
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
            return new PostV1BankMandatesGetResponseScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesGetResponseScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesGetResponseScheme ReadAsPropertyName(
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
            return new PostV1BankMandatesGetResponseScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesGetResponseScheme value,
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
