using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LtSdGenerateDeclarationsRequestType.LtSdGenerateDeclarationsRequestTypeSerializer)
)]
[Serializable]
public readonly record struct LtSdGenerateDeclarationsRequestType : IStringEnum
{
    public static readonly LtSdGenerateDeclarationsRequestType OneSd = new(Values.OneSd);

    public static readonly LtSdGenerateDeclarationsRequestType TwoSd = new(Values.TwoSd);

    public LtSdGenerateDeclarationsRequestType(string value)
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
    public static LtSdGenerateDeclarationsRequestType FromCustom(string value)
    {
        return new LtSdGenerateDeclarationsRequestType(value);
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

    public static bool operator ==(LtSdGenerateDeclarationsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LtSdGenerateDeclarationsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LtSdGenerateDeclarationsRequestType value) =>
        value.Value;

    public static explicit operator LtSdGenerateDeclarationsRequestType(string value) => new(value);

    internal class LtSdGenerateDeclarationsRequestTypeSerializer
        : JsonConverter<LtSdGenerateDeclarationsRequestType>
    {
        public override LtSdGenerateDeclarationsRequestType Read(
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
            return new LtSdGenerateDeclarationsRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LtSdGenerateDeclarationsRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LtSdGenerateDeclarationsRequestType ReadAsPropertyName(
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
            return new LtSdGenerateDeclarationsRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LtSdGenerateDeclarationsRequestType value,
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
