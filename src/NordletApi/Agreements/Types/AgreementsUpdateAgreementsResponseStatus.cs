using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsUpdateAgreementsResponseStatus.AgreementsUpdateAgreementsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct AgreementsUpdateAgreementsResponseStatus : IStringEnum
{
    public static readonly AgreementsUpdateAgreementsResponseStatus Draft = new(Values.Draft);

    public static readonly AgreementsUpdateAgreementsResponseStatus Active = new(Values.Active);

    public static readonly AgreementsUpdateAgreementsResponseStatus Expired = new(Values.Expired);

    public static readonly AgreementsUpdateAgreementsResponseStatus Terminated = new(
        Values.Terminated
    );

    public AgreementsUpdateAgreementsResponseStatus(string value)
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
    public static AgreementsUpdateAgreementsResponseStatus FromCustom(string value)
    {
        return new AgreementsUpdateAgreementsResponseStatus(value);
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
        AgreementsUpdateAgreementsResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AgreementsUpdateAgreementsResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsUpdateAgreementsResponseStatus value) =>
        value.Value;

    public static explicit operator AgreementsUpdateAgreementsResponseStatus(string value) =>
        new(value);

    internal class AgreementsUpdateAgreementsResponseStatusSerializer
        : JsonConverter<AgreementsUpdateAgreementsResponseStatus>
    {
        public override AgreementsUpdateAgreementsResponseStatus Read(
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
            return new AgreementsUpdateAgreementsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsUpdateAgreementsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsUpdateAgreementsResponseStatus ReadAsPropertyName(
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
            return new AgreementsUpdateAgreementsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsUpdateAgreementsResponseStatus value,
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
