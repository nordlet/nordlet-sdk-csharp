using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvitesCreateAccountRequestLocale.InvitesCreateAccountRequestLocaleSerializer)
)]
[Serializable]
public readonly record struct InvitesCreateAccountRequestLocale : IStringEnum
{
    public static readonly InvitesCreateAccountRequestLocale En = new(Values.En);

    public static readonly InvitesCreateAccountRequestLocale Lt = new(Values.Lt);

    public static readonly InvitesCreateAccountRequestLocale De = new(Values.De);

    public InvitesCreateAccountRequestLocale(string value)
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
    public static InvitesCreateAccountRequestLocale FromCustom(string value)
    {
        return new InvitesCreateAccountRequestLocale(value);
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

    public static bool operator ==(InvitesCreateAccountRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvitesCreateAccountRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvitesCreateAccountRequestLocale value) => value.Value;

    public static explicit operator InvitesCreateAccountRequestLocale(string value) => new(value);

    internal class InvitesCreateAccountRequestLocaleSerializer
        : JsonConverter<InvitesCreateAccountRequestLocale>
    {
        public override InvitesCreateAccountRequestLocale Read(
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
            return new InvitesCreateAccountRequestLocale(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvitesCreateAccountRequestLocale value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvitesCreateAccountRequestLocale ReadAsPropertyName(
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
            return new InvitesCreateAccountRequestLocale(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvitesCreateAccountRequestLocale value,
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
