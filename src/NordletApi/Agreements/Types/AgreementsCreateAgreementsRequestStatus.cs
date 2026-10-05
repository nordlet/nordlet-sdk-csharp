using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsCreateAgreementsRequestStatus.AgreementsCreateAgreementsRequestStatusSerializer)
)]
[Serializable]
public readonly record struct AgreementsCreateAgreementsRequestStatus : IStringEnum
{
    public static readonly AgreementsCreateAgreementsRequestStatus Draft = new(Values.Draft);

    public static readonly AgreementsCreateAgreementsRequestStatus Active = new(Values.Active);

    public static readonly AgreementsCreateAgreementsRequestStatus Expired = new(Values.Expired);

    public static readonly AgreementsCreateAgreementsRequestStatus Terminated = new(
        Values.Terminated
    );

    public AgreementsCreateAgreementsRequestStatus(string value)
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
    public static AgreementsCreateAgreementsRequestStatus FromCustom(string value)
    {
        return new AgreementsCreateAgreementsRequestStatus(value);
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

    public static bool operator ==(AgreementsCreateAgreementsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AgreementsCreateAgreementsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsCreateAgreementsRequestStatus value) =>
        value.Value;

    public static explicit operator AgreementsCreateAgreementsRequestStatus(string value) =>
        new(value);

    internal class AgreementsCreateAgreementsRequestStatusSerializer
        : JsonConverter<AgreementsCreateAgreementsRequestStatus>
    {
        public override AgreementsCreateAgreementsRequestStatus Read(
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
            return new AgreementsCreateAgreementsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsCreateAgreementsRequestStatus ReadAsPropertyName(
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
            return new AgreementsCreateAgreementsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsCreateAgreementsRequestStatus value,
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
