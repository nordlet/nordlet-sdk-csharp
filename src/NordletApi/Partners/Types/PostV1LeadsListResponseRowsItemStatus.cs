using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LeadsListResponseRowsItemStatus.PostV1LeadsListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1LeadsListResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1LeadsListResponseRowsItemStatus New = new(Values.New);

    public static readonly PostV1LeadsListResponseRowsItemStatus Contacted = new(Values.Contacted);

    public static readonly PostV1LeadsListResponseRowsItemStatus Qualified = new(Values.Qualified);

    public static readonly PostV1LeadsListResponseRowsItemStatus Lost = new(Values.Lost);

    public static readonly PostV1LeadsListResponseRowsItemStatus Converted = new(Values.Converted);

    public PostV1LeadsListResponseRowsItemStatus(string value)
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
    public static PostV1LeadsListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1LeadsListResponseRowsItemStatus(value);
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

    public static bool operator ==(PostV1LeadsListResponseRowsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1LeadsListResponseRowsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LeadsListResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator PostV1LeadsListResponseRowsItemStatus(string value) =>
        new(value);

    internal class PostV1LeadsListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1LeadsListResponseRowsItemStatus>
    {
        public override PostV1LeadsListResponseRowsItemStatus Read(
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
            return new PostV1LeadsListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LeadsListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LeadsListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1LeadsListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LeadsListResponseRowsItemStatus value,
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
        public const string New = "new";

        public const string Contacted = "contacted";

        public const string Qualified = "qualified";

        public const string Lost = "lost";

        public const string Converted = "converted";
    }
}
