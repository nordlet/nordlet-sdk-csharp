using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SettlementsUnlinkBankResponseStatus.SettlementsUnlinkBankResponseStatusSerializer)
)]
[Serializable]
public readonly record struct SettlementsUnlinkBankResponseStatus : IStringEnum
{
    public static readonly SettlementsUnlinkBankResponseStatus Imported = new(Values.Imported);

    public static readonly SettlementsUnlinkBankResponseStatus Posted = new(Values.Posted);

    public SettlementsUnlinkBankResponseStatus(string value)
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
    public static SettlementsUnlinkBankResponseStatus FromCustom(string value)
    {
        return new SettlementsUnlinkBankResponseStatus(value);
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

    public static bool operator ==(SettlementsUnlinkBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SettlementsUnlinkBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SettlementsUnlinkBankResponseStatus value) =>
        value.Value;

    public static explicit operator SettlementsUnlinkBankResponseStatus(string value) => new(value);

    internal class SettlementsUnlinkBankResponseStatusSerializer
        : JsonConverter<SettlementsUnlinkBankResponseStatus>
    {
        public override SettlementsUnlinkBankResponseStatus Read(
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
            return new SettlementsUnlinkBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SettlementsUnlinkBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SettlementsUnlinkBankResponseStatus ReadAsPropertyName(
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
            return new SettlementsUnlinkBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SettlementsUnlinkBankResponseStatus value,
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
        public const string Imported = "imported";

        public const string Posted = "posted";
    }
}
