using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BankAccountsCreatePartnersRequestAccountType.BankAccountsCreatePartnersRequestAccountTypeSerializer)
)]
[Serializable]
public readonly record struct BankAccountsCreatePartnersRequestAccountType : IStringEnum
{
    public static readonly BankAccountsCreatePartnersRequestAccountType Checking = new(
        Values.Checking
    );

    public static readonly BankAccountsCreatePartnersRequestAccountType Savings = new(
        Values.Savings
    );

    public BankAccountsCreatePartnersRequestAccountType(string value)
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
    public static BankAccountsCreatePartnersRequestAccountType FromCustom(string value)
    {
        return new BankAccountsCreatePartnersRequestAccountType(value);
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
        BankAccountsCreatePartnersRequestAccountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BankAccountsCreatePartnersRequestAccountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BankAccountsCreatePartnersRequestAccountType value) =>
        value.Value;

    public static explicit operator BankAccountsCreatePartnersRequestAccountType(string value) =>
        new(value);

    internal class BankAccountsCreatePartnersRequestAccountTypeSerializer
        : JsonConverter<BankAccountsCreatePartnersRequestAccountType>
    {
        public override BankAccountsCreatePartnersRequestAccountType Read(
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
            return new BankAccountsCreatePartnersRequestAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BankAccountsCreatePartnersRequestAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BankAccountsCreatePartnersRequestAccountType ReadAsPropertyName(
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
            return new BankAccountsCreatePartnersRequestAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BankAccountsCreatePartnersRequestAccountType value,
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
