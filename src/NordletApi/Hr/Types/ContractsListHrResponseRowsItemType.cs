using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ContractsListHrResponseRowsItemType.ContractsListHrResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct ContractsListHrResponseRowsItemType : IStringEnum
{
    public static readonly ContractsListHrResponseRowsItemType Permanent = new(Values.Permanent);

    public static readonly ContractsListHrResponseRowsItemType FixedTerm = new(Values.FixedTerm);

    public ContractsListHrResponseRowsItemType(string value)
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
    public static ContractsListHrResponseRowsItemType FromCustom(string value)
    {
        return new ContractsListHrResponseRowsItemType(value);
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

    public static bool operator ==(ContractsListHrResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsListHrResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsListHrResponseRowsItemType value) =>
        value.Value;

    public static explicit operator ContractsListHrResponseRowsItemType(string value) => new(value);

    internal class ContractsListHrResponseRowsItemTypeSerializer
        : JsonConverter<ContractsListHrResponseRowsItemType>
    {
        public override ContractsListHrResponseRowsItemType Read(
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
            return new ContractsListHrResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsListHrResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsListHrResponseRowsItemType ReadAsPropertyName(
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
            return new ContractsListHrResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsListHrResponseRowsItemType value,
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
        public const string Permanent = "permanent";

        public const string FixedTerm = "fixed_term";
    }
}
