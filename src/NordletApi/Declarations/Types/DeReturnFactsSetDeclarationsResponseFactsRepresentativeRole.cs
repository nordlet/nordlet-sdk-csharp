using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole.DeReturnFactsSetDeclarationsResponseFactsRepresentativeRoleSerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole
    : IStringEnum
{
    public static readonly DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole Agent = new(
        Values.Agent
    );

    public static readonly DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole ReceivingAgent =
        new(Values.ReceivingAgent);

    public DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole(string value)
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
    public static DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole FromCustom(
        string value
    )
    {
        return new DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole(value);
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
        DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole value
    ) => value.Value;

    public static explicit operator DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole(
        string value
    ) => new(value);

    internal class DeReturnFactsSetDeclarationsResponseFactsRepresentativeRoleSerializer
        : JsonConverter<DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole>
    {
        public override DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole Read(
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
            return new DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole ReadAsPropertyName(
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
            return new DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsResponseFactsRepresentativeRole value,
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
        public const string Agent = "agent";

        public const string ReceivingAgent = "receiving_agent";
    }
}
