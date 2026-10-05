using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtSdFfdataDeclarationsRequestType.LtSdFfdataDeclarationsRequestTypeSerializer)
)]
[Serializable]
public readonly record struct LtSdFfdataDeclarationsRequestType : IStringEnum
{
    public static readonly LtSdFfdataDeclarationsRequestType OneSd = new(Values.OneSd);

    public static readonly LtSdFfdataDeclarationsRequestType TwoSd = new(Values.TwoSd);

    public LtSdFfdataDeclarationsRequestType(string value)
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
    public static LtSdFfdataDeclarationsRequestType FromCustom(string value)
    {
        return new LtSdFfdataDeclarationsRequestType(value);
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

    public static bool operator ==(LtSdFfdataDeclarationsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LtSdFfdataDeclarationsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LtSdFfdataDeclarationsRequestType value) => value.Value;

    public static explicit operator LtSdFfdataDeclarationsRequestType(string value) => new(value);

    internal class LtSdFfdataDeclarationsRequestTypeSerializer
        : JsonConverter<LtSdFfdataDeclarationsRequestType>
    {
        public override LtSdFfdataDeclarationsRequestType Read(
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
            return new LtSdFfdataDeclarationsRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtSdFfdataDeclarationsRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtSdFfdataDeclarationsRequestType ReadAsPropertyName(
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
            return new LtSdFfdataDeclarationsRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtSdFfdataDeclarationsRequestType value,
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
        public const string OneSd = "1-SD";

        public const string TwoSd = "2-SD";
    }
}
