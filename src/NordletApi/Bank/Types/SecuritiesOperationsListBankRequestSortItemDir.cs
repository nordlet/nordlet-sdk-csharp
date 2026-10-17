using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SecuritiesOperationsListBankRequestSortItemDir.SecuritiesOperationsListBankRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct SecuritiesOperationsListBankRequestSortItemDir : IStringEnum
{
    public static readonly SecuritiesOperationsListBankRequestSortItemDir Asc = new(Values.Asc);

    public static readonly SecuritiesOperationsListBankRequestSortItemDir Desc = new(Values.Desc);

    public SecuritiesOperationsListBankRequestSortItemDir(string value)
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
    public static SecuritiesOperationsListBankRequestSortItemDir FromCustom(string value)
    {
        return new SecuritiesOperationsListBankRequestSortItemDir(value);
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
        SecuritiesOperationsListBankRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SecuritiesOperationsListBankRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SecuritiesOperationsListBankRequestSortItemDir value) =>
        value.Value;

    public static explicit operator SecuritiesOperationsListBankRequestSortItemDir(string value) =>
        new(value);

    internal class SecuritiesOperationsListBankRequestSortItemDirSerializer
        : JsonConverter<SecuritiesOperationsListBankRequestSortItemDir>
    {
        public override SecuritiesOperationsListBankRequestSortItemDir Read(
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
            return new SecuritiesOperationsListBankRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SecuritiesOperationsListBankRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SecuritiesOperationsListBankRequestSortItemDir ReadAsPropertyName(
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
            return new SecuritiesOperationsListBankRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SecuritiesOperationsListBankRequestSortItemDir value,
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
