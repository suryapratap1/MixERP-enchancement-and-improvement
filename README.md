## Supported Operating System Versions

    Windows Server 2008 R2 or higher. Preferred.
    Windows 7 or higher.

## Required Software

    Microsoft .net Framework 4.6.
    Internet Information Services. A Windows Server OS is recommended because IIS on Window Desktop OS has connection limit of 10 active connections. Since we make a good use of SignalR and AJAX, you might think that MixERP is slow. Trust us, it’s not. Hosting web applications on IIS on Desktop OS (especially Windows) is not a good idea.
    PostgreSQL 9.6+ or Microsoft SQL Server 2014+ or both.
    Redis Server.

## Works on These Service Providers

    Windows VPS
    Amazon EC2 VM
    Azure Windows VM

## Browser Support of MixERP

    Mozilla Firefox 3.6 and above
    Google Chrome 4.1 and above
    Opera 9.0 and above
    Apple Safari 3.0 and above
    Microsoft Internet Explorer 7.0 and above
    May work fine on other modern browsers

## Minimum Hardware Specification

Use the following information to get yourself a rough idea about what hardware you would need to run MixERP. As a matter of fact that use case differs significantly from company to company, the following information, therefore, should be considered as bare minimum requirement, not optimal or performant one.
Hardware Suggestion for VPS Hosting

## MixERP is built to be hosted on VPS.

But we need to understand the fact that the underlying hardware quality offered by two different VPS providers can vary considerably which might have an impact on the overall system performance. In other words, the exact same hardware specification offered by two different hosting companies would actually perform differently.

## Minimum VPS Specification for 1-5 Users (Simultaneous 3 Users Assumed)

    Processor : 2 vCPU
    Memory: 2GB RAM
    Disk Space: 20GB of free disk space (varies by your usage)
    10 Mbps network connectivity

## Optimum VPS Specification for 1-5 Users (Simultaneous 3 Users Assumed)

    Processor : 3 vCPU
    Memory: 3GB RAM
    Disk Space: 30GB of free disk space (varies by your usage)
    10 Mbps network connectivity

## Minimum VPS Specification for 6-10 Users (Simultaneous 8 Users Assumed)

    Processor : 3 vCPU
    Memory: 3GB RAM
    Disk Space: 30GB of free disk space (varies by your usage)
    10 Mbps network connectivity

## Optimum VPS Specification for 6-10 Users (Simultaneous 8 Users Assumed)

    Processor : 4 vCPU
    Memory: 4GB RAM
    Disk Space: 40GB of free disk space (varies by your usage)
    10 Mbps network connectivity

## Minimum VPS Specification for 11-25 Users (Simultaneous 18 Users Assumed)

    Processor : 4 vCPU
    Memory: 4GB RAM
    Disk Space: 40GB of free disk space (varies by your usage)
    10 Mbps network connectivity

## Optimum VPS Specification for 11-25 Users (Simultaneous 18 Users Assumed)

    Processor : 6 vCPU
    Memory: 6GB RAM
    Disk Space: 60GB of free disk space (varies by your usage)
    100 Mbps network connectivity

## Minimum Dedicated Server Specification for 11-25 Users (Simultaneous 18 Users Assumed)

    Processor : Intel Dual Core Processor
    Memory: 4GB RAM
    Disk Space: 100GB of free disk space (varies by your usage)
    10 Mbps network connectivity

## Optimum Dedicated Server Specification for 11-25 Users (Simultaneous 18 Users Assumed)

    Processor : Quad Core Processor
    Memory: 6GB RAM
    Disk Space: 200GB of free disk space (varies by your usage)
    100 Mbps network connectivity

#***Contacting MixERP for hardware recommendations of your MixERP instance might save you troubles of reinstalling from scratch and data loss in the future.




**Use Case for #1**

You want to scale your *popular website* to multiple servers.

**Use Case for #2**

You want to create a new Frapid instance (with a bunch of your own modules and call it something else. Example: MixERP 2.0 is Frapid with some ERP modules.) for your customers with as minimum effort as possible. In simple words, you can host:

* foo.bar.com
* fiz.buzz.com
* fuzz.faux.com

