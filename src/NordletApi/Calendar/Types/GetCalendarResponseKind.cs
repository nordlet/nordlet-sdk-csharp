using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(GetCalendarResponseKind.GetCalendarResponseKindSerializer))]
[Serializable]
public readonly record struct GetCalendarResponseKind : IStringEnum
{
    public static readonly GetCalendarResponseKind Custom = new(Values.Custom);

    public static readonly GetCalendarResponseKind Obligation = new(Values.Obligation);

    public GetCalendarResponseKind(string value)
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
    public static GetCalendarResponseKind FromCustom(string value)
    {
        return new GetCalendarResponseKind(value);
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

    public static bool operator ==(GetCalendarResponseKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetCalendarResponseKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetCalendarResponseKind value) => value.Value;

    public static explicit operator GetCalendarResponseKind(string value) => new(value);

    internal class GetCalendarResponseKindSerializer : JsonConverter<GetCalendarResponseKind>
    {
        public override GetCalendarResponseKind Read(
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
            return new GetCalendarResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetCalendarResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetCalendarResponseKind ReadAsPropertyName(
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
            return new GetCalendarResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetCalendarResponseKind value,
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
        public const string Custom = "custom";

        public const string Obligation = "obligation";
    }
}
