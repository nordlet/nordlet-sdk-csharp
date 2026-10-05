using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(CreateLeadsRequestStatus.CreateLeadsRequestStatusSerializer))]
[Serializable]
public readonly record struct CreateLeadsRequestStatus : IStringEnum
{
    public static readonly CreateLeadsRequestStatus New = new(Values.New);

    public static readonly CreateLeadsRequestStatus Contacted = new(Values.Contacted);

    public static readonly CreateLeadsRequestStatus Qualified = new(Values.Qualified);

    public static readonly CreateLeadsRequestStatus Lost = new(Values.Lost);

    public CreateLeadsRequestStatus(string value)
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
    public static CreateLeadsRequestStatus FromCustom(string value)
    {
        return new CreateLeadsRequestStatus(value);
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

    public static bool operator ==(CreateLeadsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateLeadsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateLeadsRequestStatus value) => value.Value;

    public static explicit operator CreateLeadsRequestStatus(string value) => new(value);

    internal class CreateLeadsRequestStatusSerializer : JsonConverter<CreateLeadsRequestStatus>
    {
        public override CreateLeadsRequestStatus Read(
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
            return new CreateLeadsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreateLeadsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreateLeadsRequestStatus ReadAsPropertyName(
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
            return new CreateLeadsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreateLeadsRequestStatus value,
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
    }
}
