using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(SettlementsGetBankResponseStatus.SettlementsGetBankResponseStatusSerializer))]
[Serializable]
public readonly record struct SettlementsGetBankResponseStatus : IStringEnum
{
    public static readonly SettlementsGetBankResponseStatus Imported = new(Values.Imported);

    public static readonly SettlementsGetBankResponseStatus Posted = new(Values.Posted);

    public SettlementsGetBankResponseStatus(string value)
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
    public static SettlementsGetBankResponseStatus FromCustom(string value)
    {
        return new SettlementsGetBankResponseStatus(value);
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

    public static bool operator ==(SettlementsGetBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SettlementsGetBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SettlementsGetBankResponseStatus value) => value.Value;

    public static explicit operator SettlementsGetBankResponseStatus(string value) => new(value);

    internal class SettlementsGetBankResponseStatusSerializer
        : JsonConverter<SettlementsGetBankResponseStatus>
    {
        public override SettlementsGetBankResponseStatus Read(
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
            return new SettlementsGetBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SettlementsGetBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SettlementsGetBankResponseStatus ReadAsPropertyName(
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
            return new SettlementsGetBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SettlementsGetBankResponseStatus value,
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
