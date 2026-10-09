using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BusinessTripsListHrRequestSortItemDir.BusinessTripsListHrRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct BusinessTripsListHrRequestSortItemDir : IStringEnum
{
    public static readonly BusinessTripsListHrRequestSortItemDir Asc = new(Values.Asc);

    public static readonly BusinessTripsListHrRequestSortItemDir Desc = new(Values.Desc);

    public BusinessTripsListHrRequestSortItemDir(string value)
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
    public static BusinessTripsListHrRequestSortItemDir FromCustom(string value)
    {
        return new BusinessTripsListHrRequestSortItemDir(value);
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

    public static bool operator ==(BusinessTripsListHrRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BusinessTripsListHrRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BusinessTripsListHrRequestSortItemDir value) =>
        value.Value;

    public static explicit operator BusinessTripsListHrRequestSortItemDir(string value) =>
        new(value);

    internal class BusinessTripsListHrRequestSortItemDirSerializer
        : JsonConverter<BusinessTripsListHrRequestSortItemDir>
    {
        public override BusinessTripsListHrRequestSortItemDir Read(
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
            return new BusinessTripsListHrRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BusinessTripsListHrRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BusinessTripsListHrRequestSortItemDir ReadAsPropertyName(
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
            return new BusinessTripsListHrRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BusinessTripsListHrRequestSortItemDir value,
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
