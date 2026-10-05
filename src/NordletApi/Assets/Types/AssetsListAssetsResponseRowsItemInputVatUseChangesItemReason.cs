using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason.AssetsListAssetsResponseRowsItemInputVatUseChangesItemReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason
    : IStringEnum
{
    public static readonly AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason UseChange =
        new(Values.UseChange);

    public static readonly AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason Sale = new(
        Values.Sale
    );

    public static readonly AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason Withdrawal =
        new(Values.Withdrawal);

    public AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason(string value)
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
    public static AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason FromCustom(
        string value
    )
    {
        return new AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason(value);
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
        AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason value
    ) => value.Value;

    public static explicit operator AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason(
        string value
    ) => new(value);

    internal class AssetsListAssetsResponseRowsItemInputVatUseChangesItemReasonSerializer
        : JsonConverter<AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason>
    {
        public override AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason Read(
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
            return new AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason ReadAsPropertyName(
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
            return new AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsListAssetsResponseRowsItemInputVatUseChangesItemReason value,
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
        public const string UseChange = "use_change";

        public const string Sale = "sale";

        public const string Withdrawal = "withdrawal";
    }
}
