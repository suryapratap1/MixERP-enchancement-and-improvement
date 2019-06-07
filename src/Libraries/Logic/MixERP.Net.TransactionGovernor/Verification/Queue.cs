namespace MixERP.Net.TransactionGovernor.Verification
{
    public static class Stack
    {
        public static int CountItemsInVerificationStack(string catalog, int officeId)
        {
            return Data.Verification.Stack.CountItemsInVerificationStack(catalog, officeId);
        }
    }
}