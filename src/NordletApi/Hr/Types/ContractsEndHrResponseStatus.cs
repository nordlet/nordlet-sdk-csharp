using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ContractsEndHrResponseStatus.ContractsEndHrResponseStatusSerializer))]
[Serializable]
public readonly record struct ContractsEndHrResponseStatus : IStringEnum
{
    public static readonly ContractsEndHrResponseStatus Active = new(Values.Active);

    public static readonly ContractsEndHrResponseStatus Ended = new(Values.Ended);

    public ContractsEndHrResponseStatus(string value)
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
    public static ContractsEndHrResponseStatus FromCustom(string value)
    {
        return new ContractsEndHrResponseStatus(value);
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

    public static bool operator ==(ContractsEndHrResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsEndHrResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsEndHrResponseStatus value) => value.Value;

    public static explicit operator ContractsEndHrResponseStatus(string value) => new(value);

    internal class ContractsEndHrResponseStatusSerializer
        : JsonConverter<ContractsEndHrResponseStatus>
    {
        public override ContractsEndHrResponseStatus Read(
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
            return new ContractsEndHrResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsEndHrResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsEndHrResponseStatus ReadAsPropertyName(
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
            return new ContractsEndHrResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsEndHrResponseStatus value,
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
