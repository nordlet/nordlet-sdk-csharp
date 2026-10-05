using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(UpdateLeadsRequestStatus.UpdateLeadsRequestStatusSerializer))]
[Serializable]
public readonly record struct UpdateLeadsRequestStatus : IStringEnum
{
    public static readonly UpdateLeadsRequestStatus New = new(Values.New);

    public static readonly UpdateLeadsRequestStatus Contacted = new(Values.Contacted);

    public static readonly UpdateLeadsRequestStatus Qualified = new(Values.Qualified);

    public static readonly UpdateLeadsRequestStatus Lost = new(Values.Lost);

    public UpdateLeadsRequestStatus(string value)
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
    public static UpdateLeadsRequestStatus FromCustom(string value)
    {
        return new UpdateLeadsRequestStatus(value);
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

    public static bool operator ==(UpdateLeadsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateLeadsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateLeadsRequestStatus value) => value.Value;

    public static explicit operator UpdateLeadsRequestStatus(string value) => new(value);

    internal class UpdateLeadsRequestStatusSerializer : JsonConverter<UpdateLeadsRequestStatus>
    {
        public override UpdateLeadsRequestStatus Read(
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
            return new UpdateLeadsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateLeadsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateLeadsRequestStatus ReadAsPropertyName(
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
            return new UpdateLeadsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateLeadsRequestStatus value,
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
