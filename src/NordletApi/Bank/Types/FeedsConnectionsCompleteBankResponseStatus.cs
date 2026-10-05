using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsConnectionsCompleteBankResponseStatus.FeedsConnectionsCompleteBankResponseStatusSerializer)
)]
[Serializable]
public readonly record struct FeedsConnectionsCompleteBankResponseStatus : IStringEnum
{
    public static readonly FeedsConnectionsCompleteBankResponseStatus Pending = new(Values.Pending);

    public static readonly FeedsConnectionsCompleteBankResponseStatus Active = new(Values.Active);

    public static readonly FeedsConnectionsCompleteBankResponseStatus Expired = new(Values.Expired);

    public static readonly FeedsConnectionsCompleteBankResponseStatus Revoked = new(Values.Revoked);

    public static readonly FeedsConnectionsCompleteBankResponseStatus Error = new(Values.Error);

    public FeedsConnectionsCompleteBankResponseStatus(string value)
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
    public static FeedsConnectionsCompleteBankResponseStatus FromCustom(string value)
    {
        return new FeedsConnectionsCompleteBankResponseStatus(value);
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
        FeedsConnectionsCompleteBankResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FeedsConnectionsCompleteBankResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FeedsConnectionsCompleteBankResponseStatus value) =>
        value.Value;

    public static explicit operator FeedsConnectionsCompleteBankResponseStatus(string value) =>
        new(value);

    internal class FeedsConnectionsCompleteBankResponseStatusSerializer
        : JsonConverter<FeedsConnectionsCompleteBankResponseStatus>
    {
        public override FeedsConnectionsCompleteBankResponseStatus Read(
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
            return new FeedsConnectionsCompleteBankResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsConnectionsCompleteBankResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsConnectionsCompleteBankResponseStatus ReadAsPropertyName(
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
            return new FeedsConnectionsCompleteBankResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsConnectionsCompleteBankResponseStatus value,
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
