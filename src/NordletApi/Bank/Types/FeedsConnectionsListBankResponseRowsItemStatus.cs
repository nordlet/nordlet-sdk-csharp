using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FeedsConnectionsListBankResponseRowsItemStatus.FeedsConnectionsListBankResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct FeedsConnectionsListBankResponseRowsItemStatus : IStringEnum
{
    public static readonly FeedsConnectionsListBankResponseRowsItemStatus Pending = new(
        Values.Pending
    );

    public static readonly FeedsConnectionsListBankResponseRowsItemStatus Active = new(
        Values.Active
    );

    public static readonly FeedsConnectionsListBankResponseRowsItemStatus Expired = new(
        Values.Expired
    );

    public static readonly FeedsConnectionsListBankResponseRowsItemStatus Revoked = new(
        Values.Revoked
    );

    public static readonly FeedsConnectionsListBankResponseRowsItemStatus Error = new(Values.Error);

    public FeedsConnectionsListBankResponseRowsItemStatus(string value)
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
    public static FeedsConnectionsListBankResponseRowsItemStatus FromCustom(string value)
    {
        return new FeedsConnectionsListBankResponseRowsItemStatus(value);
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
        FeedsConnectionsListBankResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FeedsConnectionsListBankResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FeedsConnectionsListBankResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator FeedsConnectionsListBankResponseRowsItemStatus(string value) =>
        new(value);

    internal class FeedsConnectionsListBankResponseRowsItemStatusSerializer
        : JsonConverter<FeedsConnectionsListBankResponseRowsItemStatus>
    {
        public override FeedsConnectionsListBankResponseRowsItemStatus Read(
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
            return new FeedsConnectionsListBankResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FeedsConnectionsListBankResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FeedsConnectionsListBankResponseRowsItemStatus ReadAsPropertyName(
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
            return new FeedsConnectionsListBankResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FeedsConnectionsListBankResponseRowsItemStatus value,
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
