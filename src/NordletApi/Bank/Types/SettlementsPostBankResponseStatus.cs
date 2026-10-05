using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SettlementsPostBankResponseStatus.SettlementsPostBankResponseStatusSerializer)
)]
[Serializable]
public readonly record struct SettlementsPostBankResponseStatus : IStringEnum
{
    public static readonly SettlementsPostBankResponseStatus Imported = new(Values.Imported);

    public static readonly SettlementsPostBankResponseStatus Posted = new(Values.Posted);

    public SettlementsPostBankResponseStatus(string value)
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
    public static SettlementsPostBankResponseStatus FromCustom(string value)
    {
        return new SettlementsPostBankResponseStatus(value);
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

    public static bool operator ==(SettlementsPostBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SettlementsPostBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SettlementsPostBankResponseStatus value) => value.Value;

    public static explicit operator SettlementsPostBankResponseStatus(string value) => new(value);

    internal class SettlementsPostBankResponseStatusSerializer
        : JsonConverter<SettlementsPostBankResponseStatus>
    {
        public override SettlementsPostBankResponseStatus Read(
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
            return new SettlementsPostBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SettlementsPostBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SettlementsPostBankResponseStatus ReadAsPropertyName(
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
            return new SettlementsPostBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SettlementsPostBankResponseStatus value,
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
