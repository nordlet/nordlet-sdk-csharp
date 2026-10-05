using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsListAssetsResponseRowsItemStatus.AssetsListAssetsResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct AssetsListAssetsResponseRowsItemStatus : IStringEnum
{
    public static readonly AssetsListAssetsResponseRowsItemStatus Active = new(Values.Active);

    public static readonly AssetsListAssetsResponseRowsItemStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly AssetsListAssetsResponseRowsItemStatus Disposed = new(Values.Disposed);

    public AssetsListAssetsResponseRowsItemStatus(string value)
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
    public static AssetsListAssetsResponseRowsItemStatus FromCustom(string value)
    {
        return new AssetsListAssetsResponseRowsItemStatus(value);
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

    public static bool operator ==(AssetsListAssetsResponseRowsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsListAssetsResponseRowsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsListAssetsResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator AssetsListAssetsResponseRowsItemStatus(string value) =>
        new(value);

    internal class AssetsListAssetsResponseRowsItemStatusSerializer
        : JsonConverter<AssetsListAssetsResponseRowsItemStatus>
    {
        public override AssetsListAssetsResponseRowsItemStatus Read(
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
            return new AssetsListAssetsResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsListAssetsResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsListAssetsResponseRowsItemStatus ReadAsPropertyName(
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
            return new AssetsListAssetsResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsListAssetsResponseRowsItemStatus value,
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
        public const string Active = "active";

        public const string FullyDepreciated = "fully_depreciated";

        public const string Disposed = "disposed";
    }
}