by just pointing the DNS entries to your IIS Server. Frapid will automatically understand these domains and will create separate resources for each tenant, totally isolated from each other. By the way, Frapid also supports cookieless domains if you want to dedicate a domain name to serve static contents.

Enough about Frapid now, go and look for yourself.

## v2.0 Repositories

- [Frapid Core](https://github.com/frapid/frapid/)
- [HRM Module](https://github.com/mixerp/hrm/)
- [Finance Module](https://github.com/mixerp/finance) 
- [Inventory Module](https://github.com/mixerp/inventory)
- [Purchase Module](https://github.com/mixerp/purchases)
- [Sales Module](https://github.com/mixerp/sales)

Please note that the sales module has POS features.

# So, What Is MixERP?

MixERP is an awesome feature-rich and easy-to-use free ERP software for small business.

Designed from the ground up, MixERP Community Edition integrates most of the useful functionalities of an ERP solution with extra emphasis on simplification of the implementation.

MixERP has a guided implementation feature which makes it a piece of cake for you to properly setup your ERP instance.

### General ERP Features

* Centralized Architecture
* Access Policy Management
* Transaction Verification
* Automatic Verification
* End of Day Operations
* Document Manager
* Custom Fields
* Report Builder
* Guided First Steps


### Human Resource Management

* Attendance & Leave Management
* Employee Contracts
* Resignations, Leaves, and Exits
* Job Titles
* Employment Statuses
* Pay Grades
* Employee Experience
* Employee Qualifications
* Work Shifts


### Account Receivable / Sales / Selling
* Sales Quotation & Order
* Direct Sales
* Sales Delivery
* Sales Return
* Custom Receipts
* Sales Team & Salesperson Info
* Sales Commission
* Late Fee Fine
* Recurring Invoices

### Account Payable / Purchase / Buying / Procurement
* Purchase Order
* Direct Purchase
* Goods Receipt Note
* Purchase Return
* Purchase Reorder
* Purchase Reports


### Inventory / Stock
* Inventory Transfer
* Inventory Transfer Request
* Inventory Transfer Authorization
* Inventory Transfer Delivery
* Inventory Transfer Receipt
* Inventory Items
* Compound Inventory Items (Kits)
* Cost Price
* Selling Price
* Customer & Supplier
* Stores
* Counters
* Unit of Measure
* Compound Unit of Measure
* Shipping Companies


### Finance / Accounting
* Journal Entry
* Exchange Rate Update
* Voucher Verification
* End of Day Operations
* Chart of Accounts
* Currency Management
* Bank Accounts
* Ageing Slabs
* Cash Flow Headings
* Cash Flow Setup
* Cost Centers
* Payment Cards
* Merchant Fee Setup
* Trial Balance & PL Account
* Balance Sheet & Cash Flow


### Office / Back Office
* Tax Master
* Tax Authorities
* Sales Tax Types
* State Sales Taxes
* Counties Sales Taxes
* Sales Taxes
* Tax Exempt Types
* Sales Tax Exempts
* Sales Tax Exempt Setup
* Office & Branch Setup
* Fiscal Year Information
* Frequency & Fiscal Year Management
* Department Setup
* Role Management
* User Management
* Cash Repository Setup
* Entity Setup
* Industry Setup
* Country Setup
* State Setup
* County Setup
* Custom Fields
* Flag Management
* Voucher Verification Policy
* Automatic Verification Policy
* Menu Access Policy
* Store Policy
* Api Access Policy
* Default Entity Access Policy
* Entity Access Policy
* Database Statistics
* Backup Database
* Change User Password
* Check Updates
* Report Writer
* Opening Inventory
* Attachment Parameters
* Currencylayer Parameters
* Database Parameters
* SMTP Parameters
* MixERP Parameters
* OpenExchangeRates Parameters
* ScrudFactory Parameters
* Switches
* Other Setup
* Genders
* Identification Types
* Nationalities



#Where Is Documentation?
[MixERP Documentation Website](http://docs.mixerp.org)


##Why PostgreSQL Server?

MixERP 1.x is **PostgreSQL-only ERP** and **we will not support** any other DBMS anytime soon in the near future. However, we fully support compatible PostgreSQL forks such as [PostgreSQL Plus Advanced Server](http://www.enterprisedb.com/).

We have been receiving tons of queries on why PostgreSQL? We chose PostgreSQL Server because:

* PostgreSQL is platform independent.
* We have plans to support Apache and nginx.
* We have plans to support *nix based operating system.
* PostgreSQL is free no matter how big your data grows, unlimited processors, unlimited cores, unlimited memory. You will never be forced to upgrade to higher version due to a limitation of database size or similar.
* PostgreSQL is an [excellent choice for enterprise application](http://www.computerweekly.com/feature/Hot-skills-PostgreSQL).
* PostgreSQL does have [paid support plans](http://www.infoworld.com/article/2617783/open-source-software/the-stealth-success-of-postgresql.html) for enterprises.
* PostgreSQL is [ahead of commercial database](http://www.infoworld.com/article/2608863/nosql/postgresql-ramps-up-its-nosql-game.html) vendors in terms of development. Also see [this](https://wiki.postgresql.org/wiki/What%27s_new_in_PostgreSQL_9.0), [this](https://wiki.postgresql.org/wiki/What%27s_new_in_PostgreSQL_9.1), [this](https://wiki.postgresql.org/wiki/What%27s_new_in_PostgreSQL_9.2), [this](https://wiki.postgresql.org/wiki/What%27s_new_in_PostgreSQL_9.3), and [this](https://wiki.postgresql.org/wiki/What%27s_new_in_PostgreSQL_9.4). And [this](http://www.postgresql.org/docs/9.4/static/release-9-4-1.html) as well.
* We have been SQL Server developers long before we even knew PostgreSQL Server existed. We love SQL Server, but PostgreSQL is a better fit for, and brings added advantage to MixERP.


##You Don't Have to Bang Your Head to Learn or Implement MixERP

The first thing that we ever discussed when starting this project was simplicity. Designed from scratch, MixERP integrates most of the useful functionality of an average ERP solution with extra emphasis on simplification of its modules. Switching to MixERP from your previous ERP solution will not be a nightmare unlike in most cases with other ERP Solutions.

###MixERP Is a Pure
* multi-currency,
* multi-lingual, 
* and multi-establishment ERP Solution.

##MixERP Disallows Side Effecting Functionality

Unlike other ERP solutions, MixERP restricts some side effecting functionality. For example, modification of past dated transactions is not allowed. This ensures that you cannot have two different balance sheets of the same date because of the modifications made. 

##Related Topics
* [MixERP Documentation](http://docs.mixerp.org)
* [Developer Documentation](http://docs.mixerp.org/docs/developer/index.html)
* <a href="http://demo.mixerp.org" target="_blank">MixERP Demo Website</a>
* [Contribution Guidelines](http://docs.mixerp.org/docs/contribution-guidelines.html)
* <a href="http://mixerp.org/" target="_blank">Project Website</a>
* <a href="https://www.facebook.com/mixerp.official/" target="_blank">Follow MixERP on Facebook</a>
* <a href="http://www.facebook.com/groups/183076085203506/" target="_blank">Facebook Discussions Group</a>
* <a href="http://mixerp.org/forum/" target="_blank">Community Forum</a>
* [Project Milestone](https://github.com/mixerp/mixerp/milestones)

##List of Supported Languages

* English (MixERP Global Developers)
* Deutsch ([Johann Schwarz, Austria](https://github.com/Johann-Schwarz))
* español ([Jonathan Valle, Nicaragua](https://github.com/JonathanValle))
* français ([Nubiancc, Egypt](https://github.com/nubiancc))
* Bahasa Indonesia
* 日本語
* Bahasa Melayu
* Nederlands
* português
* русский
* svenska
* 中文
*  العربية ([Nubiancc, Egypt](https://github.com/nubiancc))

##How Can I Support MixERP?

* [Translate MixERP in your language](http://docs.mixerp.org/docs/developer/translate-mixerp.html).
* Build and host MixERP on your development server.
* Join us by following this project.
* Report bugs and/or issues on github.
* Tell your friends about MixERP.
