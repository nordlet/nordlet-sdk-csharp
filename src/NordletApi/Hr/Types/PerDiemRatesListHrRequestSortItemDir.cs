using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PerDiemRatesListHrRequestSortItemDir.PerDiemRatesListHrRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PerDiemRatesListHrRequestSortItemDir : IStringEnum
{
    public static readonly PerDiemRatesListHrRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PerDiemRatesListHrRequestSortItemDir Desc = new(Values.Desc);

    public PerDiemRatesListHrRequestSortItemDir(string value)
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
    public static PerDiemRatesListHrRequestSortItemDir FromCustom(string value)
    {
        return new PerDiemRatesListHrRequestSortItemDir(value);
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

    public static bool operator ==(PerDiemRatesListHrRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PerDiemRatesListHrRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PerDiemRatesListHrRequestSortItemDir value) =>
        value.Value;

    public static explicit operator PerDiemRatesListHrRequestSortItemDir(string value) =>
        new(value);

    internal class PerDiemRatesListHrRequestSortItemDirSerializer
        : JsonConverter<PerDiemRatesListHrRequestSortItemDir>
    {
        public override PerDiemRatesListHrRequestSortItemDir Read(
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
            return new PerDiemRatesListHrRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PerDiemRatesListHrRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PerDiemRatesListHrRequestSortItemDir ReadAsPropertyName(
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
            return new PerDiemRatesListHrRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PerDiemRatesListHrRequestSortItemDir value,
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
