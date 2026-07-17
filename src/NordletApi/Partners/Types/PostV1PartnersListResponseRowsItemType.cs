using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersListResponseRowsItemType.PostV1PartnersListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1PartnersListResponseRowsItemType Company = new(Values.Company);

    public static readonly PostV1PartnersListResponseRowsItemType Person = new(Values.Person);

    public PostV1PartnersListResponseRowsItemType(string value)
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
    public static PostV1PartnersListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1PartnersListResponseRowsItemType(value);
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

    public static bool operator ==(PostV1PartnersListResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1PartnersListResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersListResponseRowsItemType value) =>
        value.Value;

    public static explicit operator PostV1PartnersListResponseRowsItemType(string value) =>
        new(value);

    internal class PostV1PartnersListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1PartnersListResponseRowsItemType>
    {
        public override PostV1PartnersListResponseRowsItemType Read(
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
            return new PostV1PartnersListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1PartnersListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersListResponseRowsItemType value,
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
        public const string Company = "company";

        public const string Person = "person";
    }
}
