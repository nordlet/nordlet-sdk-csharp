using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsGetAgreementsResponseStatus.AgreementsGetAgreementsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct AgreementsGetAgreementsResponseStatus : IStringEnum
{
    public static readonly AgreementsGetAgreementsResponseStatus Draft = new(Values.Draft);

    public static readonly AgreementsGetAgreementsResponseStatus Active = new(Values.Active);

    public static readonly AgreementsGetAgreementsResponseStatus Expired = new(Values.Expired);

    public static readonly AgreementsGetAgreementsResponseStatus Terminated = new(
        Values.Terminated
    );

    public AgreementsGetAgreementsResponseStatus(string value)
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
    public static AgreementsGetAgreementsResponseStatus FromCustom(string value)
    {
        return new AgreementsGetAgreementsResponseStatus(value);
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

    public static bool operator ==(AgreementsGetAgreementsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AgreementsGetAgreementsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsGetAgreementsResponseStatus value) =>
        value.Value;

    public static explicit operator AgreementsGetAgreementsResponseStatus(string value) =>
        new(value);

    internal class AgreementsGetAgreementsResponseStatusSerializer
        : JsonConverter<AgreementsGetAgreementsResponseStatus>
    {
        public override AgreementsGetAgreementsResponseStatus Read(
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
            return new AgreementsGetAgreementsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsGetAgreementsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsGetAgreementsResponseStatus ReadAsPropertyName(
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
            return new AgreementsGetAgreementsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsGetAgreementsResponseStatus value,
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
        public const string Draft = "draft";

        public const string Active = "active";

        public const string Expired = "expired";

        public const string Terminated = "terminated";
    }
}
