using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CalendarListResponseRowsItemKind.PostV1CalendarListResponseRowsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1CalendarListResponseRowsItemKind : IStringEnum
{
    public static readonly PostV1CalendarListResponseRowsItemKind Custom = new(Values.Custom);

    public static readonly PostV1CalendarListResponseRowsItemKind Obligation = new(
        Values.Obligation
    );

    public PostV1CalendarListResponseRowsItemKind(string value)
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
    public static PostV1CalendarListResponseRowsItemKind FromCustom(string value)
    {
        return new PostV1CalendarListResponseRowsItemKind(value);
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

    public static bool operator ==(PostV1CalendarListResponseRowsItemKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1CalendarListResponseRowsItemKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CalendarListResponseRowsItemKind value) =>
        value.Value;

    public static explicit operator PostV1CalendarListResponseRowsItemKind(string value) =>
        new(value);

    internal class PostV1CalendarListResponseRowsItemKindSerializer
        : JsonConverter<PostV1CalendarListResponseRowsItemKind>
    {
        public override PostV1CalendarListResponseRowsItemKind Read(
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
            return new PostV1CalendarListResponseRowsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CalendarListResponseRowsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CalendarListResponseRowsItemKind ReadAsPropertyName(
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
            return new PostV1CalendarListResponseRowsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CalendarListResponseRowsItemKind value,
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
