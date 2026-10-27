using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart.DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsartSerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart : IStringEnum
{
    public static readonly DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart One = new(
        Values.One
    );

    public static readonly DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart Two = new(
        Values.Two
    );

    public static readonly DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart Three = new(
        Values.Three
    );

    public DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart(string value)
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
    public static DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart FromCustom(string value)
    {
        return new DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart(value);
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
        DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart value
    ) => value.Value;

    public static explicit operator DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart(
        string value
    ) => new(value);

    internal class DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsartSerializer
        : JsonConverter<DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart>
    {
        public override DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart Read(
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
            return new DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart ReadAsPropertyName(
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
            return new DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsRequestFactsEuerEinkunftsart value,
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
