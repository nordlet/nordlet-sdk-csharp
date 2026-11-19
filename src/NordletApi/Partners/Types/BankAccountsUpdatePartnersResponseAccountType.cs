using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BankAccountsUpdatePartnersResponseAccountType.BankAccountsUpdatePartnersResponseAccountTypeSerializer)
)]
[Serializable]
public readonly record struct BankAccountsUpdatePartnersResponseAccountType : IStringEnum
{
    public static readonly BankAccountsUpdatePartnersResponseAccountType Checking = new(
        Values.Checking
    );

    public static readonly BankAccountsUpdatePartnersResponseAccountType Savings = new(
        Values.Savings
    );

    public BankAccountsUpdatePartnersResponseAccountType(string value)
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
    public static BankAccountsUpdatePartnersResponseAccountType FromCustom(string value)
    {
        return new BankAccountsUpdatePartnersResponseAccountType(value);
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
        BankAccountsUpdatePartnersResponseAccountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BankAccountsUpdatePartnersResponseAccountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BankAccountsUpdatePartnersResponseAccountType value) =>
        value.Value;

    public static explicit operator BankAccountsUpdatePartnersResponseAccountType(string value) =>
        new(value);

    internal class BankAccountsUpdatePartnersResponseAccountTypeSerializer
        : JsonConverter<BankAccountsUpdatePartnersResponseAccountType>
    {
        public override BankAccountsUpdatePartnersResponseAccountType Read(
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
            return new BankAccountsUpdatePartnersResponseAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BankAccountsUpdatePartnersResponseAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BankAccountsUpdatePartnersResponseAccountType ReadAsPropertyName(
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
            return new BankAccountsUpdatePartnersResponseAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BankAccountsUpdatePartnersResponseAccountType value,
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
        public const string Checking = "checking";

        public const string Savings = "savings";
    }
}
