using Intellenum;

namespace Soenneker.Stripe.Enums.DeclineCodes;

/// <summary>
/// A strongly-typed list of Stripe card decline codes, used to identify and respond to specific card failure reasons.
/// </summary>
[Intellenum<string>]
public partial class StripeDeclineCode
{
    /// <summary>
    /// The bank did not approve the transaction for an unspecified reason.
    /// </summary>
    public static readonly StripeDeclineCode DoNotHonor = new("do_not_honor");

    /// <summary>
    /// The card has been reported lost.
    /// </summary>
    public static readonly StripeDeclineCode LostCard = new("lost_card");

    /// <summary>
    /// The card has been reported stolen.
    /// </summary>
    public static readonly StripeDeclineCode StolenCard = new("stolen_card");

    /// <summary>
    /// The card has insufficient funds to complete the purchase.
    /// </summary>
    public static readonly StripeDeclineCode InsufficientFunds = new("insufficient_funds");

    /// <summary>
    /// The card is expired.
    /// </summary>
    public static readonly StripeDeclineCode ExpiredCard = new("expired_card");

    /// <summary>
    /// The card is not allowed to make this type of purchase.
    /// </summary>
    public static readonly StripeDeclineCode TransactionNotAllowed = new("transaction_not_allowed");

    /// <summary>
    /// The transaction was declined by the issuing bank due to a processing error.
    /// </summary>
    public static readonly StripeDeclineCode ProcessingError = new("processing_error");

    /// <summary>
    /// The card is restricted for use on the internet or with this type of merchant.
    /// </summary>
    public static readonly StripeDeclineCode RestrictedCard = new("restricted_card");

    /// <summary>
    /// The authentication was not successful or required and not provided.
    /// </summary>
    public static readonly StripeDeclineCode AuthenticationRequired = new("authentication_required");

    /// <summary>
    /// The card was declined due to a suspected fraudulent transaction.
    /// </summary>
    public static readonly StripeDeclineCode Fraudulent = new("fraudulent");

    /// <summary>
    /// The card’s verification (e.g., ZIP or CVC) failed.
    /// </summary>
    public static readonly StripeDeclineCode IncorrectZip = new("incorrect_zip");

    /// <summary>
    /// The card was declined, try again or use a different method.
    /// </summary>
    public static readonly StripeDeclineCode GenericDecline = new("generic_decline");
}