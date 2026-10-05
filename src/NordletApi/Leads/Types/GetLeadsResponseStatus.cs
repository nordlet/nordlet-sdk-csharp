using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(GetLeadsResponseStatus.GetLeadsResponseStatusSerializer))]
[Serializable]
public readonly record struct GetLeadsResponseStatus : IStringEnum
{
    public static readonly GetLeadsResponseStatus New = new(Values.New);

    public static readonly GetLeadsResponseStatus Contacted = new(Values.Contacted);

    public static readonly GetLeadsResponseStatus Qualified = new(Values.Qualified);

    public static readonly GetLeadsResponseStatus Lost = new(Values.Lost);

    public static readonly GetLeadsResponseStatus Converted = new(Values.Converted);

    public GetLeadsResponseStatus(string value)
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
    public static GetLeadsResponseStatus FromCustom(string value)
    {
        return new GetLeadsResponseStatus(value);
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

    public static bool operator ==(GetLeadsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetLeadsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetLeadsResponseStatus value) => value.Value;

    public static explicit operator GetLeadsResponseStatus(string value) => new(value);

    internal class GetLeadsResponseStatusSerializer : JsonConverter<GetLeadsResponseStatus>
    {
        public override GetLeadsResponseStatus Read(
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
            return new GetLeadsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetLeadsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetLeadsResponseStatus ReadAsPropertyName(
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
            return new GetLeadsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetLeadsResponseStatus value,
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
