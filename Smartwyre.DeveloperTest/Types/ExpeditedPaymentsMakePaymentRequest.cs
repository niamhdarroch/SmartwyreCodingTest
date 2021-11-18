﻿

namespace Smartwyre.DeveloperTest.Types
{
    public class ExpeditedPaymentsMakePaymentRequest : MakePaymentRequest
    {
        /// <summary>
        /// Validates the request
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            if (!base.Validate())
                return false;

            return PaymentScheme == PaymentScheme.ExpeditedPayments;
        }

        /// <summary>
        /// Validates if the account is eligible for an expedited payment
        /// </summary>
        /// <param name="account">Account to transfer from</param>
        /// <returns>bool</returns>
        public override bool ValidateAccountEligibility(Account account)
        {
            if (!base.ValidateAccountEligibility(account))
                return false;

            if (this.PaymentScheme != PaymentScheme.ExpeditedPayments)
                return false;
            
            return account.Balance >= Amount;
        }
    }
}
