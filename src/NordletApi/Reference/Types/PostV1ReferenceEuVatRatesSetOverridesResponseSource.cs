using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceEuVatRatesSetOverridesResponseSource.PostV1ReferenceEuVatRatesSetOverridesResponseSourceSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceEuVatRatesSetOverridesResponseSource : IStringEnum
{
    public static readonly PostV1ReferenceEuVatRatesSetOverridesResponseSource Default = new(
        Values.Default
    );

    public static readonly PostV1ReferenceEuVatRatesSetOverridesResponseSource Company = new(
        Values.Company
    );

    public PostV1ReferenceEuVatRatesSetOverridesResponseSource(string value)
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
    public static PostV1ReferenceEuVatRatesSetOverridesResponseSource FromCustom(string value)
    {
        return new PostV1ReferenceEuVatRatesSetOverridesResponseSource(value);
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
        PostV1ReferenceEuVatRatesSetOverridesResponseSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceEuVatRatesSetOverridesResponseSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ReferenceEuVatRatesSetOverridesResponseSource value
    ) => value.Value;

    public static explicit operator PostV1ReferenceEuVatRatesSetOverridesResponseSource(
        string value
    ) => new(value);

    internal class PostV1ReferenceEuVatRatesSetOverridesResponseSourceSerializer
        : JsonConverter<PostV1ReferenceEuVatRatesSetOverridesResponseSource>
    {
        public override PostV1ReferenceEuVatRatesSetOverridesResponseSource Read(
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
            return new PostV1ReferenceEuVatRatesSetOverridesResponseSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesSetOverridesResponseSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceEuVatRatesSetOverridesResponseSource ReadAsPropertyName(
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
            return new PostV1ReferenceEuVatRatesSetOverridesResponseSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesSetOverridesResponseSource value,
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
