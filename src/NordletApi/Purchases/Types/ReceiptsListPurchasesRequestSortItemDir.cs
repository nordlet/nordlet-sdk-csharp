using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReceiptsListPurchasesRequestSortItemDir.ReceiptsListPurchasesRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct ReceiptsListPurchasesRequestSortItemDir : IStringEnum
{
    public static readonly ReceiptsListPurchasesRequestSortItemDir Asc = new(Values.Asc);

    public static readonly ReceiptsListPurchasesRequestSortItemDir Desc = new(Values.Desc);

    public ReceiptsListPurchasesRequestSortItemDir(string value)
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
    public static ReceiptsListPurchasesRequestSortItemDir FromCustom(string value)
    {
        return new ReceiptsListPurchasesRequestSortItemDir(value);
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

    public static bool operator ==(ReceiptsListPurchasesRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReceiptsListPurchasesRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReceiptsListPurchasesRequestSortItemDir value) =>
        value.Value;

    public static explicit operator ReceiptsListPurchasesRequestSortItemDir(string value) =>
        new(value);

    internal class ReceiptsListPurchasesRequestSortItemDirSerializer
        : JsonConverter<ReceiptsListPurchasesRequestSortItemDir>
    {
        public override ReceiptsListPurchasesRequestSortItemDir Read(
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
            return new ReceiptsListPurchasesRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReceiptsListPurchasesRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReceiptsListPurchasesRequestSortItemDir ReadAsPropertyName(
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
            return new ReceiptsListPurchasesRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReceiptsListPurchasesRequestSortItemDir value,
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
