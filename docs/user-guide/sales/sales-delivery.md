#Sales Delivery

Once you accept a purchase order sent by your customer(s), you will then need to perform 
additional steps to deliver the goods which is known as sales delivery. A sales delivery document
is created when the shipment is sent to the customer from you store.


#For Accountants

A sales delivery entry creates the following GL entries:

##If Perpetual Inventory System

<table class="ui compact striped small table">
    <thead>
        <tr>
            <th>
                Account
            </th>
            <th>
                Type
            </th>
            <th>
                Mapping
            </th>
            <th>
                Amount
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                Sales Account
            </td>
            <td>
                Incomes
            </td>
            <td>
                Item Groups
            </td>
            <td>
                Credit
            </td>
        </tr>
        <tr>
            <td>
                Inventory Account
            </td>
            <td>
                Assets
            </td>
            <td>
                Item Groups
            </td>
            <td>
                Credit
            </td>
        </tr>
        <tr>
            <td>
                Tax Account (If Applicable)
            </td>
            <td>
                Accounts Payable
            </td>
            <td>
                Tax Form
            </td>
            <td>
                Credit
            </td>
        </tr>
        <tr>
            <td>
                Shipper Account (If Applicable)
            </td>
            <td>
                Accounts Payable
            </td>
            <td>
                Shipper
            </td>
            <td>
                Credit
            </td>
        </tr>
        <tr>
            <td>
                Associated Party's GL Account
            </td>
            <td>
                AP/AR
            </td>
            <td>
                Party Account
            </td>
            <td>
                Debit
            </td>
        </tr>
        <tr>
            <td>
                COGS Account
            </td>
            <td>
                Expenses
            </td>
            <td>
                Item Groups
            </td>
            <td>
                Debit
            </td>
        </tr>
        <tr>
            <td>
                Sales Discount (If Applicable)
            </td>
            <td>
                Expenses
            </td>
            <td>
                Item Groups
            </td>
            <td>
                Debit
            </td>
        </tr>
    </tbody>
</table>



##If Periodic Inventory System

<table class="ui compact striped small table">
    <thead>
        <tr>
            <th>
                Account
            </th>
            <th>
                Type
            </th>
            <th>
                Mapping
            </th>
            <th>
                Amount
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                Sales Account
            </td>
            <td>
                Incomes
            </td>
            <td>
                Item Groups
            </td>
            <td>
                Credit
            </td>
        </tr>
        <tr>
            <td>
                Tax Account (If Applicable)
            </td>
            <td>
                Accounts Payable
            </td>
            <td>
                Tax Form
            </td>
            <td>
                Credit
            </td>
        </tr>
        <tr>
            <td>
                Shipper Account (If Applicable)
            </td>
            <td>
                Accounts Payable
            </td>
            <td>
                Shipper
            </td>
            <td>
                Credit
            </td>
        </tr>
        <tr>
            <td>
                Associated Party's GL Account
            </td>
            <td>
                AP/AR
            </td>
            <td>
                Party Account
            </td>
            <td>
                Debit
            </td>
        </tr>
        <tr>
            <td>
                Sales Discount (If Applicable)
            </td>
            <td>
                Expenses
            </td>
            <td>
                Item Groups
            </td>
            <td>
                Debit
            </td>
        </tr>
    </tbody>
</table>



#Posting a Sales Delivery

![Sales Delivery Posting](images/sales-delivery-posting.png)

##Top Section

![Top Section](images/sales-delivery-posting-top.png)

<table class="ui padded compact attached small blue table">
    <tr>
        <th>Value Date
        </th>
        <td>The effective date of sales delivery posting.
        </td>
    </tr>
    <tr>
        <th>Select Store
        </th>
        <td>Select a store from where you want to deliver goods.
        </td>
    </tr>
    <tr>
        <th>Select Party
        </th>
        <td>Select the customer who sent the PO.
            <div class="ui info message">
                This is a cascading field. When you enter a valid party code in the text box, the associated party
                will be automatically chosen in the drop down control.
            </div>
        </td>
    </tr>
    <tr>
        <th>Price Type
        </th>
        <td>
            Select the price type associated with this transaction. On a default installation of MixERP, price types are : <br/>
            <ul>
                <li>Retail</li>
                <li>Wholesale</li>
            </ul>
            Depending on the price type, effective items selling prices will be displayed.
        </td>
    </tr>
    <tr>
        <th>Ref #
        </th>
        <td>Enter a reference number for this transaction, which will be helpful for filtering transactions later. If applicable, use this field to enter the shipment number associated with the delivery.
        </td>
    </tr>
    <tr>
        <th>Payment Term
        </th>
        <td>Select a payment term you would like to link this document to. If the payment term you selected has an associated late fee, MixERP will start posting fines (late fee) once the term is over and the receivable amount was not collected.
        </td>
    </tr>
    <tr>
        <th>Shipping Company
        </th>
        <td>Select the shipping company for delivering goods.
        </td>
    </tr>
    <tr>
        <th>Shipping Address
        </th>
        <td>A party may have multiple shipping addresses. So, select the desired shipping address code here. Once you select a shipping address code, the destination will be shown on the field Shipping Address on the bottom section of this document.
        </td>
    </tr>
    <tr>
        <th>Sales Type
        </th>
        <td>Select a sales type from the list.
        </td>
    </tr>
