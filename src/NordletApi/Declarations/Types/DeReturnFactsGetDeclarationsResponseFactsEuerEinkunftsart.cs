using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart.DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsartSerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart
    : IStringEnum
{
    public static readonly DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart One = new(
        Values.One
    );

    public static readonly DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart Two = new(
        Values.Two
    );

    public static readonly DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart Three = new(
        Values.Three
    );

    public DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart(string value)
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
    public static DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart FromCustom(string value)
    {
        return new DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart(value);
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
        DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart value
    ) => value.Value;

    public static explicit operator DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart(
        string value
    ) => new(value);

    internal class DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsartSerializer
        : JsonConverter<DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart>
    {
        public override DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart Read(
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
            return new DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart ReadAsPropertyName(
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
            return new DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsGetDeclarationsResponseFactsEuerEinkunftsart value,
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
        public const string One = "1";

        public const string Two = "2";

        public const string Three = "3";
    }
}
