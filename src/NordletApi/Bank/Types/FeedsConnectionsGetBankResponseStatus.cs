using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsConnectionsGetBankResponseStatus.FeedsConnectionsGetBankResponseStatusSerializer)
)]
[Serializable]
public readonly record struct FeedsConnectionsGetBankResponseStatus : IStringEnum
{
    public static readonly FeedsConnectionsGetBankResponseStatus Pending = new(Values.Pending);

    public static readonly FeedsConnectionsGetBankResponseStatus Active = new(Values.Active);

    public static readonly FeedsConnectionsGetBankResponseStatus Expired = new(Values.Expired);

    public static readonly FeedsConnectionsGetBankResponseStatus Revoked = new(Values.Revoked);

    public static readonly FeedsConnectionsGetBankResponseStatus Error = new(Values.Error);

    public FeedsConnectionsGetBankResponseStatus(string value)
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
    public static FeedsConnectionsGetBankResponseStatus FromCustom(string value)
    {
        return new FeedsConnectionsGetBankResponseStatus(value);
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

    public static bool operator ==(FeedsConnectionsGetBankResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FeedsConnectionsGetBankResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FeedsConnectionsGetBankResponseStatus value) =>
        value.Value;

    public static explicit operator FeedsConnectionsGetBankResponseStatus(string value) =>
        new(value);

    internal class FeedsConnectionsGetBankResponseStatusSerializer
        : JsonConverter<FeedsConnectionsGetBankResponseStatus>
    {
        public override FeedsConnectionsGetBankResponseStatus Read(
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
            return new FeedsConnectionsGetBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsConnectionsGetBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsConnectionsGetBankResponseStatus ReadAsPropertyName(
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
            return new FeedsConnectionsGetBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsConnectionsGetBankResponseStatus value,
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
        public const string Pending = "pending";

        public const string Active = "active";

        public const string Expired = "expired";

        public const string Revoked = "revoked";

        public const string Error = "error";
    }
}
