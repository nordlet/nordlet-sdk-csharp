using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart.DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsartSerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart
    : IStringEnum
{
    public static readonly DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart One = new(
        Values.One
    );

    public static readonly DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart Two = new(
        Values.Two
    );

    public static readonly DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart Three = new(
        Values.Three
    );

    public DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart(string value)
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
    public static DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart FromCustom(string value)
    {
        return new DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart(value);
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
        DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart value
    ) => value.Value;

    public static explicit operator DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart(
        string value
    ) => new(value);

    internal class DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsartSerializer
        : JsonConverter<DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart>
    {
        public override DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart Read(
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
            return new DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart ReadAsPropertyName(
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
            return new DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsResponseFactsEuerEinkunftsart value,
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
