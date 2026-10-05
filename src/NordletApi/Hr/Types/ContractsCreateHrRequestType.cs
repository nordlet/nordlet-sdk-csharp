using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ContractsCreateHrRequestType.ContractsCreateHrRequestTypeSerializer))]
[Serializable]
public readonly record struct ContractsCreateHrRequestType : IStringEnum
{
    public static readonly ContractsCreateHrRequestType Permanent = new(Values.Permanent);

    public static readonly ContractsCreateHrRequestType FixedTerm = new(Values.FixedTerm);

    public ContractsCreateHrRequestType(string value)
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
    public static ContractsCreateHrRequestType FromCustom(string value)
    {
        return new ContractsCreateHrRequestType(value);
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

    public static bool operator ==(ContractsCreateHrRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsCreateHrRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsCreateHrRequestType value) => value.Value;

    public static explicit operator ContractsCreateHrRequestType(string value) => new(value);

    internal class ContractsCreateHrRequestTypeSerializer
        : JsonConverter<ContractsCreateHrRequestType>
    {
        public override ContractsCreateHrRequestType Read(
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
            return new ContractsCreateHrRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsCreateHrRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsCreateHrRequestType ReadAsPropertyName(
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
            return new ContractsCreateHrRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsCreateHrRequestType value,
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
