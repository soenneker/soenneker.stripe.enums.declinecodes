[![](https://img.shields.io/nuget/v/soenneker.stripe.enums.declinecodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.declinecodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.declinecodes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.declinecodes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.enums.declinecodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.declinecodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.declinecodes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.declinecodes/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Enums.DeclineCodes

Provides strongly typed Stripe decline-code values for classifying failed card and payment attempts without scattering protocol strings through application code.

## Installation

```bash
dotnet add package Soenneker.Stripe.Enums.DeclineCodes
```

## Usage

```csharp
using Soenneker.Stripe.Enums.DeclineCodes;

if (StripeDeclineCode.TryFromValue(declineCode, out StripeDeclineCode? code))
{
    if (code == StripeDeclineCode.InsufficientFunds)
    {
        // Ask the customer to use another payment method.
    }
}
```

Use `Value` when passing a code to string-based APIs, and `FromValue` when an unknown value should be treated as an error. Decline codes are diagnostic inputs, not customer-facing copy; avoid exposing fraud signals or issuer-only detail.
