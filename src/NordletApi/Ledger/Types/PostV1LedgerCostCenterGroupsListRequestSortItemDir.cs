using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerCostCenterGroupsListRequestSortItemDir.PostV1LedgerCostCenterGroupsListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerCostCenterGroupsListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1LedgerCostCenterGroupsListRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PostV1LedgerCostCenterGroupsListRequestSortItemDir Desc = new(
        Values.Desc
    );

    public PostV1LedgerCostCenterGroupsListRequestSortItemDir(string value)
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
    public static PostV1LedgerCostCenterGroupsListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1LedgerCostCenterGroupsListRequestSortItemDir(value);
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
        PostV1LedgerCostCenterGroupsListRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerCostCenterGroupsListRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1LedgerCostCenterGroupsListRequestSortItemDir value
    ) => value.Value;

    public static explicit operator PostV1LedgerCostCenterGroupsListRequestSortItemDir(
        string value
    ) => new(value);

    internal class PostV1LedgerCostCenterGroupsListRequestSortItemDirSerializer
        : JsonConverter<PostV1LedgerCostCenterGroupsListRequestSortItemDir>
    {
        public override PostV1LedgerCostCenterGroupsListRequestSortItemDir Read(
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
            return new PostV1LedgerCostCenterGroupsListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerCostCenterGroupsListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerCostCenterGroupsListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1LedgerCostCenterGroupsListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerCostCenterGroupsListRequestSortItemDir value,
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
