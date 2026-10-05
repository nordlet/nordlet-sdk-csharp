using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListPartnersResponseRowsItemLegalCountryClass.ListPartnersResponseRowsItemLegalCountryClassSerializer)
)]
[Serializable]
public readonly record struct ListPartnersResponseRowsItemLegalCountryClass : IStringEnum
{
    public static readonly ListPartnersResponseRowsItemLegalCountryClass Lt = new(Values.Lt);

    public static readonly ListPartnersResponseRowsItemLegalCountryClass Eu = new(Values.Eu);

    public static readonly ListPartnersResponseRowsItemLegalCountryClass NonEu = new(Values.NonEu);

    public ListPartnersResponseRowsItemLegalCountryClass(string value)
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
    public static ListPartnersResponseRowsItemLegalCountryClass FromCustom(string value)
    {
        return new ListPartnersResponseRowsItemLegalCountryClass(value);
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
        ListPartnersResponseRowsItemLegalCountryClass value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListPartnersResponseRowsItemLegalCountryClass value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListPartnersResponseRowsItemLegalCountryClass value) =>
        value.Value;

    public static explicit operator ListPartnersResponseRowsItemLegalCountryClass(string value) =>
        new(value);

    internal class ListPartnersResponseRowsItemLegalCountryClassSerializer
        : JsonConverter<ListPartnersResponseRowsItemLegalCountryClass>
    {
        public override ListPartnersResponseRowsItemLegalCountryClass Read(
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
            return new ListPartnersResponseRowsItemLegalCountryClass(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListPartnersResponseRowsItemLegalCountryClass value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListPartnersResponseRowsItemLegalCountryClass ReadAsPropertyName(
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
            return new ListPartnersResponseRowsItemLegalCountryClass(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListPartnersResponseRowsItemLegalCountryClass value,
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
        public const string Lt = "lt";

        public const string Eu = "eu";

        public const string NonEu = "non_eu";
    }
}
