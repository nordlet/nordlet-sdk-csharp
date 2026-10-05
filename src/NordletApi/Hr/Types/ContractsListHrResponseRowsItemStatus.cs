using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContractsListHrResponseRowsItemStatus.ContractsListHrResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct ContractsListHrResponseRowsItemStatus : IStringEnum
{
    public static readonly ContractsListHrResponseRowsItemStatus Active = new(Values.Active);

    public static readonly ContractsListHrResponseRowsItemStatus Ended = new(Values.Ended);

    public ContractsListHrResponseRowsItemStatus(string value)
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
    public static ContractsListHrResponseRowsItemStatus FromCustom(string value)
    {
        return new ContractsListHrResponseRowsItemStatus(value);
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

    public static bool operator ==(ContractsListHrResponseRowsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsListHrResponseRowsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsListHrResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator ContractsListHrResponseRowsItemStatus(string value) =>
        new(value);

    internal class ContractsListHrResponseRowsItemStatusSerializer
        : JsonConverter<ContractsListHrResponseRowsItemStatus>
    {
        public override ContractsListHrResponseRowsItemStatus Read(
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
            return new ContractsListHrResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsListHrResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsListHrResponseRowsItemStatus ReadAsPropertyName(
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
            return new ContractsListHrResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsListHrResponseRowsItemStatus value,
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
        public const string Active = "active";

        public const string Ended = "ended";
    }
}
