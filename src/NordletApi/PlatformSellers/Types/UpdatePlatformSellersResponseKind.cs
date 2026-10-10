using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdatePlatformSellersResponseKind.UpdatePlatformSellersResponseKindSerializer)
)]
[Serializable]
public readonly record struct UpdatePlatformSellersResponseKind : IStringEnum
{
    public static readonly UpdatePlatformSellersResponseKind Individual = new(Values.Individual);

    public static readonly UpdatePlatformSellersResponseKind Entity = new(Values.Entity);

    public UpdatePlatformSellersResponseKind(string value)
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
    public static UpdatePlatformSellersResponseKind FromCustom(string value)
    {
        return new UpdatePlatformSellersResponseKind(value);
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

    public static bool operator ==(UpdatePlatformSellersResponseKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdatePlatformSellersResponseKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdatePlatformSellersResponseKind value) => value.Value;

    public static explicit operator UpdatePlatformSellersResponseKind(string value) => new(value);

    internal class UpdatePlatformSellersResponseKindSerializer
        : JsonConverter<UpdatePlatformSellersResponseKind>
    {
        public override UpdatePlatformSellersResponseKind Read(
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
            return new UpdatePlatformSellersResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdatePlatformSellersResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdatePlatformSellersResponseKind ReadAsPropertyName(
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
            return new UpdatePlatformSellersResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdatePlatformSellersResponseKind value,
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
        public const string Individual = "individual";

        public const string Entity = "entity";
    }
}
