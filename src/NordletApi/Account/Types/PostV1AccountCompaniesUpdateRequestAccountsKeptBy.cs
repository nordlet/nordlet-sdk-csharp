using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountCompaniesUpdateRequestAccountsKeptBy.PostV1AccountCompaniesUpdateRequestAccountsKeptBySerializer)
)]
[Serializable]
public readonly record struct PostV1AccountCompaniesUpdateRequestAccountsKeptBy : IStringEnum
{
    public static readonly PostV1AccountCompaniesUpdateRequestAccountsKeptBy Company = new(
        Values.Company
    );

    public static readonly PostV1AccountCompaniesUpdateRequestAccountsKeptBy External = new(
        Values.External
    );

    public PostV1AccountCompaniesUpdateRequestAccountsKeptBy(string value)
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
    public static PostV1AccountCompaniesUpdateRequestAccountsKeptBy FromCustom(string value)
    {
        return new PostV1AccountCompaniesUpdateRequestAccountsKeptBy(value);
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
        PostV1AccountCompaniesUpdateRequestAccountsKeptBy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AccountCompaniesUpdateRequestAccountsKeptBy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1AccountCompaniesUpdateRequestAccountsKeptBy value
    ) => value.Value;

    public static explicit operator PostV1AccountCompaniesUpdateRequestAccountsKeptBy(
        string value
    ) => new(value);

    internal class PostV1AccountCompaniesUpdateRequestAccountsKeptBySerializer
        : JsonConverter<PostV1AccountCompaniesUpdateRequestAccountsKeptBy>
    {
        public override PostV1AccountCompaniesUpdateRequestAccountsKeptBy Read(
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
            return new PostV1AccountCompaniesUpdateRequestAccountsKeptBy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountCompaniesUpdateRequestAccountsKeptBy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountCompaniesUpdateRequestAccountsKeptBy ReadAsPropertyName(
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
            return new PostV1AccountCompaniesUpdateRequestAccountsKeptBy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountCompaniesUpdateRequestAccountsKeptBy value,
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
        public const string Company = "company";

        public const string External = "external";
    }
}
