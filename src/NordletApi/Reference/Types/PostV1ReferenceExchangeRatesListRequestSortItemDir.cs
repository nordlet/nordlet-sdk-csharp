using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceExchangeRatesListRequestSortItemDir.PostV1ReferenceExchangeRatesListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceExchangeRatesListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1ReferenceExchangeRatesListRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PostV1ReferenceExchangeRatesListRequestSortItemDir Desc = new(
        Values.Desc
    );

    public PostV1ReferenceExchangeRatesListRequestSortItemDir(string value)
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
    public static PostV1ReferenceExchangeRatesListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1ReferenceExchangeRatesListRequestSortItemDir(value);
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
        PostV1ReferenceExchangeRatesListRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceExchangeRatesListRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ReferenceExchangeRatesListRequestSortItemDir value
    ) => value.Value;

    public static explicit operator PostV1ReferenceExchangeRatesListRequestSortItemDir(
        string value
    ) => new(value);

    internal class PostV1ReferenceExchangeRatesListRequestSortItemDirSerializer
        : JsonConverter<PostV1ReferenceExchangeRatesListRequestSortItemDir>
    {
        public override PostV1ReferenceExchangeRatesListRequestSortItemDir Read(
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
            return new PostV1ReferenceExchangeRatesListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceExchangeRatesListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceExchangeRatesListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1ReferenceExchangeRatesListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceExchangeRatesListRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
