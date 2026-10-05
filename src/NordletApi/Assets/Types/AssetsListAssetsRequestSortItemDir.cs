using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsListAssetsRequestSortItemDir.AssetsListAssetsRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct AssetsListAssetsRequestSortItemDir : IStringEnum
{
    public static readonly AssetsListAssetsRequestSortItemDir Asc = new(Values.Asc);

    public static readonly AssetsListAssetsRequestSortItemDir Desc = new(Values.Desc);

    public AssetsListAssetsRequestSortItemDir(string value)
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
    public static AssetsListAssetsRequestSortItemDir FromCustom(string value)
    {
        return new AssetsListAssetsRequestSortItemDir(value);
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

    public static bool operator ==(AssetsListAssetsRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsListAssetsRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsListAssetsRequestSortItemDir value) => value.Value;

    public static explicit operator AssetsListAssetsRequestSortItemDir(string value) => new(value);

    internal class AssetsListAssetsRequestSortItemDirSerializer
        : JsonConverter<AssetsListAssetsRequestSortItemDir>
    {
        public override AssetsListAssetsRequestSortItemDir Read(
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
            return new AssetsListAssetsRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsListAssetsRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsListAssetsRequestSortItemDir ReadAsPropertyName(
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
            return new AssetsListAssetsRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsListAssetsRequestSortItemDir value,
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
