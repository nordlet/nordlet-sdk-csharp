using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RefundLiabilityListSalesRequestSortItemDir.RefundLiabilityListSalesRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct RefundLiabilityListSalesRequestSortItemDir : IStringEnum
{
    public static readonly RefundLiabilityListSalesRequestSortItemDir Asc = new(Values.Asc);

    public static readonly RefundLiabilityListSalesRequestSortItemDir Desc = new(Values.Desc);

    public RefundLiabilityListSalesRequestSortItemDir(string value)
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
    public static RefundLiabilityListSalesRequestSortItemDir FromCustom(string value)
    {
        return new RefundLiabilityListSalesRequestSortItemDir(value);
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
        RefundLiabilityListSalesRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RefundLiabilityListSalesRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RefundLiabilityListSalesRequestSortItemDir value) =>
        value.Value;

    public static explicit operator RefundLiabilityListSalesRequestSortItemDir(string value) =>
        new(value);

    internal class RefundLiabilityListSalesRequestSortItemDirSerializer
        : JsonConverter<RefundLiabilityListSalesRequestSortItemDir>
    {
        public override RefundLiabilityListSalesRequestSortItemDir Read(
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
            return new RefundLiabilityListSalesRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RefundLiabilityListSalesRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RefundLiabilityListSalesRequestSortItemDir ReadAsPropertyName(
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
            return new RefundLiabilityListSalesRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RefundLiabilityListSalesRequestSortItemDir value,
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
