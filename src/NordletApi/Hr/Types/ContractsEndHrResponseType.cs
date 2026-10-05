using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ContractsEndHrResponseType.ContractsEndHrResponseTypeSerializer))]
[Serializable]
public readonly record struct ContractsEndHrResponseType : IStringEnum
{
    public static readonly ContractsEndHrResponseType Permanent = new(Values.Permanent);

    public static readonly ContractsEndHrResponseType FixedTerm = new(Values.FixedTerm);

    public ContractsEndHrResponseType(string value)
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
    public static ContractsEndHrResponseType FromCustom(string value)
    {
        return new ContractsEndHrResponseType(value);
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

    public static bool operator ==(ContractsEndHrResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsEndHrResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsEndHrResponseType value) => value.Value;

    public static explicit operator ContractsEndHrResponseType(string value) => new(value);

    internal class ContractsEndHrResponseTypeSerializer : JsonConverter<ContractsEndHrResponseType>
    {
        public override ContractsEndHrResponseType Read(
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
            return new ContractsEndHrResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsEndHrResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsEndHrResponseType ReadAsPropertyName(
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
            return new ContractsEndHrResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsEndHrResponseType value,
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