</table>



## Details Section

![Details Section](images/sales-delivery-posting-details.png)

<table class="ui padded compact attached small blue table">
    <tr>
        <th>Item Code
        </th>
        <td>Enter a valid item code of the product, which will automatically cascade to the field <strong>Item Name</strong>.
        </td>
    </tr>
    <tr>
        <th>Item Name
        </th>
        <td>Select the item from the drop down control. This field will automatically update the field <strong>Item Code</strong>.
        </td>
    </tr>
    <tr>
        <th>Qty
        </th>
        <td>Enter the quantity of items you are delivering.
        </td>
    </tr>
    <tr>
        <th>Unit
        </th>
        <td>Select the unit associated with the item selected earlier.
        </td>
    </tr>
    <tr>
        <th>Price
        </th>
        <td>
            Once you select an item and provide unit and quantity, the unit price will automatically be updated.
            You can override the price shown for this quote.
        </td>
    </tr>
    <tr>
        <th>Amount
        </th>
        <td>This is a computed field. <strong>Amount = Qty * Price</strong>
        </td>
    </tr>
    <tr>
        <th>Discount
        </th>
        <td>Enter a flat amount here if you wish to provide a discount.
        </td>
    </tr>
    <tr>
        <th>Shipping Charge
        </th>
        <td>Enter shipping charge for this item.
        </td>
    </tr>
    <tr>
        <th>Sub Total
        </th>
        <td>This a computed field. <strong>Sub Total = Amount - Discount + Shipping Charge</strong>
        </td>
    </tr>
    <tr>
        <th>Tax Form
        </th>
        <td>Select a sales tax from the list. Once you leave this field, tax is calculated and updated on the field <strong>Tax</strong>.
        </td>
    </tr>
    <tr>
        <th>Tax
        </th>
        <td>This is a computed field.
        </td>
    </tr>
    <tr>
        <th>Add
        </th>
        <td>Click this button or hit <strong>CTRL + RETURN</strong> to add the current line to the grid.
        </td>
    </tr>
</table>

##Bottom Section

![Bottom Section](images/sales-delivery-posting-bottom.png)

<table class="ui padded compact attached small blue table">
    <tr>
        <th>Attachments
        </th>
        <td>
            See <a href="../../user-guide/core-concepts/inline-attachment-manager.md">Inline Attachment Manager</a>.
        </td>
    </tr>
    <tr>
        <th>Shipping Address
        </th>
        <td>This is a readonly field, updated by the field <strong>Shipping Address in the top section</strong>.
        </td>
    </tr>
    <tr>
        <th>Running Total
        </th>
        <td>This is a computed field. <strong>Running Total = Sum of Sub Totals</strong>
        </td>
    </tr>
    <tr>
        <th>Tax Total
        </th>
        <td>This is also a computed field. <strong>Tax Total = Sum of Taxes</strong>
        </td>
    </tr>
    <tr>
        <th>Grand Total
        </th>
        <td>This is also a computed field. <strong>Grand Total = Running Total + Tax Total</strong>
        </td>
    </tr>
    <tr>
        <th>Cost Center
        </th>
        <td>Select a cost center from the drop down control.
        </td>
    </tr>
    <tr>
        <th>Salesperson
        </th>
        <td>Select the salesperson from the drop down control.
        </td>
    </tr>
    <tr>
        <th>Statement Reference
        </th>
        <td>Enter a text reference or a memo which helps explain this transaction when you read it later.
        </td>
    </tr>
    <tr>
        <th>Save
        </th>
        <td>Click this button to save the delivery.
        </td>
    </tr>
</table>

#Understanding Sales Delivery View

![Sales Delivery View](images/sales-delivery-view.png)

As soon as you post a sales delivery transaction, it is sent to the [verification queue](../core-concepts/verification-queue.md).
If the posting user has an active autoverification policy having the 
**[sales verification limit amount](../back-office/policy/auto-verification.md)** 
greater than or equal to the total amount of this transaction, it will be automatically approved.

Also see, [voucher verification feature](../core-concepts/voucher-verification.md) for more information.


Now, once the sales delivery transaction is approved, it appears in this view. You can then take further actions
like posting a sales return entry or flagging transactions, if required; both, individually or in batches.

##Return

Click this button to post a sales return entry against the selected sales delivery.


##Flag

See the chapter [Flag](../../user-guide/core-concepts/flags.md) for more information on flagging transactions.


##Related Topics
* [Sales Module](index.md)
