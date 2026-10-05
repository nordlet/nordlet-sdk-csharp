using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsCreateDeclarationsRequestDataType.SubmissionsCreateDeclarationsRequestDataTypeSerializer)
)]
[Serializable]
public readonly record struct SubmissionsCreateDeclarationsRequestDataType : IStringEnum
{
    public static readonly SubmissionsCreateDeclarationsRequestDataType F = new(Values.F);

    public static readonly SubmissionsCreateDeclarationsRequestDataType S = new(Values.S);

    public static readonly SubmissionsCreateDeclarationsRequestDataType P = new(Values.P);

    public SubmissionsCreateDeclarationsRequestDataType(string value)
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
    public static SubmissionsCreateDeclarationsRequestDataType FromCustom(string value)
    {
        return new SubmissionsCreateDeclarationsRequestDataType(value);
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
        SubmissionsCreateDeclarationsRequestDataType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsCreateDeclarationsRequestDataType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubmissionsCreateDeclarationsRequestDataType value) =>
        value.Value;

    public static explicit operator SubmissionsCreateDeclarationsRequestDataType(string value) =>
        new(value);

    internal class SubmissionsCreateDeclarationsRequestDataTypeSerializer
        : JsonConverter<SubmissionsCreateDeclarationsRequestDataType>
    {
        public override SubmissionsCreateDeclarationsRequestDataType Read(
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
            return new SubmissionsCreateDeclarationsRequestDataType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsCreateDeclarationsRequestDataType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsCreateDeclarationsRequestDataType ReadAsPropertyName(
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
            return new SubmissionsCreateDeclarationsRequestDataType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsCreateDeclarationsRequestDataType value,
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

        public const string S = "S";

        public const string P = "P";
    }
}
