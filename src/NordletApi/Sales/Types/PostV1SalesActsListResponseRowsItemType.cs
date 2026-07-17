using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesActsListResponseRowsItemType.PostV1SalesActsListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesActsListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1SalesActsListResponseRowsItemType Goods = new(Values.Goods);

    public static readonly PostV1SalesActsListResponseRowsItemType Services = new(Values.Services);

    public PostV1SalesActsListResponseRowsItemType(string value)
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
    public static PostV1SalesActsListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1SalesActsListResponseRowsItemType(value);
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

    public static bool operator ==(PostV1SalesActsListResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1SalesActsListResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesActsListResponseRowsItemType value) =>
        value.Value;

    public static explicit operator PostV1SalesActsListResponseRowsItemType(string value) =>
        new(value);

    internal class PostV1SalesActsListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1SalesActsListResponseRowsItemType>
    {
        public override PostV1SalesActsListResponseRowsItemType Read(
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
            return new PostV1SalesActsListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesActsListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesActsListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1SalesActsListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesActsListResponseRowsItemType value,
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
        public const string Goods = "goods";

        public const string Services = "services";
    }
}
