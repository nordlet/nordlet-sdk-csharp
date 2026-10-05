using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(UpdateCalendarResponseKind.UpdateCalendarResponseKindSerializer))]
[Serializable]
public readonly record struct UpdateCalendarResponseKind : IStringEnum
{
    public static readonly UpdateCalendarResponseKind Custom = new(Values.Custom);

    public static readonly UpdateCalendarResponseKind Obligation = new(Values.Obligation);

    public UpdateCalendarResponseKind(string value)
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
    public static UpdateCalendarResponseKind FromCustom(string value)
    {
        return new UpdateCalendarResponseKind(value);
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

    public static bool operator ==(UpdateCalendarResponseKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateCalendarResponseKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateCalendarResponseKind value) => value.Value;

    public static explicit operator UpdateCalendarResponseKind(string value) => new(value);

    internal class UpdateCalendarResponseKindSerializer : JsonConverter<UpdateCalendarResponseKind>
    {
        public override UpdateCalendarResponseKind Read(
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
            return new UpdateCalendarResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateCalendarResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateCalendarResponseKind ReadAsPropertyName(
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
            return new UpdateCalendarResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateCalendarResponseKind value,
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
