using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeEuerGetDeclarationsResponseRowsItemAnlage.DeEuerGetDeclarationsResponseRowsItemAnlageSerializer)
)]
[Serializable]
public readonly record struct DeEuerGetDeclarationsResponseRowsItemAnlage : IStringEnum
{
    public static readonly DeEuerGetDeclarationsResponseRowsItemAnlage Eur = new(Values.Eur);

    public static readonly DeEuerGetDeclarationsResponseRowsItemAnlage Aveur = new(Values.Aveur);

    public DeEuerGetDeclarationsResponseRowsItemAnlage(string value)
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
    public static DeEuerGetDeclarationsResponseRowsItemAnlage FromCustom(string value)
    {
        return new DeEuerGetDeclarationsResponseRowsItemAnlage(value);
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
        DeEuerGetDeclarationsResponseRowsItemAnlage value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeEuerGetDeclarationsResponseRowsItemAnlage value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DeEuerGetDeclarationsResponseRowsItemAnlage value) =>
        value.Value;

    public static explicit operator DeEuerGetDeclarationsResponseRowsItemAnlage(string value) =>
        new(value);

    internal class DeEuerGetDeclarationsResponseRowsItemAnlageSerializer
        : JsonConverter<DeEuerGetDeclarationsResponseRowsItemAnlage>
    {
        public override DeEuerGetDeclarationsResponseRowsItemAnlage Read(
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
            return new DeEuerGetDeclarationsResponseRowsItemAnlage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeEuerGetDeclarationsResponseRowsItemAnlage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeEuerGetDeclarationsResponseRowsItemAnlage ReadAsPropertyName(
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
            return new DeEuerGetDeclarationsResponseRowsItemAnlage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeEuerGetDeclarationsResponseRowsItemAnlage value,
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
        public const string Eur = "EÜR";

        public const string Aveur = "AVEÜR";
    }
}
