using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType.AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorTypeSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType
    : IStringEnum
{
    public static readonly AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType ManagingCurrent =
        new(Values.ManagingCurrent);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType ManagingFormer =
        new(Values.ManagingFormer);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType SupervisoryCurrent =
        new(Values.SupervisoryCurrent);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType SupervisoryFormer =
        new(Values.SupervisoryFormer);

    public AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType(string value)
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
    public static AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType FromCustom(
        string value
    )
    {
        return new AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType(value);
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
        AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType value
    ) => value.Value;

    public static explicit operator AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType(
        string value
    ) => new(value);

    internal class AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorTypeSerializer
        : JsonConverter<AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType>
    {
        public override AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType Read(
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
            return new AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType ReadAsPropertyName(
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
            return new AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsGetDeclarationsResponseApprovalSignaturesItemDirectorType value,
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
        public const string ManagingCurrent = "managing_current";

        public const string ManagingFormer = "managing_former";

        public const string SupervisoryCurrent = "supervisory_current";

        public const string SupervisoryFormer = "supervisory_former";
    }
}
