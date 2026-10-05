using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(MembersAddConsolidationResponseMethod.MembersAddConsolidationResponseMethodSerializer)
)]
[Serializable]
public readonly record struct MembersAddConsolidationResponseMethod : IStringEnum
{
    public static readonly MembersAddConsolidationResponseMethod Full = new(Values.Full);

    public static readonly MembersAddConsolidationResponseMethod Proportional = new(
        Values.Proportional
    );

    public static readonly MembersAddConsolidationResponseMethod Equity = new(Values.Equity);

    public MembersAddConsolidationResponseMethod(string value)
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
    public static MembersAddConsolidationResponseMethod FromCustom(string value)
    {
        return new MembersAddConsolidationResponseMethod(value);
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

    public static bool operator ==(MembersAddConsolidationResponseMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MembersAddConsolidationResponseMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MembersAddConsolidationResponseMethod value) =>
        value.Value;

    public static explicit operator MembersAddConsolidationResponseMethod(string value) =>
        new(value);

    internal class MembersAddConsolidationResponseMethodSerializer
        : JsonConverter<MembersAddConsolidationResponseMethod>
    {
        public override MembersAddConsolidationResponseMethod Read(
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
            return new MembersAddConsolidationResponseMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MembersAddConsolidationResponseMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MembersAddConsolidationResponseMethod ReadAsPropertyName(
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
            return new MembersAddConsolidationResponseMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MembersAddConsolidationResponseMethod value,
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
        public const string Full = "full";

        public const string Proportional = "proportional";

        public const string Equity = "equity";
    }
}
