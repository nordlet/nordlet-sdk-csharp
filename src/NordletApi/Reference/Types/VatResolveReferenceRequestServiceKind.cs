using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(VatResolveReferenceRequestServiceKind.VatResolveReferenceRequestServiceKindSerializer)
)]
[Serializable]
public readonly record struct VatResolveReferenceRequestServiceKind : IStringEnum
{
    public static readonly VatResolveReferenceRequestServiceKind ShortTermAccommodation = new(
        Values.ShortTermAccommodation
    );

    public static readonly VatResolveReferenceRequestServiceKind PassengerRoadTransport = new(
        Values.PassengerRoadTransport
    );

    public VatResolveReferenceRequestServiceKind(string value)
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
    public static VatResolveReferenceRequestServiceKind FromCustom(string value)
    {
        return new VatResolveReferenceRequestServiceKind(value);
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

    public static bool operator ==(VatResolveReferenceRequestServiceKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VatResolveReferenceRequestServiceKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VatResolveReferenceRequestServiceKind value) =>
        value.Value;

    public static explicit operator VatResolveReferenceRequestServiceKind(string value) =>
        new(value);

    internal class VatResolveReferenceRequestServiceKindSerializer
        : JsonConverter<VatResolveReferenceRequestServiceKind>
    {
        public override VatResolveReferenceRequestServiceKind Read(
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
            return new VatResolveReferenceRequestServiceKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatResolveReferenceRequestServiceKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatResolveReferenceRequestServiceKind ReadAsPropertyName(
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
            return new VatResolveReferenceRequestServiceKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatResolveReferenceRequestServiceKind value,
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
        public const string ShortTermAccommodation = "short_term_accommodation";

        public const string PassengerRoadTransport = "passenger_road_transport";
    }
}
