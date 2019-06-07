#Administrator Documentation

This document provides you insight with deploying, installing, and configuring MixERP.

#Deployment Documentation

[Deployment documentation](deployment/iis.md)

#Configuration

You may need to edit and modify one or several configuration files to suit your needs. It is, therefore,
very important to understand how MixERP uses these configuration files.

<table>
    <thead>
        <tr>
            <th>
                File
            </th>
            <th>
                Path
            </th>
            <th>
                Description/Related Module(s)
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <a href="configs/web.config.md">web.config</a>
            </td>
            <td>
                Application root or sub-directories
            </td>
            <td>
                The main configuration file IIS server uses
            </td>
        </tr>
        <tr>
            <td>
                <a href="configs/db-server.config.md">DbServer.config</a>
            </td>
            <td>
                /Resource/Configs
            </td>
            <td>
                Used by several MixERP modules, contains information about your database server
            </td>
        </tr>
        <tr>
            <td>
                <a href="configs/updater.config.md">Updater.config</a>
            </td>
            <td>
                /Resource/Configs
            </td>
            <td>
                Used by MixERP updater module to update your application instance whenever a new ERP release is available.
            </td>
        </tr>
        <tr>
            <td>
                Parameters.config
            </td>
            <td>
                /Resource/Configs
            </td>
            <td>
                MixERP core configuration file
            </td>
        </tr>
        <tr>
            <td>
                ReportParameters.config
            </td>
            <td>
                /Resource/Configs
            </td>
            <td>
                Used by ReportingEngine HTML Helper (MVC) or ReportingEngine Module (WebForms)
            </td>
        </tr>
        <tr>
            <td>
                <a href="configs/attachment-factory-parameters.md">AttachmentFactoryParameters</a>
            </td>
            <td>
                Database Table (config.attachment_factory)
            </td>
            <td>
                AttachmentFactory HTML Helper (MVC) or AttachmentFactory Module (WebForms)
            </td>
        </tr>
        <tr>
            <td>
                <a href="configs/db-parameters.md">DbParameters</a>
            </td>
            <td>
                Database Table (config.db_parameters)
            </td>
            <td>
                Used by ScrudFactory HTML Helper (MVC) or ScrudFactory Module (WebForms) for
                <a href="../developer/scrud/display-fields.md">DisplayFields.</a>
            </td>
        </tr>
        <tr>
            <td>
                <a href="configs/smtp.md">SMTP</a>
            </td>
            <td>
                Database Table (config.smtp)                
            </td>
            <td>
                Used by <a href="../developer/core/messaging/index.md">MixERP.Net.Messaging</a> module for sending
                or receiving messages.
            </td>
        </tr>
        <tr>
            <td>
                <a href="configs/mixerp.md">MixERP</a>
            </td>
            <td>
                Database Table (config.mixerp)                
            </td>
            <td>
                MixERP core configuration file
            </td>
        </tr>
        <tr>
            <td>
                ScrudFactory
            </td>
            <td>
                Database Table (config.scrud_factory)                
            </td>
            <td>
                Used by ScrudFactory HTML Helper (MVC) or ScrudFactory Module (WebForms)
            </td>
        </tr>
        <tr>
            <td>
                Switches
            </td>
            <td>
                Database Table (config.switches)                
            </td>
            <td>
                Used by several MixERP modules, contains parameters that can be switched on (true) or off(false)
            </td>
        </tr>
    </tbody>
</table>


##Related Topics
* [MixERP Documentation](../index.md)