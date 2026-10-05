using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InquiriesListPartnersRequestSortItemDir.InquiriesListPartnersRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct InquiriesListPartnersRequestSortItemDir : IStringEnum
{
    public static readonly InquiriesListPartnersRequestSortItemDir Asc = new(Values.Asc);

    public static readonly InquiriesListPartnersRequestSortItemDir Desc = new(Values.Desc);

    public InquiriesListPartnersRequestSortItemDir(string value)
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
    public static InquiriesListPartnersRequestSortItemDir FromCustom(string value)
    {
        return new InquiriesListPartnersRequestSortItemDir(value);
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

    public static bool operator ==(InquiriesListPartnersRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InquiriesListPartnersRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InquiriesListPartnersRequestSortItemDir value) =>
        value.Value;

    public static explicit operator InquiriesListPartnersRequestSortItemDir(string value) =>
        new(value);

    internal class InquiriesListPartnersRequestSortItemDirSerializer
        : JsonConverter<InquiriesListPartnersRequestSortItemDir>
    {
        public override InquiriesListPartnersRequestSortItemDir Read(
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
            return new InquiriesListPartnersRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InquiriesListPartnersRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InquiriesListPartnersRequestSortItemDir ReadAsPropertyName(
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
            return new InquiriesListPartnersRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InquiriesListPartnersRequestSortItemDir value,
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
