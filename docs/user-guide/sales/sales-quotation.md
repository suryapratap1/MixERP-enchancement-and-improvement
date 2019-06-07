#Sales Quotation

A business has prospective customers, who are interested to first know the cost of
item(s) (products or services) before they actually make a purchase.
Creating a quotation is the first step in the sales cycle which enables you to provide an
estimated price of goods or service a customer is interested in.

#For Accountants

A sales quotation entry does not create any associated GL entry in the transaction tables.

#Creating a Sales Quotation

![Sales Quotation Entry](images/sales-quotation-entry.png)

##Top Section

![Top Section](images/sales-quotation-entry-top.png)

<table class="ui padded compact attached small blue table">
    <tr>
        <th>Value Date
        </th>
        <td>The effective date of quotation posting.
        </td>
    </tr>
    <tr>
        <th>Select Store
        </th>
        <td>Select a store from where you want to deliver goods if this quotation accepted by the client.
        </td>
    </tr>
    <tr>
        <th>Select Party
        </th>
        <td>
            Select a customer for whom you are creating the quote.
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
        <td>Enter a reference number for this transaction, which will be helpful for filtering transactions later.
        </td>
    </tr>
    <tr>
        <th>Shipping Company
        </th>
        <td>Select a shipping company for delivering goods if this quotation is accepted by the client.
        </td>
    </tr>
    <tr>
        <th>Shipping Address
        </th>
        <td>A party may have multiple shipping addresses. So, select the desired shipping address code here. Once you select a shipping address code, the destination will be shown on the field <strong>Shipping Address on the bottom section</strong> of this document.
        </td>
    </tr>
    <tr>
        <th>Sales Type
        </th>
        <td>
            Select a sales type from the list:
            <ul>
                <li>Taxable Sales</li>
                <li>Nontaxable Sales</li>
            </ul>
            Sales transactions usually incur sales taxes, except when:
            <ul>
                <li>the party you are selling to is tax exempted.</li>
                <li>the goods you are selling is tax exempted.</li>
                <li>there is a tax holiday during this transaction period.</li>
                <li>etc.
            </ul>
            For more information, Refer to the chapter <a href="../../user-guide/core-concepts/understanding-and-configuring-taxes.md">Understanding & Configuring Taxes</a>.
        </td>
    </tr>
</table>

##Details Section

![Details Section](images/sales-quotation-entry-details.png)

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
        <td>Enter the quantity of items you are quoting.
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
        <td>Enter shipping charge, if applicable.
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
        <td>Select a sales tax from the list. Once you leave this field, tax is calculated and updated on the field Tax.
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

![Bottom Section](images/sales-quotation-entry-bottom.png)

<table class="ui padded compact attached small blue table">
    <tr>
        <th>Attachments
        </th>
        <td>
            See <a href="../../user-guide/core-concepts/inline-attachment-manager.md">Inline Attachment Manager</a>
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
        <td>Click this button to save the quotation.
        </td>
    </tr>
</table>


#Quickstart Guide

<video src="videos/sales-quotation-entry.webm" style="height:500px;width:900px;" controls>
   Your browser does not implement html5 video. [Click here](videos/initialize-eod.webm) to download.
</video>



#Understanding Sales Quotation View

![Sales Quotation View](images/sales-quotation-view.png)

As soon as you post a sales quotation, it appears in this view. You can then take further actions
like automating, merging, and/or flagging transactions, both individually or in batches.


##Merge Batch to Sales Order

Once the client accepts and approves your quotation, she would further send you a purchase order against the quote
or multiple quotes. Select a row or create a batch by simply checking multiple rows and then click the button
**"Merge Batch to Sales Order"**, which will automatically create a sales order screen for you.

But, before proceeding, just remember that :

* you cannot create a batch by selecting quotation of two different parties.
* a batch cannot contain a previously-merged row.


##Merge Batch to Sales Delivery

You can **entirely skip a step of entering a Sales Order** and jump directly into recording a sales delivery.
Similarly, the merge feature automatically creates a sales delivery screen, as mentioned above.

##Flag

See the chapter [Flag](../../user-guide/core-concepts/flags.md) for more information on flagging transactions.


#Quickstart Guide

<video src="videos/sales-quotation-view.webm" style="height:500px;width:900px;" controls>
   Your browser does not implement html5 video. [Click here](videos/initialize-eod.webm) to download.
</video>


##Related Topics
* [Sales Module](index.md)
