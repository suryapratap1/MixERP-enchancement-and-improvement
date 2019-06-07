
#Updater.config

MixERP can update itself when a new release is available. The update feature will
download, install, and patch your ERP instance to the latest version without needing you to sit next 
to the operating system and do the update all by yourself. Be assured that you are notified 
whenever there is a new update available. MixERP will update to the latest version 
only when you click the button to do so.


```xml
﻿<?xml version="1.0" encoding="utf-8" ?>

<!--
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.


MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
-->

<configuration>
  <appSettings>
    <add key="AutoSuggestUpdate" value="true" />
    <add key="ApiUrl" value="https://api.github.com/repos/mixerp/mixerp/releases" />
    <add key="MediaType" value="application/json" />
    <add key="UserAgent" value="MixERP"/>
    <add key="DownloadDirectory" value="/downloads" />
    <add key="IdKey" value="id" />
    <add key="NameKey" value="name" />
    <add key="TagNameKey" value="tag_name" />
    <add key="BodyKey" value="body" />
    <add key="DraftKey" value="draft" />
    <add key="CreatedAtKey" value="created_at" />
    <add key="PublishedAtKey" value="published_at" />
    <add key="AssetsKey" value="assets" />
    <add key="AssetIdSubKey" value="id" />
    <add key="AssetNameSubKey" value="name" />
    <add key="AssetContentTypeSubKey" value="content_type" />
    <add key="AssetStateSubKey" value="state" />
    <add key="AssetSizeSubKey" value="size" />
    <add key="AssetCreatedAtSubKey" value="created_at" />
    <add key="AssetUpdatedAtSubKey" value="updated_at" />
    <add key="AssetDownloadUrlSubKey" value="browser_download_url" />
    <add key="UpdateKeyword" value="update"/>
    <add key="TempPath" value="C:\mixerp\temp\downloads"/>
    <add key="Migrate" value="Resource/Configs/DbServer.config,Resource/Configs/Parameters.config"/>
    <!--Important the Migrate files should never begin with slashes-->
    <add key="PatchFileLocation" value="db/release-1/update-1/mixerp-patch-for-rc.sql" />
  </appSettings>
</configuration>
```


Do not change change anything except the **TempPath** unless you are absolutely sure what you
are doing.



##Related Topics
* [Administrator Documentation](../admin.md)