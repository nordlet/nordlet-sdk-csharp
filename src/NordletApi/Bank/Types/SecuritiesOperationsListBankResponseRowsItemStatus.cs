using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SecuritiesOperationsListBankResponseRowsItemStatus.SecuritiesOperationsListBankResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct SecuritiesOperationsListBankResponseRowsItemStatus : IStringEnum
{
    public static readonly SecuritiesOperationsListBankResponseRowsItemStatus Posted = new(
        Values.Posted
    );

    public static readonly SecuritiesOperationsListBankResponseRowsItemStatus NotPosted = new(
        Values.NotPosted
    );

    public SecuritiesOperationsListBankResponseRowsItemStatus(string value)
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
    public static SecuritiesOperationsListBankResponseRowsItemStatus FromCustom(string value)
    {
        return new SecuritiesOperationsListBankResponseRowsItemStatus(value);
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
        SecuritiesOperationsListBankResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SecuritiesOperationsListBankResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SecuritiesOperationsListBankResponseRowsItemStatus value
    ) => value.Value;

    public static explicit operator SecuritiesOperationsListBankResponseRowsItemStatus(
        string value
    ) => new(value);

    internal class SecuritiesOperationsListBankResponseRowsItemStatusSerializer
        : JsonConverter<SecuritiesOperationsListBankResponseRowsItemStatus>
    {
        public override SecuritiesOperationsListBankResponseRowsItemStatus Read(
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
            return new SecuritiesOperationsListBankResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SecuritiesOperationsListBankResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SecuritiesOperationsListBankResponseRowsItemStatus ReadAsPropertyName(
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
            return new SecuritiesOperationsListBankResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SecuritiesOperationsListBankResponseRowsItemStatus value,
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
        public const string Posted = "posted";

        public const string NotPosted = "not_posted";
    }
}
