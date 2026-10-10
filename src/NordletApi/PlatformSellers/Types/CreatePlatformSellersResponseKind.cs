using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CreatePlatformSellersResponseKind.CreatePlatformSellersResponseKindSerializer)
)]
[Serializable]
public readonly record struct CreatePlatformSellersResponseKind : IStringEnum
{
    public static readonly CreatePlatformSellersResponseKind Individual = new(Values.Individual);

    public static readonly CreatePlatformSellersResponseKind Entity = new(Values.Entity);

    public CreatePlatformSellersResponseKind(string value)
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
    public static CreatePlatformSellersResponseKind FromCustom(string value)
    {
        return new CreatePlatformSellersResponseKind(value);
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

    public static bool operator ==(CreatePlatformSellersResponseKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreatePlatformSellersResponseKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreatePlatformSellersResponseKind value) => value.Value;

    public static explicit operator CreatePlatformSellersResponseKind(string value) => new(value);

    internal class CreatePlatformSellersResponseKindSerializer
        : JsonConverter<CreatePlatformSellersResponseKind>
    {
        public override CreatePlatformSellersResponseKind Read(
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
            return new CreatePlatformSellersResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CreatePlatformSellersResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CreatePlatformSellersResponseKind ReadAsPropertyName(
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
            return new CreatePlatformSellersResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CreatePlatformSellersResponseKind value,
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
