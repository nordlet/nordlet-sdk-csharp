using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(CreateLeadsResponseStatus.CreateLeadsResponseStatusSerializer))]
[Serializable]
public readonly record struct CreateLeadsResponseStatus : IStringEnum
{
    public static readonly CreateLeadsResponseStatus New = new(Values.New);

    public static readonly CreateLeadsResponseStatus Contacted = new(Values.Contacted);

    public static readonly CreateLeadsResponseStatus Qualified = new(Values.Qualified);

    public static readonly CreateLeadsResponseStatus Lost = new(Values.Lost);

    public static readonly CreateLeadsResponseStatus Converted = new(Values.Converted);

    public CreateLeadsResponseStatus(string value)
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
    public static CreateLeadsResponseStatus FromCustom(string value)
    {
        return new CreateLeadsResponseStatus(value);
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

    public static bool operator ==(CreateLeadsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateLeadsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateLeadsResponseStatus value) => value.Value;

    public static explicit operator CreateLeadsResponseStatus(string value) => new(value);

    internal class CreateLeadsResponseStatusSerializer : JsonConverter<CreateLeadsResponseStatus>
    {
        public override CreateLeadsResponseStatus Read(
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
            return new CreateLeadsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateLeadsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateLeadsResponseStatus ReadAsPropertyName(
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
            return new CreateLeadsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateLeadsResponseStatus value,
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
