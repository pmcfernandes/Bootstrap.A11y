# Tie.Controls.Bootstrap
Boostrap controls for Webforms

[![Codacy Badge](https://api.codacy.com/project/badge/grade/d23777adcd734105bc20b3a4ba1cf258)](https://www.codacy.com/app/pmcfernandes/Tie-Controls-Bootstrap)

## How-to Install

Just open your Visual Studio and in Tools > Nuget > Package Manager Console write follow line

    Install-Package Tie.Controls.Bootstrap
    
See more informations here: https://www.nuget.org/packages/Tie.Controls.Bootstrap/    

## Some Examples of Usage

##### Page Header

    <twt:PageHeader ID="PageHeader1" runat="server" Title="Heading" />

##### Labels

    <twt:Label ID="Label1" runat="server" Text="Label Message" LabelType="Default"></twt:Label>
    <twt:Label ID="Label2" runat="server" Text="Label Message" LabelType="Primary"></twt:Label>
    <twt:Label ID="Label3" runat="server" Text="Label Message" LabelType="Success"></twt:Label>
    <twt:Label ID="Label4" runat="server" Text="Label Message" LabelType="Info"></twt:Label>
    <twt:Label ID="Label5" runat="server" Text="Label Message" LabelType="Warning"></twt:Label>
    <twt:Label ID="Label6" runat="server" Text="Label Message" LabelType="Danger"></twt:Label>
    
##### Badges

    <twt:Badge ID="Badge1" runat="server" Text="42"></twt:Badge>
    
##### Button Groups

    <twt:ButtonGroup ID="ButtonGroup1" runat="server">
        <Buttons>
            <twt:Button ID="Button2" runat="server" Text="Left"></twt:Button>
            <twt:Button ID="Button3" runat="server" Text="Center"></twt:Button>
            <twt:Button ID="Button4" runat="server" Text="Right" ButtonType="Inverse"></twt:Button>
        </Buttons>
    </twt:ButtonGroup>
    
##### Toolbars

    <twt:ButtonGroup ID="ButtonGroup6" runat="server" Toolbar="true">
        <Buttons>
             <twt:ButtonGroup ID="ButtonGroup7" runat="server">
                <Buttons>
                    <twt:Button ID="Button17" runat="server" Text="1"></twt:Button>
                    <twt:Button ID="Button18" runat="server" Text="2"></twt:Button>
                    <twt:Button ID="Button19" runat="server" Text="3"></twt:Button>
                    <twt:Button ID="Button20" runat="server" Text="4"></twt:Button>
                </Buttons>
            </twt:ButtonGroup>
             <twt:ButtonGroup ID="ButtonGroup8" runat="server">
                <Buttons>
                    <twt:Button ID="Button21" runat="server" Text="5"></twt:Button>
                    <twt:Button ID="Button22" runat="server" Text="6"></twt:Button>
                    <twt:Button ID="Button23" runat="server" Text="7"></twt:Button>
                </Buttons>
            </twt:ButtonGroup>
             <twt:ButtonGroup ID="ButtonGroup9" runat="server">
                <Buttons>
                    <twt:Button ID="Button24" runat="server" Text="8"></twt:Button>
                </Buttons>
            </twt:ButtonGroup>
        </Buttons>
    </twt:ButtonGroup>
    
##### Paginations

    <twt:Paginator ID="Pagination1" runat="server"></twt:Paginator>
    
##### ProgressBars

    <twt:ProgressBar ID="ProgressBar3" runat="server" Value="40" ProgressBarStyle="Success" />
    <twt:ProgressBar ID="ProgressBar4" runat="server" Value="20" ProgressBarStyle="Info" />
    <twt:ProgressBar ID="ProgressBar5" runat="server" Value="60" ProgressBarStyle="Warning" />
    <twt:ProgressBar ID="ProgressBar6" runat="server" Value="80" ProgressBarStyle="Danger" />
    
##### Alerts

    <twt:Alert ID="Alert1" runat="server" Dismissible="false" AlertType="Success">
        <Content>
            <p>Well done! You successfully read this important alert message.</p>
        </Content>
    </twt:Alert>
