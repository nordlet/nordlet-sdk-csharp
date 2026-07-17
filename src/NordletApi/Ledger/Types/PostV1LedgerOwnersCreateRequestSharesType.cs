using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1LedgerOwnersCreateRequestSharesType.PostV1LedgerOwnersCreateRequestSharesTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1LedgerOwnersCreateRequestSharesType : IStringEnum
{
    public static readonly PostV1LedgerOwnersCreateRequestSharesType V = new(Values.V);

    public static readonly PostV1LedgerOwnersCreateRequestSharesType Pr = new(Values.Pr);

    public static readonly PostV1LedgerOwnersCreateRequestSharesType Pp = new(Values.Pp);

    public static readonly PostV1LedgerOwnersCreateRequestSharesType Prv = new(Values.Prv);

    public PostV1LedgerOwnersCreateRequestSharesType(string value)
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
    public static PostV1LedgerOwnersCreateRequestSharesType FromCustom(string value)
    {
        return new PostV1LedgerOwnersCreateRequestSharesType(value);
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
        PostV1LedgerOwnersCreateRequestSharesType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1LedgerOwnersCreateRequestSharesType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1LedgerOwnersCreateRequestSharesType value) =>
        value.Value;

    public static explicit operator PostV1LedgerOwnersCreateRequestSharesType(string value) =>
        new(value);

    internal class PostV1LedgerOwnersCreateRequestSharesTypeSerializer
        : JsonConverter<PostV1LedgerOwnersCreateRequestSharesType>
    {
        public override PostV1LedgerOwnersCreateRequestSharesType Read(
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
            return new PostV1LedgerOwnersCreateRequestSharesType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1LedgerOwnersCreateRequestSharesType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1LedgerOwnersCreateRequestSharesType ReadAsPropertyName(
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
            return new PostV1LedgerOwnersCreateRequestSharesType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1LedgerOwnersCreateRequestSharesType value,
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
        public const string V = "V";

        public const string Pr = "PR";

        public const string Pp = "PP";

        public const string Prv = "PRV";
    }
}
