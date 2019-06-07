<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AttachmentManager.ascx.cs" Inherits="MixERP.Net.Core.Modules.BackOffice.AttachmentManager" %>
<style>
    @media screen and (min-width: 768px) {
        .modal-wide .modal-dialog {
            width: 700px;
        }
    }
</style>
<div data-ng-controller="AttachmentController">
    <div class="ui massive teal header">
        <asp:Literal ID="TitleLiteral" runat="server" />
    </div>

    <asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>

    <div class="ui massive teal header">
        <asp:Literal ID="SubTitleLiteral" runat="server" />
    </div>

    <div id="images" data-ng-cloak="">
        <div class="ui five doubling stackable cards">
            <div class="card" data-ng-repeat="attachment in attachments" id="card{{attachment.AttachmentId}}">
                <div class="image">
                    <img data-ng-src="{{attachment.ImagePath}}" />
                </div>
                <div class="content">
                    <a class="header">{{attachment.OriginalFileName}}</a>
                    <div class="meta">
                        <span class="date">{{attachment.AddedOn}}</span>
                    </div>
                    <div class="description">
                        {{attachment.Comment}}
                
                    </div>
                </div>
                <div class="extra content">
                    <div class="ui three buttons">
                        <a class="ui positive button" data-toggle="modal" data-target="#opener"
                            data-ng-click="initializeModal(attachment);">{{getResource('Resources.Titles.View')}}
                        </a>
                        <a class="ui blue button" target="_blank" href="{{attachment.RawUrl}}">{{getResource('Resources.Titles.Download')}}
                        </a>
                        <a class="ui negative button" data-ng-click="removeAttachment(attachment);">{{getResource('Resources.Titles.Delete')}}
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <!-- Modal -->
    <div class="ui large modal" id="opener">
        <i class="close icon"></i>
        <div class="ui teal header">
        </div>
        <div class="content">
            <div class="ui segment">
                <img src="/" alt="" />
                <p class="vpad8"></p>
            </div>

            <div class="actions">
                <div class="ui teal ok button">
                    <asp:Literal ID="OKLiteral" runat="server" />
                </div>
            </div>
        </div>
    </div>
</div>

<script src="Scripts/AttachmentManager.ascx.js"></script>
