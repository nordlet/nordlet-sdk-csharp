using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BanksListReferenceRequestSortItemDir.BanksListReferenceRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct BanksListReferenceRequestSortItemDir : IStringEnum
{
    public static readonly BanksListReferenceRequestSortItemDir Asc = new(Values.Asc);

    public static readonly BanksListReferenceRequestSortItemDir Desc = new(Values.Desc);

    public BanksListReferenceRequestSortItemDir(string value)
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
    public static BanksListReferenceRequestSortItemDir FromCustom(string value)
    {
        return new BanksListReferenceRequestSortItemDir(value);
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

    public static bool operator ==(BanksListReferenceRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BanksListReferenceRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BanksListReferenceRequestSortItemDir value) =>
        value.Value;

    public static explicit operator BanksListReferenceRequestSortItemDir(string value) =>
        new(value);

    internal class BanksListReferenceRequestSortItemDirSerializer
        : JsonConverter<BanksListReferenceRequestSortItemDir>
    {
        public override BanksListReferenceRequestSortItemDir Read(
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
            return new BanksListReferenceRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BanksListReferenceRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BanksListReferenceRequestSortItemDir ReadAsPropertyName(
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
            return new BanksListReferenceRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BanksListReferenceRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
