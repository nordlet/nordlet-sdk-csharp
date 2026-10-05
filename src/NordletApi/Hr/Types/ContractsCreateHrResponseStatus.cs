using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ContractsCreateHrResponseStatus.ContractsCreateHrResponseStatusSerializer))]
[Serializable]
public readonly record struct ContractsCreateHrResponseStatus : IStringEnum
{
    public static readonly ContractsCreateHrResponseStatus Active = new(Values.Active);

    public static readonly ContractsCreateHrResponseStatus Ended = new(Values.Ended);

    public ContractsCreateHrResponseStatus(string value)
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
    public static ContractsCreateHrResponseStatus FromCustom(string value)
    {
        return new ContractsCreateHrResponseStatus(value);
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

    public static bool operator ==(ContractsCreateHrResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractsCreateHrResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractsCreateHrResponseStatus value) => value.Value;

    public static explicit operator ContractsCreateHrResponseStatus(string value) => new(value);

    internal class ContractsCreateHrResponseStatusSerializer
        : JsonConverter<ContractsCreateHrResponseStatus>
    {
        public override ContractsCreateHrResponseStatus Read(
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
            return new ContractsCreateHrResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractsCreateHrResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContractsCreateHrResponseStatus ReadAsPropertyName(
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
            return new ContractsCreateHrResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractsCreateHrResponseStatus value,
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
