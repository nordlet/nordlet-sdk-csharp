using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankMandatesListResponseRowsItemScheme.PostV1BankMandatesListResponseRowsItemSchemeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankMandatesListResponseRowsItemScheme : IStringEnum
{
    public static readonly PostV1BankMandatesListResponseRowsItemScheme Core = new(Values.Core);

    public static readonly PostV1BankMandatesListResponseRowsItemScheme B2B = new(Values.B2B);

    public PostV1BankMandatesListResponseRowsItemScheme(string value)
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
    public static PostV1BankMandatesListResponseRowsItemScheme FromCustom(string value)
    {
        return new PostV1BankMandatesListResponseRowsItemScheme(value);
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
        PostV1BankMandatesListResponseRowsItemScheme value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankMandatesListResponseRowsItemScheme value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankMandatesListResponseRowsItemScheme value) =>
        value.Value;

    public static explicit operator PostV1BankMandatesListResponseRowsItemScheme(string value) =>
        new(value);

    internal class PostV1BankMandatesListResponseRowsItemSchemeSerializer
        : JsonConverter<PostV1BankMandatesListResponseRowsItemScheme>
    {
        public override PostV1BankMandatesListResponseRowsItemScheme Read(
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
            return new PostV1BankMandatesListResponseRowsItemScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankMandatesListResponseRowsItemScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankMandatesListResponseRowsItemScheme ReadAsPropertyName(
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
            return new PostV1BankMandatesListResponseRowsItemScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankMandatesListResponseRowsItemScheme value,
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
