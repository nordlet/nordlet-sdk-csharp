using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(UpdatePlatformSellersRequestKind.UpdatePlatformSellersRequestKindSerializer))]
[Serializable]
public readonly record struct UpdatePlatformSellersRequestKind : IStringEnum
{
    public static readonly UpdatePlatformSellersRequestKind Individual = new(Values.Individual);

    public static readonly UpdatePlatformSellersRequestKind Entity = new(Values.Entity);

    public UpdatePlatformSellersRequestKind(string value)
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
    public static UpdatePlatformSellersRequestKind FromCustom(string value)
    {
        return new UpdatePlatformSellersRequestKind(value);
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

    public static bool operator ==(UpdatePlatformSellersRequestKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdatePlatformSellersRequestKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdatePlatformSellersRequestKind value) => value.Value;

    public static explicit operator UpdatePlatformSellersRequestKind(string value) => new(value);

    internal class UpdatePlatformSellersRequestKindSerializer
        : JsonConverter<UpdatePlatformSellersRequestKind>
    {
        public override UpdatePlatformSellersRequestKind Read(
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
            return new UpdatePlatformSellersRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdatePlatformSellersRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdatePlatformSellersRequestKind ReadAsPropertyName(
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
            return new UpdatePlatformSellersRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdatePlatformSellersRequestKind value,
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
