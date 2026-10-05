using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvitesAcceptAccountRequestLocale.InvitesAcceptAccountRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct InvitesAcceptAccountRequestLocale : IStringEnum
{
    public static readonly InvitesAcceptAccountRequestLocale En = new(Values.En);

    public static readonly InvitesAcceptAccountRequestLocale Lt = new(Values.Lt);

    public static readonly InvitesAcceptAccountRequestLocale De = new(Values.De);

    public InvitesAcceptAccountRequestLocale(string value)
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
    public static InvitesAcceptAccountRequestLocale FromCustom(string value)
    {
        return new InvitesAcceptAccountRequestLocale(value);
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

    public static bool operator ==(InvitesAcceptAccountRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvitesAcceptAccountRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvitesAcceptAccountRequestLocale value) => value.Value;

    public static explicit operator InvitesAcceptAccountRequestLocale(string value) => new(value);

    internal class InvitesAcceptAccountRequestLocaleSerializer
        : JsonConverter<InvitesAcceptAccountRequestLocale>
    {
        public override InvitesAcceptAccountRequestLocale Read(
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
            return new InvitesAcceptAccountRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvitesAcceptAccountRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvitesAcceptAccountRequestLocale ReadAsPropertyName(
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
            return new InvitesAcceptAccountRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvitesAcceptAccountRequestLocale value,
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
        public const string En = "en";

        public const string Lt = "lt";

        public const string De = "de";
    }
}
