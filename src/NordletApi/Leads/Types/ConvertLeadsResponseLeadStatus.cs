using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ConvertLeadsResponseLeadStatus.ConvertLeadsResponseLeadStatusSerializer))]
[Serializable]
public readonly record struct ConvertLeadsResponseLeadStatus : IStringEnum
{
    public static readonly ConvertLeadsResponseLeadStatus New = new(Values.New);

    public static readonly ConvertLeadsResponseLeadStatus Contacted = new(Values.Contacted);

    public static readonly ConvertLeadsResponseLeadStatus Qualified = new(Values.Qualified);

    public static readonly ConvertLeadsResponseLeadStatus Lost = new(Values.Lost);

    public static readonly ConvertLeadsResponseLeadStatus Converted = new(Values.Converted);

    public ConvertLeadsResponseLeadStatus(string value)
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
    public static ConvertLeadsResponseLeadStatus FromCustom(string value)
    {
        return new ConvertLeadsResponseLeadStatus(value);
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

    public static bool operator ==(ConvertLeadsResponseLeadStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ConvertLeadsResponseLeadStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ConvertLeadsResponseLeadStatus value) => value.Value;

    public static explicit operator ConvertLeadsResponseLeadStatus(string value) => new(value);

    internal class ConvertLeadsResponseLeadStatusSerializer
        : JsonConverter<ConvertLeadsResponseLeadStatus>
    {
        public override ConvertLeadsResponseLeadStatus Read(
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
            return new ConvertLeadsResponseLeadStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ConvertLeadsResponseLeadStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ConvertLeadsResponseLeadStatus ReadAsPropertyName(
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
            return new ConvertLeadsResponseLeadStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ConvertLeadsResponseLeadStatus value,
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
        public const string New = "new";

        public const string Contacted = "contacted";

        public const string Qualified = "qualified";

        public const string Lost = "lost";

        public const string Converted = "converted";
    }
}
