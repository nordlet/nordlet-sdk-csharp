using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AgreementsUpdateAgreementsRequestStatus.AgreementsUpdateAgreementsRequestStatusSerializer)
)]
[Serializable]
public readonly record struct AgreementsUpdateAgreementsRequestStatus : IStringEnum
{
    public static readonly AgreementsUpdateAgreementsRequestStatus Draft = new(Values.Draft);

    public static readonly AgreementsUpdateAgreementsRequestStatus Active = new(Values.Active);

    public static readonly AgreementsUpdateAgreementsRequestStatus Expired = new(Values.Expired);

    public static readonly AgreementsUpdateAgreementsRequestStatus Terminated = new(
        Values.Terminated
    );

    public AgreementsUpdateAgreementsRequestStatus(string value)
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
    public static AgreementsUpdateAgreementsRequestStatus FromCustom(string value)
    {
        return new AgreementsUpdateAgreementsRequestStatus(value);
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

    public static bool operator ==(AgreementsUpdateAgreementsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AgreementsUpdateAgreementsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AgreementsUpdateAgreementsRequestStatus value) =>
        value.Value;

    public static explicit operator AgreementsUpdateAgreementsRequestStatus(string value) =>
        new(value);

    internal class AgreementsUpdateAgreementsRequestStatusSerializer
        : JsonConverter<AgreementsUpdateAgreementsRequestStatus>
    {
        public override AgreementsUpdateAgreementsRequestStatus Read(
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
            return new AgreementsUpdateAgreementsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AgreementsUpdateAgreementsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AgreementsUpdateAgreementsRequestStatus ReadAsPropertyName(
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
            return new AgreementsUpdateAgreementsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AgreementsUpdateAgreementsRequestStatus value,
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
