using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SecuritiesGetBankResponseOperationsItemStatus.SecuritiesGetBankResponseOperationsItemStatusSerializer)
)]
[Serializable]
public readonly record struct SecuritiesGetBankResponseOperationsItemStatus : IStringEnum
{
    public static readonly SecuritiesGetBankResponseOperationsItemStatus Posted = new(
        Values.Posted
    );

    public static readonly SecuritiesGetBankResponseOperationsItemStatus NotPosted = new(
        Values.NotPosted
    );

    public SecuritiesGetBankResponseOperationsItemStatus(string value)
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
    public static SecuritiesGetBankResponseOperationsItemStatus FromCustom(string value)
    {
        return new SecuritiesGetBankResponseOperationsItemStatus(value);
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
        SecuritiesGetBankResponseOperationsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SecuritiesGetBankResponseOperationsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SecuritiesGetBankResponseOperationsItemStatus value) =>
        value.Value;

    public static explicit operator SecuritiesGetBankResponseOperationsItemStatus(string value) =>
        new(value);

    internal class SecuritiesGetBankResponseOperationsItemStatusSerializer
        : JsonConverter<SecuritiesGetBankResponseOperationsItemStatus>
    {
        public override SecuritiesGetBankResponseOperationsItemStatus Read(
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
            return new SecuritiesGetBankResponseOperationsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SecuritiesGetBankResponseOperationsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SecuritiesGetBankResponseOperationsItemStatus ReadAsPropertyName(
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
            return new SecuritiesGetBankResponseOperationsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SecuritiesGetBankResponseOperationsItemStatus value,
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
