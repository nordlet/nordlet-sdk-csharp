using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceEuVatRatesListResponseRowsItemSource.PostV1ReferenceEuVatRatesListResponseRowsItemSourceSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceEuVatRatesListResponseRowsItemSource : IStringEnum
{
    public static readonly PostV1ReferenceEuVatRatesListResponseRowsItemSource Default = new(
        Values.Default
    );

    public static readonly PostV1ReferenceEuVatRatesListResponseRowsItemSource Company = new(
        Values.Company
    );

    public PostV1ReferenceEuVatRatesListResponseRowsItemSource(string value)
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
    public static PostV1ReferenceEuVatRatesListResponseRowsItemSource FromCustom(string value)
    {
        return new PostV1ReferenceEuVatRatesListResponseRowsItemSource(value);
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
        PostV1ReferenceEuVatRatesListResponseRowsItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceEuVatRatesListResponseRowsItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ReferenceEuVatRatesListResponseRowsItemSource value
    ) => value.Value;

    public static explicit operator PostV1ReferenceEuVatRatesListResponseRowsItemSource(
        string value
    ) => new(value);

    internal class PostV1ReferenceEuVatRatesListResponseRowsItemSourceSerializer
        : JsonConverter<PostV1ReferenceEuVatRatesListResponseRowsItemSource>
    {
        public override PostV1ReferenceEuVatRatesListResponseRowsItemSource Read(
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
            return new PostV1ReferenceEuVatRatesListResponseRowsItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesListResponseRowsItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceEuVatRatesListResponseRowsItemSource ReadAsPropertyName(
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
            return new PostV1ReferenceEuVatRatesListResponseRowsItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesListResponseRowsItemSource value,
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
        public const string Default = "default";

        public const string Company = "company";
    }
}
