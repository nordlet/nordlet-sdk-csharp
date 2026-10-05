using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PlVatUeGenerateDeclarationsResponseTotalsItemSection.PlVatUeGenerateDeclarationsResponseTotalsItemSectionSerializer)
)]
[Serializable]
public readonly record struct PlVatUeGenerateDeclarationsResponseTotalsItemSection : IStringEnum
{
    public static readonly PlVatUeGenerateDeclarationsResponseTotalsItemSection C = new(Values.C);

    public static readonly PlVatUeGenerateDeclarationsResponseTotalsItemSection D = new(Values.D);

    public static readonly PlVatUeGenerateDeclarationsResponseTotalsItemSection E = new(Values.E);

    public PlVatUeGenerateDeclarationsResponseTotalsItemSection(string value)
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
    public static PlVatUeGenerateDeclarationsResponseTotalsItemSection FromCustom(string value)
    {
        return new PlVatUeGenerateDeclarationsResponseTotalsItemSection(value);
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
        PlVatUeGenerateDeclarationsResponseTotalsItemSection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlVatUeGenerateDeclarationsResponseTotalsItemSection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PlVatUeGenerateDeclarationsResponseTotalsItemSection value
    ) => value.Value;

    public static explicit operator PlVatUeGenerateDeclarationsResponseTotalsItemSection(
        string value
    ) => new(value);

    internal class PlVatUeGenerateDeclarationsResponseTotalsItemSectionSerializer
        : JsonConverter<PlVatUeGenerateDeclarationsResponseTotalsItemSection>
    {
        public override PlVatUeGenerateDeclarationsResponseTotalsItemSection Read(
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
            return new PlVatUeGenerateDeclarationsResponseTotalsItemSection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PlVatUeGenerateDeclarationsResponseTotalsItemSection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PlVatUeGenerateDeclarationsResponseTotalsItemSection ReadAsPropertyName(
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
            return new PlVatUeGenerateDeclarationsResponseTotalsItemSection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PlVatUeGenerateDeclarationsResponseTotalsItemSection value,
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
        public const string C = "C";

        public const string D = "D";

        public const string E = "E";
    }
}
