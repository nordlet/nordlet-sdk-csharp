using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(Us1099NecListDeclarationsResponseFormsItemNameType.Us1099NecListDeclarationsResponseFormsItemNameTypeSerializer)
)]
[Serializable]
public readonly record struct Us1099NecListDeclarationsResponseFormsItemNameType : IStringEnum
{
    public static readonly Us1099NecListDeclarationsResponseFormsItemNameType B = new(Values.B);

    public static readonly Us1099NecListDeclarationsResponseFormsItemNameType I = new(Values.I);

    public Us1099NecListDeclarationsResponseFormsItemNameType(string value)
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
    public static Us1099NecListDeclarationsResponseFormsItemNameType FromCustom(string value)
    {
        return new Us1099NecListDeclarationsResponseFormsItemNameType(value);
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
        Us1099NecListDeclarationsResponseFormsItemNameType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        Us1099NecListDeclarationsResponseFormsItemNameType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        Us1099NecListDeclarationsResponseFormsItemNameType value
    ) => value.Value;

    public static explicit operator Us1099NecListDeclarationsResponseFormsItemNameType(
        string value
    ) => new(value);

    internal class Us1099NecListDeclarationsResponseFormsItemNameTypeSerializer
        : JsonConverter<Us1099NecListDeclarationsResponseFormsItemNameType>
    {
        public override Us1099NecListDeclarationsResponseFormsItemNameType Read(
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
            return new Us1099NecListDeclarationsResponseFormsItemNameType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            Us1099NecListDeclarationsResponseFormsItemNameType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override Us1099NecListDeclarationsResponseFormsItemNameType ReadAsPropertyName(
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
            return new Us1099NecListDeclarationsResponseFormsItemNameType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            Us1099NecListDeclarationsResponseFormsItemNameType value,
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
        public const string B = "B";

        public const string I = "I";
    }
}
