using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtSaftSendDeclarationsRequestDataType.LtSaftSendDeclarationsRequestDataTypeSerializer)
)]
[Serializable]
public readonly record struct LtSaftSendDeclarationsRequestDataType : IStringEnum
{
    public static readonly LtSaftSendDeclarationsRequestDataType F = new(Values.F);

    public static readonly LtSaftSendDeclarationsRequestDataType Gl = new(Values.Gl);

    public static readonly LtSaftSendDeclarationsRequestDataType Si = new(Values.Si);

    public static readonly LtSaftSendDeclarationsRequestDataType Pi = new(Values.Pi);

    public static readonly LtSaftSendDeclarationsRequestDataType Pa = new(Values.Pa);

    public static readonly LtSaftSendDeclarationsRequestDataType Mg = new(Values.Mg);

    public static readonly LtSaftSendDeclarationsRequestDataType As = new(Values.As);

    public LtSaftSendDeclarationsRequestDataType(string value)
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
    public static LtSaftSendDeclarationsRequestDataType FromCustom(string value)
    {
        return new LtSaftSendDeclarationsRequestDataType(value);
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

    public static bool operator ==(LtSaftSendDeclarationsRequestDataType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LtSaftSendDeclarationsRequestDataType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LtSaftSendDeclarationsRequestDataType value) =>
        value.Value;

    public static explicit operator LtSaftSendDeclarationsRequestDataType(string value) =>
        new(value);

    internal class LtSaftSendDeclarationsRequestDataTypeSerializer
        : JsonConverter<LtSaftSendDeclarationsRequestDataType>
    {
        public override LtSaftSendDeclarationsRequestDataType Read(
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
            return new LtSaftSendDeclarationsRequestDataType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtSaftSendDeclarationsRequestDataType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtSaftSendDeclarationsRequestDataType ReadAsPropertyName(
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
            return new LtSaftSendDeclarationsRequestDataType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtSaftSendDeclarationsRequestDataType value,
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
