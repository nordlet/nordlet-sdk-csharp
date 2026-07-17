using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrContractsListResponseRowsItemType.PostV1HrContractsListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrContractsListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1HrContractsListResponseRowsItemType Permanent = new(
        Values.Permanent
    );

    public static readonly PostV1HrContractsListResponseRowsItemType FixedTerm = new(
        Values.FixedTerm
    );

    public PostV1HrContractsListResponseRowsItemType(string value)
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
    public static PostV1HrContractsListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1HrContractsListResponseRowsItemType(value);
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
        PostV1HrContractsListResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrContractsListResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsListResponseRowsItemType value) =>
        value.Value;

    public static explicit operator PostV1HrContractsListResponseRowsItemType(string value) =>
        new(value);

    internal class PostV1HrContractsListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1HrContractsListResponseRowsItemType>
    {
        public override PostV1HrContractsListResponseRowsItemType Read(
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
            return new PostV1HrContractsListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1HrContractsListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsListResponseRowsItemType value,
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
        public const string Permanent = "permanent";

        public const string FixedTerm = "fixed_term";
    }
}
