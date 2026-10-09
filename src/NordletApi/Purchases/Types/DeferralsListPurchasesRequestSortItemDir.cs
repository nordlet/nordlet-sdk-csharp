using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeferralsListPurchasesRequestSortItemDir.DeferralsListPurchasesRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct DeferralsListPurchasesRequestSortItemDir : IStringEnum
{
    public static readonly DeferralsListPurchasesRequestSortItemDir Asc = new(Values.Asc);

    public static readonly DeferralsListPurchasesRequestSortItemDir Desc = new(Values.Desc);

    public DeferralsListPurchasesRequestSortItemDir(string value)
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
    public static DeferralsListPurchasesRequestSortItemDir FromCustom(string value)
    {
        return new DeferralsListPurchasesRequestSortItemDir(value);
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
        DeferralsListPurchasesRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeferralsListPurchasesRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DeferralsListPurchasesRequestSortItemDir value) =>
        value.Value;

    public static explicit operator DeferralsListPurchasesRequestSortItemDir(string value) =>
        new(value);

    internal class DeferralsListPurchasesRequestSortItemDirSerializer
        : JsonConverter<DeferralsListPurchasesRequestSortItemDir>
    {
        public override DeferralsListPurchasesRequestSortItemDir Read(
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
            return new DeferralsListPurchasesRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeferralsListPurchasesRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeferralsListPurchasesRequestSortItemDir ReadAsPropertyName(
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
            return new DeferralsListPurchasesRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeferralsListPurchasesRequestSortItemDir value,
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
