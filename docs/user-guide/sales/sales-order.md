#Sales Order

When you receive a purchase order from your customer, you enter it as sales order document in MixERP.

Purchase order, prepared and sent by your customer, contains a list of items, number of units, and agreed-upon
price.

Once you accept a purchase order sent by your customer(s), you will then need to perform 
additional steps to deliver the goods and collect the sales money, which are known as sales delivery
and receipt respectively.


#For Accountants

A sales order entry does not create any associated GL entry in the transaction tables.

#Posting a Sales Order

![Sales Order Posting](images/sales-order-posting.png)

##Top Section

![Top Section](images/sales-order-posting-top.png)

<table class="ui padded compact attached small blue table">
    <tr>
        <th>Value Date
        </th>
        <td>The effective date of sales order posting.
        </td>
    </tr>
    <tr>
        <th>Select Store
        </th>
        <td>Select a store from where you want to deliver goods during sales delivery.
        </td>
    </tr>
    <tr>
        <th>Select Party
        </th>
        <td>
            <p>Select the customer who sent the PO.</p>
            <div class="ui info message"> This is a cascading field. When you enter a valid party code in the text box, the associated party will be automatically chosen in the drop down control. </div>
        </td>
    </tr>
    <tr>
        <th>Price Type
        </th>
        <td>
            <p>Select the price type associated with this transaction. On a default installation of MixERP, price types are :</p>
            <ul><li>Retail</li><li>Wholesale</li></ul>
            <p>Depending on the price type, effective items selling prices will be displayed.</p>
        </td>
    </tr>
    <tr>
        <th>Ref #
        </th>
        <td>Enter a reference number for this transaction, which will be helpful for filtering transactions later. If applicable, use this field to enter the PO number associated with the PO document which came in.
        </td>
    </tr>
    <tr>
        <th>Shipping Company
        </th>
        <td>Select the shipping company for delivering goods during sales delivery.
        </td>
    </tr>
    <tr>
        <th>Shipping Address
        </th>
        <td>A party may have multiple shipping addresses. So, select the desired shipping address code here. Once you select a shipping address code, the destination will be shown on the field <strong>Shipping Address</strong> on the bottom section of this document.
        </td>
    </tr>
    <tr>
        <th>Sales Type
        </th>
        <td>Select a sales type from the list.
        </td>
    </tr>
</table>

##Details Section

![Details Section](images/sales-order-posting-details.png)

<table class="ui padded compact attached small blue table celled striped">
    <tbody>
        <tr>
            <th>Item Code</th>
            <td>Enter a valid item code of the product, which will automatically cascade to the field <strong>Item Name</strong>.</td>
        </tr>
        <tr>
            <th>Item Name</th>
            <td>Select the item from the drop down control. This field will automatically update the field <strong>Item Code</strong>.</td>
        </tr>
        <tr>
            <th>Qty</th>
            <td>Enter the quantity of items you have received order for.</td>
        </tr>
        <tr>
            <th>Unit</th>
            <td>Select the unit associated with the item selected earlier.</td>
        </tr>
        <tr>
            <th>Price</th>
            <td>Once you select an item and provide unit and quantity, the unit price will automatically be updated. You can override the price shown for this quote.</td>
        </tr>
        <tr>
            <th>Amount</th>
            <td>This is a computed field. <strong>Amount = Qty * Price</strong>
            </td>
        </tr>
        <tr>
            <th>Discount</th>
            <td>Enter a flat amount here if you wish to provide a discount.</td>
        </tr>
        <tr>
            <th>Shipping Charge</th>
            <td>Enter shipping charge, if applicable.</td>
        </tr>
        <tr>
            <th>Sub Total</th>
            <td>This a computed field. <strong>Sub Total = Amount - Discount + Shipping Charge</strong>
            </td>
        </tr>
        <tr>
            <th>Tax Form</th>
            <td>Select a sales tax from the list. Once you leave this field, tax is calculated and updated on the field Tax.</td>
        </tr>
        <tr>
            <th>Tax</th>
            <td>This is a computed field.</td>
        </tr>
        <tr>
            <th>Add</th>
            <td>Click this button or hit <strong>CTRL + RETURN</strong> to add the current line to the grid.</td>
        </tr>
    </tbody>
</table>

##Bottom Section

![Bottom Section](images/sales-order-posting-bottom.png)
<table class="ui padded compact attached small blue table celled striped">
    <tbody>
        <tr>
            <th>Attachments</th>
            <td>See <a href="../../user-guide/core-concepts/inline-attachment-manager.md">Inline Attachment Manager</a>
            </td>
        </tr>
        <tr>
            <th>Shipping Address</th>
            <td>This is a readonly field, updated by the field <strong>Shipping Address in the top section</strong>.</td>
        </tr>
        <tr>
            <th>Running Total</th>
            <td>This is a computed field. <strong>Running Total = Sum of Sub Totals</strong>
            </td>
        </tr>
        <tr>
            <th>Tax Total</th>
            <td>This is also a computed field. <strong>Tax Total = Sum of Taxes</strong>
            </td>
        </tr>
        <tr>
            <th>Grand Total</th>
            <td>This is also a computed field. <strong>Grand Total = Running Total + Tax Total</strong>
            </td>
        </tr>
        <tr>
            <th>Salesperson</th>
            <td>Select the salesperson from the drop down control.</td>
        </tr>
        <tr>
            <th>Statement Reference</th>
            <td>Enter a text reference or a memo which helps explain this transaction when you read it later.</td>
        </tr>
        <tr>
            <th>Save</th>
            <td>Click this button to save the quotation.</td>
        </tr>
    </tbody>
</table>


#Understanding Sales Order View

![Sales Order View](images/sales-order-view.png)

As soon as you post a sales order transaction, it appears in this view. You can then take further actions
like automating, merging, and/or flagging transactions, both individually or in batches.

##Merge Batch to Sales Delivery

Click this button to create a sales delivery entry against the selected sales order(s).


##Flag

See the chapter [Flag](../../user-guide/core-concepts/flags.md) for more information on flagging transactions.


##Related Topics
* [Sales Module](index.md)
