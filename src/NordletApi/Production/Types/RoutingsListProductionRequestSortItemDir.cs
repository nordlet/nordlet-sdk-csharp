using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RoutingsListProductionRequestSortItemDir.RoutingsListProductionRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct RoutingsListProductionRequestSortItemDir : IStringEnum
{
    public static readonly RoutingsListProductionRequestSortItemDir Asc = new(Values.Asc);

    public static readonly RoutingsListProductionRequestSortItemDir Desc = new(Values.Desc);

    public RoutingsListProductionRequestSortItemDir(string value)
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
    public static RoutingsListProductionRequestSortItemDir FromCustom(string value)
    {
        return new RoutingsListProductionRequestSortItemDir(value);
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
        RoutingsListProductionRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RoutingsListProductionRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RoutingsListProductionRequestSortItemDir value) =>
        value.Value;

    public static explicit operator RoutingsListProductionRequestSortItemDir(string value) =>
        new(value);

    internal class RoutingsListProductionRequestSortItemDirSerializer
        : JsonConverter<RoutingsListProductionRequestSortItemDir>
    {
        public override RoutingsListProductionRequestSortItemDir Read(
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
            return new RoutingsListProductionRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RoutingsListProductionRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RoutingsListProductionRequestSortItemDir ReadAsPropertyName(
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
            return new RoutingsListProductionRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RoutingsListProductionRequestSortItemDir value,
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
