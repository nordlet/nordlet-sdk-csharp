using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PlVatUeGenerateDeclarationsResponseRowsItemSection.PlVatUeGenerateDeclarationsResponseRowsItemSectionSerializer)
)]
[Serializable]
public readonly record struct PlVatUeGenerateDeclarationsResponseRowsItemSection : IStringEnum
{
    public static readonly PlVatUeGenerateDeclarationsResponseRowsItemSection C = new(Values.C);

    public static readonly PlVatUeGenerateDeclarationsResponseRowsItemSection D = new(Values.D);

    public static readonly PlVatUeGenerateDeclarationsResponseRowsItemSection E = new(Values.E);

    public PlVatUeGenerateDeclarationsResponseRowsItemSection(string value)
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
    public static PlVatUeGenerateDeclarationsResponseRowsItemSection FromCustom(string value)
    {
        return new PlVatUeGenerateDeclarationsResponseRowsItemSection(value);
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
        PlVatUeGenerateDeclarationsResponseRowsItemSection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlVatUeGenerateDeclarationsResponseRowsItemSection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PlVatUeGenerateDeclarationsResponseRowsItemSection value
    ) => value.Value;

    public static explicit operator PlVatUeGenerateDeclarationsResponseRowsItemSection(
        string value
    ) => new(value);

    internal class PlVatUeGenerateDeclarationsResponseRowsItemSectionSerializer
        : JsonConverter<PlVatUeGenerateDeclarationsResponseRowsItemSection>
    {
        public override PlVatUeGenerateDeclarationsResponseRowsItemSection Read(
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
            return new PlVatUeGenerateDeclarationsResponseRowsItemSection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PlVatUeGenerateDeclarationsResponseRowsItemSection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PlVatUeGenerateDeclarationsResponseRowsItemSection ReadAsPropertyName(
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
            return new PlVatUeGenerateDeclarationsResponseRowsItemSection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PlVatUeGenerateDeclarationsResponseRowsItemSection value,
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
