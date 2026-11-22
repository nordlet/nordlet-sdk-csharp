using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbP11DItemsCreateDeclarationsRequestItemCarFuel.GbP11DItemsCreateDeclarationsRequestItemCarFuelSerializer)
)]
[Serializable]
public readonly record struct GbP11DItemsCreateDeclarationsRequestItemCarFuel : IStringEnum
{
    public static readonly GbP11DItemsCreateDeclarationsRequestItemCarFuel F = new(Values.F);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemCarFuel D = new(Values.D);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemCarFuel A = new(Values.A);

    public GbP11DItemsCreateDeclarationsRequestItemCarFuel(string value)
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
    public static GbP11DItemsCreateDeclarationsRequestItemCarFuel FromCustom(string value)
    {
        return new GbP11DItemsCreateDeclarationsRequestItemCarFuel(value);
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
        GbP11DItemsCreateDeclarationsRequestItemCarFuel value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbP11DItemsCreateDeclarationsRequestItemCarFuel value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GbP11DItemsCreateDeclarationsRequestItemCarFuel value) =>
        value.Value;

    public static explicit operator GbP11DItemsCreateDeclarationsRequestItemCarFuel(string value) =>
        new(value);

    internal class GbP11DItemsCreateDeclarationsRequestItemCarFuelSerializer
        : JsonConverter<GbP11DItemsCreateDeclarationsRequestItemCarFuel>
    {
        public override GbP11DItemsCreateDeclarationsRequestItemCarFuel Read(
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
            return new GbP11DItemsCreateDeclarationsRequestItemCarFuel(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItemCarFuel value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbP11DItemsCreateDeclarationsRequestItemCarFuel ReadAsPropertyName(
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
            return new GbP11DItemsCreateDeclarationsRequestItemCarFuel(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItemCarFuel value,
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
        public const string F = "F";

        public const string D = "D";

        public const string A = "A";
    }
}
