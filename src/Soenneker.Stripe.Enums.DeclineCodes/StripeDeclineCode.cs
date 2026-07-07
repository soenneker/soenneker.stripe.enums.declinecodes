using Soenneker.Gen.EnumValues;

namespace Soenneker.Stripe.Enums.DeclineCodes;

/// <summary>
/// A strongly-typed list of Stripe card decline codes, used to identify and respond to specific card failure reasons.
/// </summary>
[EnumValue<string>]
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

    /// <summary>
    /// The payment can't be authorized.
    /// </summary>
    public static readonly StripeDeclineCode ApproveWithId = new("approve_with_id");

    /// <summary>
    /// The required authentication wasn't handled.
    /// </summary>
    public static readonly StripeDeclineCode AuthenticationNotHandled = new("authentication_not_handled");

    /// <summary>
    /// The card was declined for an unknown reason.
    /// </summary>
    public static readonly StripeDeclineCode CallIssuer = new("call_issuer");

    /// <summary>
    /// The card doesn't support this type of purchase.
    /// </summary>
    public static readonly StripeDeclineCode CardNotSupported = new("card_not_supported");

    /// <summary>
    /// The customer exceeded an available card balance, credit limit, or transaction amount limit.
    /// </summary>
    public static readonly StripeDeclineCode CardVelocityExceeded = new("card_velocity_exceeded");

    /// <summary>
    /// The payment violates terms of service, program rules, or applicable laws.
    /// </summary>
    public static readonly StripeDeclineCode ComplianceViolation = new("compliance_violation");

    /// <summary>
    /// The card doesn't support the specified currency.
    /// </summary>
    public static readonly StripeDeclineCode CurrencyNotSupported = new("currency_not_supported");

    /// <summary>
    /// The card was declined for an unknown reason.
    /// </summary>
    public static readonly StripeDeclineCode DoNotTryAgain = new("do_not_try_again");

    /// <summary>
    /// A duplicate transaction was submitted very recently.
    /// </summary>
    public static readonly StripeDeclineCode DuplicateTransaction = new("duplicate_transaction");

    /// <summary>
    /// The payment has expired payment information.
    /// </summary>
    public static readonly StripeDeclineCode ExpiredPaymentInformation = new("expired_payment_information");

    /// <summary>
    /// The address entered by the customer is incorrect.
    /// </summary>
    public static readonly StripeDeclineCode IncorrectAddress = new("incorrect_address");

    /// <summary>
    /// The CVC number is incorrect.
    /// </summary>
    public static readonly StripeDeclineCode IncorrectCvc = new("incorrect_cvc");

    /// <summary>
    /// The card number is incorrect.
    /// </summary>
    public static readonly StripeDeclineCode IncorrectNumber = new("incorrect_number");

    /// <summary>
    /// The PIN entered is incorrect.
    /// </summary>
    public static readonly StripeDeclineCode IncorrectPin = new("incorrect_pin");

    /// <summary>
    /// The card or account connected to the card is invalid.
    /// </summary>
    public static readonly StripeDeclineCode InvalidAccount = new("invalid_account");

    /// <summary>
    /// The payment amount is invalid or exceeds the allowed amount.
    /// </summary>
    public static readonly StripeDeclineCode InvalidAmount = new("invalid_amount");

    /// <summary>
    /// The payment authorization is invalid or revoked.
    /// </summary>
    public static readonly StripeDeclineCode InvalidAuthorization = new("invalid_authorization");

    /// <summary>
    /// The customer's billing agreement is invalid.
    /// </summary>
    public static readonly StripeDeclineCode InvalidBillingAgreement = new("invalid_billing_agreement");

    /// <summary>
    /// The business account is deactivated.
    /// </summary>
    public static readonly StripeDeclineCode InvalidBusinessAccount = new("invalid_business_account");

    /// <summary>
    /// The customer's account can't be charged.
    /// </summary>
    public static readonly StripeDeclineCode InvalidCustomerAccount = new("invalid_customer_account");

    /// <summary>
    /// The CVC number is invalid.
    /// </summary>
    public static readonly StripeDeclineCode InvalidCvc = new("invalid_cvc");

    /// <summary>
    /// The expiration month is invalid.
    /// </summary>
    public static readonly StripeDeclineCode InvalidExpiryMonth = new("invalid_expiry_month");

    /// <summary>
    /// The expiration year is invalid.
    /// </summary>
    public static readonly StripeDeclineCode InvalidExpiryYear = new("invalid_expiry_year");

    /// <summary>
    /// The card number is invalid.
    /// </summary>
    public static readonly StripeDeclineCode InvalidNumber = new("invalid_number");

    /// <summary>
    /// The payment has invalid information.
    /// </summary>
    public static readonly StripeDeclineCode InvalidPaymentInformation = new("invalid_payment_information");

    /// <summary>
    /// The PIN entered is invalid.
    /// </summary>
    public static readonly StripeDeclineCode InvalidPin = new("invalid_pin");

    /// <summary>
    /// The card issuer couldn't be reached.
    /// </summary>
    public static readonly StripeDeclineCode IssuerNotAvailable = new("issuer_not_available");

    /// <summary>
    /// The payment matches a value on the Stripe user's block list.
    /// </summary>
    public static readonly StripeDeclineCode MerchantBlacklist = new("merchant_blacklist");

    /// <summary>
    /// Mobile device authentication is required.
    /// </summary>
    public static readonly StripeDeclineCode MobileDeviceAuthenticationRequired = new("mobile_device_authentication_required");

    /// <summary>
    /// New account information is available.
    /// </summary>
    public static readonly StripeDeclineCode NewAccountInformationAvailable = new("new_account_information_available");

    /// <summary>
    /// No action was taken.
    /// </summary>
    public static readonly StripeDeclineCode NoActionTaken = new("no_action_taken");

    /// <summary>
    /// The payment isn't permitted.
    /// </summary>
    public static readonly StripeDeclineCode NotPermitted = new("not_permitted");

    /// <summary>
    /// Offline PIN is required.
    /// </summary>
    public static readonly StripeDeclineCode OfflinePinRequired = new("offline_pin_required");

    /// <summary>
    /// Online or offline PIN is required.
    /// </summary>
    public static readonly StripeDeclineCode OnlineOrOfflinePinRequired = new("online_or_offline_pin_required");

    /// <summary>
    /// The local payment method provider declined the payment.
    /// </summary>
    public static readonly StripeDeclineCode PartnerGenericDecline = new("partner_generic_decline");

    /// <summary>
    /// The local payment method provider labeled this customer as high risk.
    /// </summary>
    public static readonly StripeDeclineCode PartnerHighRiskCustomer = new("partner_high_risk_customer");

    /// <summary>
    /// The local payment method provider can't find this payment.
    /// </summary>
    public static readonly StripeDeclineCode PartnerPaymentNotFound = new("partner_payment_not_found");

    /// <summary>
    /// There's a dispute over the payment.
    /// </summary>
    public static readonly StripeDeclineCode PaymentDisputed = new("payment_disputed");

    /// <summary>
    /// The order exceeds a customer account limit.
    /// </summary>
    public static readonly StripeDeclineCode PaymentLimitExceeded = new("payment_limit_exceeded");

    /// <summary>
    /// The customer can't use this card to make this payment.
    /// </summary>
    public static readonly StripeDeclineCode PickupCard = new("pickup_card");

    /// <summary>
    /// The allowable number of PIN tries was exceeded.
    /// </summary>
    public static readonly StripeDeclineCode PinTryExceeded = new("pin_try_exceeded");

    /// <summary>
    /// The customer's bank doesn't support recurring payments.
    /// </summary>
    public static readonly StripeDeclineCode RecurringNotSupportedByBank = new("recurring_not_supported_by_bank");

    /// <summary>
    /// The payment couldn't be processed by the issuer for an unknown reason.
    /// </summary>
    public static readonly StripeDeclineCode ReenterTransaction = new("reenter_transaction");

    /// <summary>
    /// All authorizations were revoked.
    /// </summary>
    public static readonly StripeDeclineCode RevocationOfAllAuthorizations = new("revocation_of_all_authorizations");

    /// <summary>
    /// The authorization was revoked.
    /// </summary>
    public static readonly StripeDeclineCode RevocationOfAuthorization = new("revocation_of_authorization");

    /// <summary>
    /// The card was declined for a security violation.
    /// </summary>
    public static readonly StripeDeclineCode SecurityViolation = new("security_violation");

    /// <summary>
    /// The service isn't allowed.
    /// </summary>
    public static readonly StripeDeclineCode ServiceNotAllowed = new("service_not_allowed");

    /// <summary>
    /// A stop payment order exists.
    /// </summary>
    public static readonly StripeDeclineCode StopPaymentOrder = new("stop_payment_order");

    /// <summary>
    /// A Stripe test card number was used.
    /// </summary>
    public static readonly StripeDeclineCode TestmodeDecline = new("testmode_decline");

    /// <summary>
    /// The payment should be tried again later.
    /// </summary>
    public static readonly StripeDeclineCode TryAgainLater = new("try_again_later");

    /// <summary>
    /// The customer exceeded the available balance or credit limit.
    /// </summary>
    public static readonly StripeDeclineCode WithdrawalCountLimitExceeded = new("withdrawal_count_limit_exceeded");
}
