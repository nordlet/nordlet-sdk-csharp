using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(UpdateLeadsResponseStatus.UpdateLeadsResponseStatusSerializer))]
[Serializable]
public readonly record struct UpdateLeadsResponseStatus : IStringEnum
{
    public static readonly UpdateLeadsResponseStatus New = new(Values.New);

    public static readonly UpdateLeadsResponseStatus Contacted = new(Values.Contacted);

    public static readonly UpdateLeadsResponseStatus Qualified = new(Values.Qualified);

    public static readonly UpdateLeadsResponseStatus Lost = new(Values.Lost);

    public static readonly UpdateLeadsResponseStatus Converted = new(Values.Converted);

    public UpdateLeadsResponseStatus(string value)
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
    public static UpdateLeadsResponseStatus FromCustom(string value)
    {
        return new UpdateLeadsResponseStatus(value);
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

    public static bool operator ==(UpdateLeadsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateLeadsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateLeadsResponseStatus value) => value.Value;

    public static explicit operator UpdateLeadsResponseStatus(string value) => new(value);

    internal class UpdateLeadsResponseStatusSerializer : JsonConverter<UpdateLeadsResponseStatus>
    {
        public override UpdateLeadsResponseStatus Read(
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
            return new UpdateLeadsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateLeadsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateLeadsResponseStatus ReadAsPropertyName(
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
            return new UpdateLeadsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateLeadsResponseStatus value,
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
