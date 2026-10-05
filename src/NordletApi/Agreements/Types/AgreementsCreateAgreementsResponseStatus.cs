using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsCreateAgreementsResponseStatus.AgreementsCreateAgreementsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct AgreementsCreateAgreementsResponseStatus : IStringEnum
{
    public static readonly AgreementsCreateAgreementsResponseStatus Draft = new(Values.Draft);

    public static readonly AgreementsCreateAgreementsResponseStatus Active = new(Values.Active);

    public static readonly AgreementsCreateAgreementsResponseStatus Expired = new(Values.Expired);

    public static readonly AgreementsCreateAgreementsResponseStatus Terminated = new(
        Values.Terminated
    );

    public AgreementsCreateAgreementsResponseStatus(string value)
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
    public static AgreementsCreateAgreementsResponseStatus FromCustom(string value)
    {
        return new AgreementsCreateAgreementsResponseStatus(value);
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
        AgreementsCreateAgreementsResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgreementsCreateAgreementsResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsCreateAgreementsResponseStatus value) =>
        value.Value;

    public static explicit operator AgreementsCreateAgreementsResponseStatus(string value) =>
        new(value);

    internal class AgreementsCreateAgreementsResponseStatusSerializer
        : JsonConverter<AgreementsCreateAgreementsResponseStatus>
    {
        public override AgreementsCreateAgreementsResponseStatus Read(
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
            return new AgreementsCreateAgreementsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsCreateAgreementsResponseStatus ReadAsPropertyName(
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
            return new AgreementsCreateAgreementsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsResponseStatus value,
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
