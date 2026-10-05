using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtSaftGenerateDeclarationsRequestDataType.LtSaftGenerateDeclarationsRequestDataTypeSerializer)
)]
[Serializable]
public readonly record struct LtSaftGenerateDeclarationsRequestDataType : IStringEnum
{
    public static readonly LtSaftGenerateDeclarationsRequestDataType F = new(Values.F);

    public static readonly LtSaftGenerateDeclarationsRequestDataType Gl = new(Values.Gl);

    public static readonly LtSaftGenerateDeclarationsRequestDataType Si = new(Values.Si);

    public static readonly LtSaftGenerateDeclarationsRequestDataType Pi = new(Values.Pi);

    public static readonly LtSaftGenerateDeclarationsRequestDataType Pa = new(Values.Pa);

    public static readonly LtSaftGenerateDeclarationsRequestDataType Mg = new(Values.Mg);

    public static readonly LtSaftGenerateDeclarationsRequestDataType As = new(Values.As);

    public LtSaftGenerateDeclarationsRequestDataType(string value)
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
    public static LtSaftGenerateDeclarationsRequestDataType FromCustom(string value)
    {
        return new LtSaftGenerateDeclarationsRequestDataType(value);
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
        LtSaftGenerateDeclarationsRequestDataType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LtSaftGenerateDeclarationsRequestDataType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LtSaftGenerateDeclarationsRequestDataType value) =>
        value.Value;

    public static explicit operator LtSaftGenerateDeclarationsRequestDataType(string value) =>
        new(value);

    internal class LtSaftGenerateDeclarationsRequestDataTypeSerializer
        : JsonConverter<LtSaftGenerateDeclarationsRequestDataType>
    {
        public override LtSaftGenerateDeclarationsRequestDataType Read(
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
            return new LtSaftGenerateDeclarationsRequestDataType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtSaftGenerateDeclarationsRequestDataType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtSaftGenerateDeclarationsRequestDataType ReadAsPropertyName(
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
            return new LtSaftGenerateDeclarationsRequestDataType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtSaftGenerateDeclarationsRequestDataType value,
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

        public const string Gl = "GL";

        public const string Si = "SI";

        public const string Pi = "PI";

        public const string Pa = "PA";

        public const string Mg = "MG";

        public const string As = "AS";
    }
}
