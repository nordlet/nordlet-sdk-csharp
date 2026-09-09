using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1CatalogUnitsOptionsResponseRowsItemSource.PostV1CatalogUnitsOptionsResponseRowsItemSourceSerializer)
)]
[Serializable]
public readonly record struct PostV1CatalogUnitsOptionsResponseRowsItemSource : IStringEnum
{
    public static readonly PostV1CatalogUnitsOptionsResponseRowsItemSource Company = new(
        Values.Company
    );

    public static readonly PostV1CatalogUnitsOptionsResponseRowsItemSource Global = new(
        Values.Global
    );

    public PostV1CatalogUnitsOptionsResponseRowsItemSource(string value)
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
    public static PostV1CatalogUnitsOptionsResponseRowsItemSource FromCustom(string value)
    {
        return new PostV1CatalogUnitsOptionsResponseRowsItemSource(value);
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

    public static bool operator ==(
        PostV1CatalogUnitsOptionsResponseRowsItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1CatalogUnitsOptionsResponseRowsItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1CatalogUnitsOptionsResponseRowsItemSource value) =>
        value.Value;

    public static explicit operator PostV1CatalogUnitsOptionsResponseRowsItemSource(string value) =>
        new(value);

    internal class PostV1CatalogUnitsOptionsResponseRowsItemSourceSerializer
        : JsonConverter<PostV1CatalogUnitsOptionsResponseRowsItemSource>
    {
        public override PostV1CatalogUnitsOptionsResponseRowsItemSource Read(
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
            return new PostV1CatalogUnitsOptionsResponseRowsItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1CatalogUnitsOptionsResponseRowsItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1CatalogUnitsOptionsResponseRowsItemSource ReadAsPropertyName(
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
            return new PostV1CatalogUnitsOptionsResponseRowsItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1CatalogUnitsOptionsResponseRowsItemSource value,
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

        public const string Global = "global";
    }
}
