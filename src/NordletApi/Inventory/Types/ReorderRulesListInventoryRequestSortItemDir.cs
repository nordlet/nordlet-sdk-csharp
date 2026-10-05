using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReorderRulesListInventoryRequestSortItemDir.ReorderRulesListInventoryRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct ReorderRulesListInventoryRequestSortItemDir : IStringEnum
{
    public static readonly ReorderRulesListInventoryRequestSortItemDir Asc = new(Values.Asc);

    public static readonly ReorderRulesListInventoryRequestSortItemDir Desc = new(Values.Desc);

    public ReorderRulesListInventoryRequestSortItemDir(string value)
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
    public static ReorderRulesListInventoryRequestSortItemDir FromCustom(string value)
    {
        return new ReorderRulesListInventoryRequestSortItemDir(value);
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
        ReorderRulesListInventoryRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReorderRulesListInventoryRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ReorderRulesListInventoryRequestSortItemDir value) =>
        value.Value;

    public static explicit operator ReorderRulesListInventoryRequestSortItemDir(string value) =>
        new(value);

    internal class ReorderRulesListInventoryRequestSortItemDirSerializer
        : JsonConverter<ReorderRulesListInventoryRequestSortItemDir>
    {
        public override ReorderRulesListInventoryRequestSortItemDir Read(
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
            return new ReorderRulesListInventoryRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReorderRulesListInventoryRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReorderRulesListInventoryRequestSortItemDir ReadAsPropertyName(
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
            return new ReorderRulesListInventoryRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReorderRulesListInventoryRequestSortItemDir value,
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
