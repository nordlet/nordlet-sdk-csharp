using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(PostV1CalendarGetResponseKind.PostV1CalendarGetResponseKindSerializer))]
[Serializable]
public readonly record struct PostV1CalendarGetResponseKind : IStringEnum
{
    public static readonly PostV1CalendarGetResponseKind Custom = new(Values.Custom);

    public static readonly PostV1CalendarGetResponseKind Obligation = new(Values.Obligation);

    public PostV1CalendarGetResponseKind(string value)
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
    public static PostV1CalendarGetResponseKind FromCustom(string value)
    {
        return new PostV1CalendarGetResponseKind(value);
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

    public static bool operator ==(PostV1CalendarGetResponseKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1CalendarGetResponseKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CalendarGetResponseKind value) => value.Value;

    public static explicit operator PostV1CalendarGetResponseKind(string value) => new(value);

    internal class PostV1CalendarGetResponseKindSerializer
        : JsonConverter<PostV1CalendarGetResponseKind>
    {
        public override PostV1CalendarGetResponseKind Read(
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
            return new PostV1CalendarGetResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CalendarGetResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CalendarGetResponseKind ReadAsPropertyName(
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
            return new PostV1CalendarGetResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CalendarGetResponseKind value,
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
