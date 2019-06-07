# Installing Database
Setting up MixERP database is the first task you need to perform before you
start actual development. MixERP uses one of the most advanced and open source
database engines--PostgreSQL.

PostgreSQL is a free database engine, supports almost all popular operating
systems. This makes us (MixERP community) less tied to just one particular OS
platform. PostgreSQL is reliable, powerful, modern, and developer-friendly
database and has one of the most resourceful and highly regarded
open source communities ever.

Choosing PostgreSQL was a very conscious and spontaneous decision we made
when we started development. PostgreSQL has a very liberal license, which
gives us freedom over a commercial DB engine. Likewise, in the long run,
as your data grows bigger, you will never have to worry about the license fees
and associated costs of upgrade and ownership. This can be a costly factor
to have been overlooked by software developers in the long run.

There are numerous companies providing commercial PostgreSQL support
and consultancy if you need support. You can always find
another company to support you if you are not happy with the existing one,
without having to change your DBMS.


## Install PostgreSQL Server First

You will need to install PostgreSQL Server, 9.3 or higher. 
Get the latest PostgreSQL server installer here:

[http://www.postgresql.org/download/](http://www.postgresql.org/download/)

<div class="ui red message">
    <div class="ui header">
        <strong>Warning</strong>
    </div>
    <div class="ui divider"></div>
    <p>
        MixERP only works on stable version of PostgreSQL Server.
        Before posting PostgreSQL errors on <a href="https://mixerp.org/erp/forum/">MixERP forums</a>,
        please do make sure that
        you do not have an alpha, beta, or gamma version.
    </p>
</div>

##Create a New Database

Create a new PostgreSQL database, name it anything you want, but

- lowercase database name is recommended
- without any fancy character or symbol.

### Collation

When you create your database, navigate to the tab "Definition". Make sure that you have the following settings:

![Collation](images/collation.png)


| Definition     | Value       |
| -------------- | ------------|
| Encoding       | UTF8        |
| Template       | template0   |
| Collation      | C or POSIX  |
| Character Type | C or POSIX  |



##Install MixERP Database
* Run PgAdmin3, select the newly created database. Click Tools --> Query Tool.
* Open the file [src/FrontEnd/db/sample-db.sql](https://github.com/mixerp/mixerp/tree/master/src/FrontEnd/db) if you want sample data.
* If you do not want sample data, open [src/FrontEnd/db/blank-db.sql](https://github.com/mixerp/mixerp/tree/master/src/FrontEnd/db) instead of the above.

<div class="ui warning message">
    <div class="ui header">
        <strong>Note</strong>
    </div>
    <div class="ui divider"></div>
    <p>
        Upon receiving a complaint that MixERP DB script produced errors, we did a quick remote connection
        to see what was going wrong on that PC. We found out that
        one of the commercial SQL tools was being used to do the job.
        To our surprise, the
        error had to do nothing with MixERP SQL script. To add insult to the injury, the
        software has misunderstanding on how PostgreSQL actually works.
        This tool supports many DBMSes, including but not limited to
        SQL Server, Oracle, DB2, PostgreSQL, MySQL, etc
        and is regarded as pretty good software for doing <em>the SQL things</em>. Many developers
        use many different DBMSes and this tool seems perfect because it supports most of them.
    </p>
    <p>
        So, we thought why don't give it a try to check how other tools worked with our script.
        We tested most of the
        <a target="_blank" href="https://wiki.postgresql.org/wiki/Community_Guide_to_PostgreSQL_GUI_Tools">available PostgreSQL database GUI tools</a>
        to run the MixERP DB script. The results were pretty shocking. Most of these softwares
        focus largely on UI but performance.
        Since MixERP has very large database scripts containing more than 100K lines of SQL code,
        some of the tools froze and gave it up altogether.
    </p>
    <p>
        <strong>PgAdmin is what we recommend</strong> because not only it is fast, but also the GUI is
        highly configurable, stable, and feature complete.
    </p>
</div>

##Related Topics
* [Part 2: Editing DB Configuration](part-2-editing-db-configuration-file.md)
* [Documentation Home](../../../index.md)