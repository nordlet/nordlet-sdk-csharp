using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(WaybillsListTransportRequestSortItemDir.WaybillsListTransportRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct WaybillsListTransportRequestSortItemDir : IStringEnum
{
    public static readonly WaybillsListTransportRequestSortItemDir Asc = new(Values.Asc);

    public static readonly WaybillsListTransportRequestSortItemDir Desc = new(Values.Desc);

    public WaybillsListTransportRequestSortItemDir(string value)
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
    public static WaybillsListTransportRequestSortItemDir FromCustom(string value)
    {
        return new WaybillsListTransportRequestSortItemDir(value);
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

    public static bool operator ==(WaybillsListTransportRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WaybillsListTransportRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WaybillsListTransportRequestSortItemDir value) =>
        value.Value;

    public static explicit operator WaybillsListTransportRequestSortItemDir(string value) =>
        new(value);

    internal class WaybillsListTransportRequestSortItemDirSerializer
        : JsonConverter<WaybillsListTransportRequestSortItemDir>
    {
        public override WaybillsListTransportRequestSortItemDir Read(
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
            return new WaybillsListTransportRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WaybillsListTransportRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WaybillsListTransportRequestSortItemDir ReadAsPropertyName(
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
            return new WaybillsListTransportRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WaybillsListTransportRequestSortItemDir value,
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
