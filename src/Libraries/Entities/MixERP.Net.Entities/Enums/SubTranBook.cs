namespace MixERP.Net.Entities
{
    public enum SubTranBook
    {
        Direct,
        Quotation,
        Order, /*Readonly*/
        Delivery, /*Readonly*/
        Receipt, /*Readonly*/
        Invoice,
        Payment,
        Return,
        Transfer,
        Suspense
    }
}