using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ContractsCreateHrResponseType.ContractsCreateHrResponseTypeSerializer))]
[Serializable]
public readonly record struct ContractsCreateHrResponseType : IStringEnum
{
    public static readonly ContractsCreateHrResponseType Permanent = new(Values.Permanent);

    public static readonly ContractsCreateHrResponseType FixedTerm = new(Values.FixedTerm);

    public ContractsCreateHrResponseType(string value)
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
    public static ContractsCreateHrResponseType FromCustom(string value)
    {
        return new ContractsCreateHrResponseType(value);
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

    public static bool operator ==(ContractsCreateHrResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsCreateHrResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsCreateHrResponseType value) => value.Value;

    public static explicit operator ContractsCreateHrResponseType(string value) => new(value);

    internal class ContractsCreateHrResponseTypeSerializer
        : JsonConverter<ContractsCreateHrResponseType>
    {
        public override ContractsCreateHrResponseType Read(
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
            return new ContractsCreateHrResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsCreateHrResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsCreateHrResponseType ReadAsPropertyName(
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
            return new ContractsCreateHrResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsCreateHrResponseType value,
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
