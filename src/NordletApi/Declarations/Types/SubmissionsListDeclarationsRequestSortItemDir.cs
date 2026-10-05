using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsListDeclarationsRequestSortItemDir.SubmissionsListDeclarationsRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct SubmissionsListDeclarationsRequestSortItemDir : IStringEnum
{
    public static readonly SubmissionsListDeclarationsRequestSortItemDir Asc = new(Values.Asc);

    public static readonly SubmissionsListDeclarationsRequestSortItemDir Desc = new(Values.Desc);

    public SubmissionsListDeclarationsRequestSortItemDir(string value)
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
    public static SubmissionsListDeclarationsRequestSortItemDir FromCustom(string value)
    {
        return new SubmissionsListDeclarationsRequestSortItemDir(value);
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
        SubmissionsListDeclarationsRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsListDeclarationsRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubmissionsListDeclarationsRequestSortItemDir value) =>
        value.Value;

    public static explicit operator SubmissionsListDeclarationsRequestSortItemDir(string value) =>
        new(value);

    internal class SubmissionsListDeclarationsRequestSortItemDirSerializer
        : JsonConverter<SubmissionsListDeclarationsRequestSortItemDir>
    {
        public override SubmissionsListDeclarationsRequestSortItemDir Read(
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
            return new SubmissionsListDeclarationsRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsListDeclarationsRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsListDeclarationsRequestSortItemDir ReadAsPropertyName(
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
            return new SubmissionsListDeclarationsRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsListDeclarationsRequestSortItemDir value,
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
