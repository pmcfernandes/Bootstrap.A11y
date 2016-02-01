<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="getting-started.aspx.cs" Inherits="Samples.getting_started" MaintainScrollPositionOnPostback="true" %>
<%@ Register Assembly="Tie.Controls.Bootstrap" Namespace="Tie.Controls.Bootstrap" TagPrefix="twt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $('[data-toggle="popover"]').popover()
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <twt:Row ID="Row1" runat="server">
        <Columns>
            <twt:Column ID="Column1" runat="server">
                <Content>
                    <twt:PageHeader ID="PageHeader21" runat="server" Title="Bootrap Samples" SubText="for Webforms" />
                </Content>
            </twt:Column>
        </Columns>
    </twt:Row>
  
    <twt:Jumbotron ID="Jumbotron1" runat="server" FullWidth="true">
        <Header>
            <h1>Hello, world!</h1>
        </Header>
        <Content>
            <p>This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
            <p>
                <twt:Button ID="Button1" runat="server" ButtonType="Primary" ButtonSize="Large" Text="Learn more"></twt:Button>
            </p>
        </Content>
    </twt:Jumbotron>

    <twt:PageHeader ID="PageHeader5" runat="server" Title="Heading" />
    <twt:FieldSet ID="FieldSet4" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Heading ID="Heading1" runat="server" H="1" Text="Heading 1"></twt:Heading>
            <twt:Heading ID="Heading2" runat="server" H="2" Text="Heading 2"></twt:Heading>
            <twt:Heading ID="Heading3" runat="server" H="3" Text="Heading 3"></twt:Heading>
            <twt:Heading ID="Heading4" runat="server" H="4" Text="Heading 4"></twt:Heading>
            <twt:Heading ID="Heading5" runat="server" H="5" Text="Heading 5"></twt:Heading>
            <twt:Heading ID="Heading6" runat="server" H="6" Text="Heading 6"></twt:Heading>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader1" runat="server" Title="Labels" />
    <h2>Example</h2>
    <h2>Available variations</h2>
    <p>Add any of the below mentioned modifier classes to change the appearance of a label.</p>
    <twt:Label ID="Label1" runat="server" Text="Label Message" LabelType="Default"></twt:Label>
    <twt:Label ID="Label2" runat="server" Text="Label Message" LabelType="Primary"></twt:Label>
    <twt:Label ID="Label3" runat="server" Text="Label Message" LabelType="Success"></twt:Label>
    <twt:Label ID="Label4" runat="server" Text="Label Message" LabelType="Info"></twt:Label>
    <twt:Label ID="Label5" runat="server" Text="Label Message" LabelType="Warning"></twt:Label>
    <twt:Label ID="Label6" runat="server" Text="Label Message" LabelType="Danger"></twt:Label>

    <twt:PageHeader ID="PageHeader2" runat="server" Title="Badges" />
    <h4>Easily highlight new or unread items by adding a span class="badge" to links, Bootstrap navs, and more.</h4>
    <a href="#">Inbox
        <twt:Badge ID="Badge1" runat="server" Text="42"></twt:Badge></a>

    <twt:PageHeader ID="PageHeader10" runat="server" Title="Dropdowns" />
    <h3>Example</h3>
    <p>Wrap the dropdown's trigger and the dropdown menu within .dropdown, or another element that declares position: relative;. Then add the menu's HTML.</p>
    <twt:FieldSet ID="FieldSet17" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Dropdown ID="Dropdown" runat="server" Text="Dropdown">
                <Items>
                    <twt:ListHeader Text="Dropdown Header"></twt:ListHeader>
                    <twt:ListItem Text="Action" NavigateUrl="http://google.com"></twt:ListItem>
                    <twt:ListItem Text="Another Action"></twt:ListItem>
                    <twt:ListSeparator></twt:ListSeparator>
                    <twt:ListItem Text="Something else here" Enabled="false"></twt:ListItem>
                    <twt:ListItem Text="Separated link"></twt:ListItem>
                </Items>
            </twt:Dropdown>
        </Content>
    </twt:FieldSet>

    <p>Dropdown menus can be changed to expand upwards (instead of downwards) by adding .dropup to the parent.</p>
    <twt:FieldSet ID="FieldSet21" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Dropdown ID="Dropdown1" runat="server" Text="Dropdown" DropUp="true">
                <Items>
                    <twt:ListHeader Text="Dropdown Header"></twt:ListHeader>
                    <twt:ListItem Text="Action" NavigateUrl="http://google.com"></twt:ListItem>
                    <twt:ListItem Text="Another Action"></twt:ListItem>
                    <twt:ListSeparator></twt:ListSeparator>
                    <twt:ListItem Text="Something else here" Enabled="false"></twt:ListItem>
                    <twt:ListItem Text="Separated link"></twt:ListItem>
                </Items>
            </twt:Dropdown>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader3" runat="server" Title="Button groups" />
    <h4>Group a series of buttons together on a single line with the button group. Add on optional JavaScript radio and checkbox style behavior with our buttons plugin.</h4>
    <h3>Basic example</h3>
    <p>Wrap a series of buttons with .btn in .btn-group.</p>
    <twt:FieldSet ID="FieldSet1" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:ButtonGroup ID="ButtonGroup1" runat="server">
                <Buttons>
                    <twt:Button ID="Button2" runat="server" Text="Left"></twt:Button>
                    <twt:Button ID="Button3" runat="server" Text="Center"></twt:Button>
                    <twt:Button ID="Button4" runat="server" Text="Right" ButtonType="Inverse"></twt:Button>
                </Buttons>
            </twt:ButtonGroup>
        </Content>
    </twt:FieldSet>

    <h3>Button toolbar</h3>
    <p>Combine sets of div class="btn-group" into a div class="btn-toolbar" for more complex components.</p>
    <twt:FieldSet ID="FieldSet14" runat="server" Legend="Example" CssClass="test">
        <Content>
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
        </Content>
    </twt:FieldSet>

    <h3>Sizing</h3>
    <p>Instead of applying button sizing classes to every button in a group, just add .btn-group-* to each .btn-group, including when nesting multiple groups.</p>
    <twt:FieldSet ID="FieldSet13" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:ButtonGroup ID="ButtonGroup2" runat="server" ButtonSize="Large">
                <Buttons>
                    <twt:Button ID="Button5" runat="server" Text="Left"></twt:Button>
                    <twt:Button ID="Button6" runat="server" Text="Center"></twt:Button>
                    <twt:Button ID="Button7" runat="server" Text="Right"></twt:Button>
                </Buttons>
            </twt:ButtonGroup>
            <br />
            <br />
            <twt:ButtonGroup ID="ButtonGroup3" runat="server" ButtonSize="Default">
                <Buttons>
                    <twt:Button ID="Button8" runat="server" Text="Left"></twt:Button>
                    <twt:Button ID="Button9" runat="server" Text="Center"></twt:Button>
                    <twt:Button ID="Button10" runat="server" Text="Right"></twt:Button>
                </Buttons>
            </twt:ButtonGroup>
            <br />
            <br />
            <twt:ButtonGroup ID="ButtonGroup4" runat="server" ButtonSize="Small">
                <Buttons>
                    <twt:Button ID="Button11" runat="server" Text="Left"></twt:Button>
                    <twt:Button ID="Button12" runat="server" Text="Center"></twt:Button>
                    <twt:Button ID="Button13" runat="server" Text="Right"></twt:Button>
                </Buttons>
            </twt:ButtonGroup>
            <br />
            <br />
            <twt:ButtonGroup ID="ButtonGroup5" runat="server" ButtonSize="Mini">
                <Buttons>
                    <twt:Button ID="Button14" runat="server" Text="Left"></twt:Button>
                    <twt:Button ID="Button15" runat="server" Text="Center"></twt:Button>
                    <twt:Button ID="Button16" runat="server" Text="Right"></twt:Button>
                </Buttons>
            </twt:ButtonGroup>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader20" runat="server" Title="Forms" />
    <h3>Basic example</h3>
    <p>Individual form controls automatically receive some global styling. All textual input, textarea, select elements with .form-control are set to width: 100%; by default. Wrap labels and controls in .form-group for optimum spacing.</p>

    <twt:FieldSet ID="FieldSet37" runat="server" Legend="Example" CssClass="test">
        <Content>
            <asp:TextBox ID="TextBox8" runat="server" CssClass="demo"></asp:TextBox>
            <br />
            <asp:DropDownList ID="DropDownList" runat="server"></asp:DropDownList>
            <br />
            <asp:TextBox ID="TextBox9" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
            <br />
            <asp:Button ID="Button117" runat="server" Text="Transfer cash" />
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader19" runat="server" Title="Input Groups" />
    <h3>Basic example</h3>
    <p>Place one add-on or button on either side of an input. You may also place one on both sides of an input.</p>
    <twt:FieldSet ID="FieldSet35" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:InputGroup ID="InputGroup1" runat="server" Prefix="@">
                <Input>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </Input>
            </twt:InputGroup>
            <br />
            <twt:InputGroup ID="InputGroup2" runat="server" Suffix="@example.com">
                <Input>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </Input>
            </twt:InputGroup>
            <br />
            <twt:InputGroup ID="InputGroup3" runat="server" Prefix="$" Suffix=".00">
                <Input>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </Input>
            </twt:InputGroup>
            <br />
            <label for="<%= InputGroup4.ClientID %>">Your vanity URL</label>
            <twt:InputGroup ID="InputGroup4" runat="server" Prefix="https://example.com/users/">
                <Input>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </Input>
            </twt:InputGroup>
        </Content>
    </twt:FieldSet>

    <h3>Sizing</h3>
    <p>Add the relative form sizing classes to the .input-group itself and contents within will automatically resize—no need for repeating the form control size classes on each element.</p>
    <twt:FieldSet ID="FieldSet36" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:InputGroup ID="InputGroup5" runat="server" Prefix="@" Size="Large">
                <Input>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </Input>
            </twt:InputGroup>
            <br />
            <twt:InputGroup ID="InputGroup6" runat="server" Prefix="@">
                <Input>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </Input>
            </twt:InputGroup>
            <br />
            <twt:InputGroup ID="InputGroup7" runat="server" Prefix="@" Size="Small">
                <Input>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </Input>
            </twt:InputGroup>
        </Content>
    </twt:FieldSet>


    <twt:PageHeader ID="PageHeader18" runat="server" Title="Breadcrumbs" />
    <h3>Indicate the current page's location within a navigational hierarchy.</h3>
    <p>Separators are automatically added in CSS through :before and content.</p>
    <twt:FieldSet ID="FieldSet34" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Breadcrumbs ID="Breadcrumbs" runat="server">
                <Items>
                    <twt:BreadcrumbsItem Text="Home" NavigateUrl="#"></twt:BreadcrumbsItem>
                </Items>
            </twt:Breadcrumbs>
            <twt:Breadcrumbs ID="Breadcrumbs1" runat="server">
                <Items>
                    <twt:BreadcrumbsItem Text="Home" NavigateUrl="#"></twt:BreadcrumbsItem>
                    <twt:BreadcrumbsItem Text="Library" NavigateUrl="#"></twt:BreadcrumbsItem>
                </Items>
            </twt:Breadcrumbs>
            <twt:Breadcrumbs ID="Breadcrumbs2" runat="server">
                <Items>
                    <twt:BreadcrumbsItem Text="Home" NavigateUrl="#"></twt:BreadcrumbsItem>
                    <twt:BreadcrumbsItem Text="Library" NavigateUrl="#"></twt:BreadcrumbsItem>
                    <twt:BreadcrumbsItem Text="Data" NavigateUrl="#"></twt:BreadcrumbsItem>
                </Items>
            </twt:Breadcrumbs>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader4" runat="server" Title="Pagination" />
    <h4>Provide pagination links for your site or app with the multi-page pagination component, or the simpler pager alternative.</h4>
    <h3>Default pagination</h3>
    <p>Simple pagination inspired by Rdio, great for apps and search results. The large block is hard to miss, easily scalable, and provides large click areas.</p>
    <twt:FieldSet ID="FieldSet2" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Paginator ID="Pagination1" runat="server"></twt:Paginator>
        </Content>
    </twt:FieldSet>

    <h3>Sizing</h3>
    <p>Fancy larger or smaller pagination? Add .pagination-lg or .pagination-sm for additional sizes.</p>
    <twt:FieldSet ID="FieldSet3" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Paginator ID="Paginator2" runat="server" Size="Large" OnPageIndexChanged="Paginator2_PageIndexChanged"></twt:Paginator>
            <asp:Label ID="lblPaginator" runat="server"></asp:Label>
            <br />
            <twt:Paginator ID="Paginator3" runat="server" Size="Default"></twt:Paginator>
            <br />
            <twt:Paginator ID="Paginator4" runat="server" Size="Small"></twt:Paginator>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader6" runat="server" Title="Media object" />
    <h4>Abstract object styles for building various types of components (like blog comments, Tweets, etc) that feature a left- or right-aligned image alongside textual content.</h4>

    <h3>Default media</h3>
    <p>The default media displays a media object (images, video, audio) to the left or right of a content block.</p>
    <twt:FieldSet ID="FieldSet5" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:MediaObject ID="MediaObject1" runat="server" Title="Media heading" ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIHZpZXdCb3g9IjAgMCA2NCA2NCIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+PCEtLQpTb3VyY2UgVVJMOiBob2xkZXIuanMvNjR4NjQKQ3JlYXRlZCB3aXRoIEhvbGRlci5qcyAyLjYuMC4KTGVhcm4gbW9yZSBhdCBodHRwOi8vaG9sZGVyanMuY29tCihjKSAyMDEyLTIwMTUgSXZhbiBNYWxvcGluc2t5IC0gaHR0cDovL2ltc2t5LmNvCi0tPjxkZWZzPjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+PCFbQ0RBVEFbI2hvbGRlcl8xNTExYzEyNmJiZCB0ZXh0IHsgZmlsbDojQUFBQUFBO2ZvbnQtd2VpZ2h0OmJvbGQ7Zm9udC1mYW1pbHk6QXJpYWwsIEhlbHZldGljYSwgT3BlbiBTYW5zLCBzYW5zLXNlcmlmLCBtb25vc3BhY2U7Zm9udC1zaXplOjEwcHQgfSBdXT48L3N0eWxlPjwvZGVmcz48ZyBpZD0iaG9sZGVyXzE1MTFjMTI2YmJkIj48cmVjdCB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIGZpbGw9IiNFRUVFRUUiLz48Zz48dGV4dCB4PSIxNC41IiB5PSIzNi41Ij42NHg2NDwvdGV4dD48L2c+PC9nPjwvc3ZnPg==">
                <Content>
                    <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p>
                </Content>
            </twt:MediaObject>
            <twt:MediaObject ID="MediaObject2" runat="server" Title="Media heading" ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIHZpZXdCb3g9IjAgMCA2NCA2NCIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+PCEtLQpTb3VyY2UgVVJMOiBob2xkZXIuanMvNjR4NjQKQ3JlYXRlZCB3aXRoIEhvbGRlci5qcyAyLjYuMC4KTGVhcm4gbW9yZSBhdCBodHRwOi8vaG9sZGVyanMuY29tCihjKSAyMDEyLTIwMTUgSXZhbiBNYWxvcGluc2t5IC0gaHR0cDovL2ltc2t5LmNvCi0tPjxkZWZzPjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+PCFbQ0RBVEFbI2hvbGRlcl8xNTExYzEyNmJiZCB0ZXh0IHsgZmlsbDojQUFBQUFBO2ZvbnQtd2VpZ2h0OmJvbGQ7Zm9udC1mYW1pbHk6QXJpYWwsIEhlbHZldGljYSwgT3BlbiBTYW5zLCBzYW5zLXNlcmlmLCBtb25vc3BhY2U7Zm9udC1zaXplOjEwcHQgfSBdXT48L3N0eWxlPjwvZGVmcz48ZyBpZD0iaG9sZGVyXzE1MTFjMTI2YmJkIj48cmVjdCB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIGZpbGw9IiNFRUVFRUUiLz48Zz48dGV4dCB4PSIxNC41IiB5PSIzNi41Ij42NHg2NDwvdGV4dD48L2c+PC9nPjwvc3ZnPg==">
                <Content>
                    <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p>
                </Content>
            </twt:MediaObject>
            <twt:MediaObject ID="MediaObject3" runat="server" Title="Media heading" ImageAlign="Right" ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIHZpZXdCb3g9IjAgMCA2NCA2NCIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+PCEtLQpTb3VyY2UgVVJMOiBob2xkZXIuanMvNjR4NjQKQ3JlYXRlZCB3aXRoIEhvbGRlci5qcyAyLjYuMC4KTGVhcm4gbW9yZSBhdCBodHRwOi8vaG9sZGVyanMuY29tCihjKSAyMDEyLTIwMTUgSXZhbiBNYWxvcGluc2t5IC0gaHR0cDovL2ltc2t5LmNvCi0tPjxkZWZzPjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+PCFbQ0RBVEFbI2hvbGRlcl8xNTExYzEyNmJiZCB0ZXh0IHsgZmlsbDojQUFBQUFBO2ZvbnQtd2VpZ2h0OmJvbGQ7Zm9udC1mYW1pbHk6QXJpYWwsIEhlbHZldGljYSwgT3BlbiBTYW5zLCBzYW5zLXNlcmlmLCBtb25vc3BhY2U7Zm9udC1zaXplOjEwcHQgfSBdXT48L3N0eWxlPjwvZGVmcz48ZyBpZD0iaG9sZGVyXzE1MTFjMTI2YmJkIj48cmVjdCB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIGZpbGw9IiNFRUVFRUUiLz48Zz48dGV4dCB4PSIxNC41IiB5PSIzNi41Ij42NHg2NDwvdGV4dD48L2c+PC9nPjwvc3ZnPg==">
                <Content>
                    <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p>
                </Content>
            </twt:MediaObject>
        </Content>
    </twt:FieldSet>

    <h3>Media list</h3>
    <p>With a bit of extra markup, you can use media inside list (useful for comment threads or articles lists).</p>

    <twt:FieldSet ID="FieldSet6" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:MediaList ID="MediaList1" runat="server">
                <Content>
                    <twt:MediaObject ID="MediaObject4" runat="server" Title="Media heading" ImageAlign="Left" ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIHZpZXdCb3g9IjAgMCA2NCA2NCIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+PCEtLQpTb3VyY2UgVVJMOiBob2xkZXIuanMvNjR4NjQKQ3JlYXRlZCB3aXRoIEhvbGRlci5qcyAyLjYuMC4KTGVhcm4gbW9yZSBhdCBodHRwOi8vaG9sZGVyanMuY29tCihjKSAyMDEyLTIwMTUgSXZhbiBNYWxvcGluc2t5IC0gaHR0cDovL2ltc2t5LmNvCi0tPjxkZWZzPjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+PCFbQ0RBVEFbI2hvbGRlcl8xNTExYzEyNmJiZCB0ZXh0IHsgZmlsbDojQUFBQUFBO2ZvbnQtd2VpZ2h0OmJvbGQ7Zm9udC1mYW1pbHk6QXJpYWwsIEhlbHZldGljYSwgT3BlbiBTYW5zLCBzYW5zLXNlcmlmLCBtb25vc3BhY2U7Zm9udC1zaXplOjEwcHQgfSBdXT48L3N0eWxlPjwvZGVmcz48ZyBpZD0iaG9sZGVyXzE1MTFjMTI2YmJkIj48cmVjdCB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIGZpbGw9IiNFRUVFRUUiLz48Zz48dGV4dCB4PSIxNC41IiB5PSIzNi41Ij42NHg2NDwvdGV4dD48L2c+PC9nPjwvc3ZnPg==">
                        <Content>
                            <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p>
                        </Content>
                    </twt:MediaObject>
                    <twt:MediaObject ID="MediaObject5" runat="server" Title="Media heading" ImageAlign="Left" ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIHZpZXdCb3g9IjAgMCA2NCA2NCIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+PCEtLQpTb3VyY2UgVVJMOiBob2xkZXIuanMvNjR4NjQKQ3JlYXRlZCB3aXRoIEhvbGRlci5qcyAyLjYuMC4KTGVhcm4gbW9yZSBhdCBodHRwOi8vaG9sZGVyanMuY29tCihjKSAyMDEyLTIwMTUgSXZhbiBNYWxvcGluc2t5IC0gaHR0cDovL2ltc2t5LmNvCi0tPjxkZWZzPjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+PCFbQ0RBVEFbI2hvbGRlcl8xNTExYzEyNmJiZCB0ZXh0IHsgZmlsbDojQUFBQUFBO2ZvbnQtd2VpZ2h0OmJvbGQ7Zm9udC1mYW1pbHk6QXJpYWwsIEhlbHZldGljYSwgT3BlbiBTYW5zLCBzYW5zLXNlcmlmLCBtb25vc3BhY2U7Zm9udC1zaXplOjEwcHQgfSBdXT48L3N0eWxlPjwvZGVmcz48ZyBpZD0iaG9sZGVyXzE1MTFjMTI2YmJkIj48cmVjdCB3aWR0aD0iNjQiIGhlaWdodD0iNjQiIGZpbGw9IiNFRUVFRUUiLz48Zz48dGV4dCB4PSIxNC41IiB5PSIzNi41Ij42NHg2NDwvdGV4dD48L2c+PC9nPjwvc3ZnPg==">
                        <Content>
                            <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p>
                        </Content>
                    </twt:MediaObject>
                </Content>
            </twt:MediaList>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader7" runat="server" Title="Images" />
    <h3>Image Shapes </h3>
    <p>Add classes to an img element to easily style images in any project.</p>

    <twt:FieldSet ID="FieldSet7" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Image ID="Image1" runat="server" ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMTQwIiBoZWlnaHQ9IjE0MCIgdmlld0JveD0iMCAwIDE0MCAxNDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzE0MHgxNDAKQ3JlYXRlZCB3aXRoIEhvbGRlci5qcyAyLjYuMC4KTGVhcm4gbW9yZSBhdCBodHRwOi8vaG9sZGVyanMuY29tCihjKSAyMDEyLTIwMTUgSXZhbiBNYWxvcGluc2t5IC0gaHR0cDovL2ltc2t5LmNvCi0tPjxkZWZzPjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+PCFbQ0RBVEFbI2hvbGRlcl8xNTExYzNlOWZhZiB0ZXh0IHsgZmlsbDojQUFBQUFBO2ZvbnQtd2VpZ2h0OmJvbGQ7Zm9udC1mYW1pbHk6QXJpYWwsIEhlbHZldGljYSwgT3BlbiBTYW5zLCBzYW5zLXNlcmlmLCBtb25vc3BhY2U7Zm9udC1zaXplOjEwcHQgfSBdXT48L3N0eWxlPjwvZGVmcz48ZyBpZD0iaG9sZGVyXzE1MTFjM2U5ZmFmIj48cmVjdCB3aWR0aD0iMTQwIiBoZWlnaHQ9IjE0MCIgZmlsbD0iI0VFRUVFRSIvPjxnPjx0ZXh0IHg9IjQ1LjUiIHk9Ijc0LjUiPjE0MHgxNDA8L3RleHQ+PC9nPjwvZz48L3N2Zz4=" ImageType="None" />
            <twt:Image ID="Image2" runat="server" ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMTQwIiBoZWlnaHQ9IjE0MCIgdmlld0JveD0iMCAwIDE0MCAxNDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzE0MHgxNDAKQ3JlYXRlZCB3aXRoIEhvbGRlci5qcyAyLjYuMC4KTGVhcm4gbW9yZSBhdCBodHRwOi8vaG9sZGVyanMuY29tCihjKSAyMDEyLTIwMTUgSXZhbiBNYWxvcGluc2t5IC0gaHR0cDovL2ltc2t5LmNvCi0tPjxkZWZzPjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+PCFbQ0RBVEFbI2hvbGRlcl8xNTExYzNlOWZhZiB0ZXh0IHsgZmlsbDojQUFBQUFBO2ZvbnQtd2VpZ2h0OmJvbGQ7Zm9udC1mYW1pbHk6QXJpYWwsIEhlbHZldGljYSwgT3BlbiBTYW5zLCBzYW5zLXNlcmlmLCBtb25vc3BhY2U7Zm9udC1zaXplOjEwcHQgfSBdXT48L3N0eWxlPjwvZGVmcz48ZyBpZD0iaG9sZGVyXzE1MTFjM2U5ZmFmIj48cmVjdCB3aWR0aD0iMTQwIiBoZWlnaHQ9IjE0MCIgZmlsbD0iI0VFRUVFRSIvPjxnPjx0ZXh0IHg9IjQ1LjUiIHk9Ijc0LjUiPjE0MHgxNDA8L3RleHQ+PC9nPjwvZz48L3N2Zz4=" ImageType="Circle" />
            <twt:Image ID="Image3" runat="server" ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMTQwIiBoZWlnaHQ9IjE0MCIgdmlld0JveD0iMCAwIDE0MCAxNDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzE0MHgxNDAKQ3JlYXRlZCB3aXRoIEhvbGRlci5qcyAyLjYuMC4KTGVhcm4gbW9yZSBhdCBodHRwOi8vaG9sZGVyanMuY29tCihjKSAyMDEyLTIwMTUgSXZhbiBNYWxvcGluc2t5IC0gaHR0cDovL2ltc2t5LmNvCi0tPjxkZWZzPjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+PCFbQ0RBVEFbI2hvbGRlcl8xNTExYzNlOWZhZiB0ZXh0IHsgZmlsbDojQUFBQUFBO2ZvbnQtd2VpZ2h0OmJvbGQ7Zm9udC1mYW1pbHk6QXJpYWwsIEhlbHZldGljYSwgT3BlbiBTYW5zLCBzYW5zLXNlcmlmLCBtb25vc3BhY2U7Zm9udC1zaXplOjEwcHQgfSBdXT48L3N0eWxlPjwvZGVmcz48ZyBpZD0iaG9sZGVyXzE1MTFjM2U5ZmFmIj48cmVjdCB3aWR0aD0iMTQwIiBoZWlnaHQ9IjE0MCIgZmlsbD0iI0VFRUVFRSIvPjxnPjx0ZXh0IHg9IjQ1LjUiIHk9Ijc0LjUiPjE0MHgxNDA8L3RleHQ+PC9nPjwvZz48L3N2Zz4=" ImageType="Polaroid" />
            <twt:Image ID="Image4" runat="server" ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMTQwIiBoZWlnaHQ9IjE0MCIgdmlld0JveD0iMCAwIDE0MCAxNDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzE0MHgxNDAKQ3JlYXRlZCB3aXRoIEhvbGRlci5qcyAyLjYuMC4KTGVhcm4gbW9yZSBhdCBodHRwOi8vaG9sZGVyanMuY29tCihjKSAyMDEyLTIwMTUgSXZhbiBNYWxvcGluc2t5IC0gaHR0cDovL2ltc2t5LmNvCi0tPjxkZWZzPjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+PCFbQ0RBVEFbI2hvbGRlcl8xNTExYzNlOWZhZiB0ZXh0IHsgZmlsbDojQUFBQUFBO2ZvbnQtd2VpZ2h0OmJvbGQ7Zm9udC1mYW1pbHk6QXJpYWwsIEhlbHZldGljYSwgT3BlbiBTYW5zLCBzYW5zLXNlcmlmLCBtb25vc3BhY2U7Zm9udC1zaXplOjEwcHQgfSBdXT48L3N0eWxlPjwvZGVmcz48ZyBpZD0iaG9sZGVyXzE1MTFjM2U5ZmFmIj48cmVjdCB3aWR0aD0iMTQwIiBoZWlnaHQ9IjE0MCIgZmlsbD0iI0VFRUVFRSIvPjxnPjx0ZXh0IHg9IjQ1LjUiIHk9Ijc0LjUiPjE0MHgxNDA8L3RleHQ+PC9nPjwvZz48L3N2Zz4=" ImageType="Rounded" />
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader8" runat="server" Title="Progress bars" />
    <h3>Basic example</h3>
    <p>Default progress bar.</p>
    <twt:FieldSet ID="FieldSet8" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:ProgressBar ID="ProgressBar1" runat="server" Value="60" />
        </Content>
    </twt:FieldSet>

    <h3>With label</h3>
    <p>Remove the span with .sr-only class from within the progress bar to show a visible percentage.</p>
    <twt:FieldSet ID="FieldSet9" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:ProgressBar ID="ProgressBar2" runat="server" Value="60" ShowLabel="true" />
        </Content>
    </twt:FieldSet>

    <h3>Contextual alternatives</h3>
    <p>Progress bars use some of the same button and alert classes for consistent styles.</p>
    <twt:FieldSet ID="FieldSet10" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:ProgressBar ID="ProgressBar3" runat="server" Value="40" ProgressBarStyle="Success" />
            <twt:ProgressBar ID="ProgressBar4" runat="server" Value="20" ProgressBarStyle="Info" />
            <twt:ProgressBar ID="ProgressBar5" runat="server" Value="60" ProgressBarStyle="Warning" />
            <twt:ProgressBar ID="ProgressBar6" runat="server" Value="80" ProgressBarStyle="Danger" />
        </Content>
    </twt:FieldSet>

    <h3>Striped</h3>
    <p>Uses a gradient to create a striped effect. Not available in IE9 and below.</p>
    <twt:FieldSet ID="FieldSet11" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:ProgressBar ID="ProgressBar7" runat="server" Value="40" ProgressBarStyle="Success" Striped="true" />
            <twt:ProgressBar ID="ProgressBar8" runat="server" Value="20" ProgressBarStyle="Info" Striped="true" />
            <twt:ProgressBar ID="ProgressBar9" runat="server" Value="60" ProgressBarStyle="Warning" Striped="true" />
            <twt:ProgressBar ID="ProgressBar10" runat="server" Value="80" ProgressBarStyle="Danger" Striped="true" />
        </Content>
    </twt:FieldSet>

    <h3>Animated</h3>
    <p>Add .active to .progress-bar-striped to animate the stripes right to left. Not available in IE9 and below.</p>
    <twt:FieldSet ID="FieldSet12" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:ProgressBar ID="ProgressBar11" runat="server" Value="60" Striped="true" Animated="true" />
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader9" runat="server" Title="Alert" />
    <h3>Examples</h3>
    <p>Wrap any text and an optional dismiss button in .alert and one of the four contextual classes (e.g., .alert-success) for basic alert messages.</p>
    <twt:FieldSet ID="FieldSet15" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Alert ID="Alert1" runat="server" Dismissible="false" AlertType="Success">
                <Content>
                    <p>Well done! You successfully read this important alert message.</p>
                </Content>
            </twt:Alert>
            <twt:Alert ID="Alert2" runat="server" Dismissible="false" AlertType="Info">
                <Content>
                    <p><b>Well done!</b> You successfully read this important alert message.</p>
                </Content>
            </twt:Alert>
            <twt:Alert ID="Alert3" runat="server" Dismissible="false" AlertType="Warning">
                <Content>
                    <p>Well done! You successfully read this important alert message.</p>
                </Content>
            </twt:Alert>
            <twt:Alert ID="Alert4" runat="server" Dismissible="false" AlertType="Danger">
                <Content>
                    <p>Well done! You successfully read this important alert message.</p>
                </Content>
            </twt:Alert>
        </Content>
    </twt:FieldSet>

    <h3>Dismissible alerts</h3>
    <p>Build on any alert by adding an optional .alert-dismissible and close button.</p>
    <twt:FieldSet ID="FieldSet16" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Alert ID="Alert7" runat="server" Dismissible="true" AlertType="Danger">
                <Content>
                    <h4>Oh snap! You got an error!</h4>
                    <p>Well done! You successfully read this important alert message.</p>
                    <p>&nbsp;</p>
                    <p>
                        <twt:Button ID="Button40" runat="server" Text="Take this Action" ButtonType="Danger"></twt:Button>
                        <twt:Button ID="Button25" runat="server" Text="Or do this" ButtonType="Default"></twt:Button>
                    </p>
                </Content>
            </twt:Alert>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader11" runat="server" Title="Panels" />
    <h3>Basic example</h3>
    <p>By default, all the .panel does is apply some basic border and padding to contain some content.</p>
    <twt:FieldSet ID="FieldSet18" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Panel ID="Panel1" runat="server">
                <Content>
                    Basic panel example
                </Content>
            </twt:Panel>
        </Content>
    </twt:FieldSet>
    <h3>Panel with heading</h3>
    <p>Easily add a heading container to your panel with .panel-heading. You may also include any h1-h6 with a .panel-title class to add a pre-styled heading.</p>
    <p>For proper link coloring, be sure to place links in headings within .panel-title.</p>
    <twt:FieldSet ID="FieldSet19" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Panel ID="Panel2" runat="server" Title="Panel title">
                <Content>
                    Panel content
                </Content>
            </twt:Panel>
        </Content>
    </twt:FieldSet>

    <h3>Contextual alternatives</h3>
    <p>Like other components, easily make a panel more meaningful to a particular context by adding any of the contextual state classes.</p>
    <twt:FieldSet ID="FieldSet20" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Panel ID="Panel3" runat="server" Title="Panel title" PanelType="Primary">
                <Content>
                    Panel content
                </Content>
            </twt:Panel>
            <twt:Panel ID="Panel4" runat="server" Title="Panel title" PanelType="Success">
                <Content>
                    Panel content
                </Content>
            </twt:Panel>
            <twt:Panel ID="Panel5" runat="server" Title="Panel title" PanelType="Info">
                <Content>
                    Panel content
                </Content>
            </twt:Panel>
            <twt:Panel ID="Panel6" runat="server" Title="Panel title" PanelType="Warning">
                <Content>
                    Panel content
                </Content>
            </twt:Panel>
            <twt:Panel ID="Panel7" runat="server" Title="Panel title" PanelType="Danger">
                <Content>
                    Panel content
                </Content>
            </twt:Panel>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader12" runat="server" Title="Collapse" />
    <h3>Accordion example</h3>
    <p>Extend the default collapse behavior to create an accordion with the panel component.</p>
    <twt:FieldSet ID="FieldSet22" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:AccordionControl ID="AccordionControl" runat="server">
                <Panes>
                    <twt:AccordionPane>
                        <Header>Collapsible Group Item #1</Header>
                        <Content>Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.</Content>
                    </twt:AccordionPane>
                    <twt:AccordionPane Expanded="true">
                        <Header>Collapsible Group Item #2</Header>
                        <Content>Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.</Content>
                    </twt:AccordionPane>
                    <twt:AccordionPane>
                        <Header>Collapsible Group Item #3</Header>
                        <Content>Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.</Content>
                    </twt:AccordionPane>
                </Panes>
            </twt:AccordionControl>
        </Content>
    </twt:FieldSet>

    <p>It's also possible to swap out .panel-bodys with .list-groups.</p>
    <twt:FieldSet ID="FieldSet23" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:AccordionControl ID="AccordionControl1" runat="server" ListGroup="true">
                <Panes>
                    <twt:AccordionPane>
                        <Header>Collapsible Group Item #1</Header>
                        <Content>Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.</Content>
                    </twt:AccordionPane>
                    <twt:AccordionPane>
                        <Header>Collapsible Group Item #2</Header>
                        <Content>Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.</Content>
                    </twt:AccordionPane>
                    <twt:AccordionPane>
                        <Header>Collapsible Group Item #3</Header>
                        <Content>Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.</Content>
                    </twt:AccordionPane>
                </Panes>
            </twt:AccordionControl>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader13" runat="server" Title="Popovers" />
    <h3>Static popover</h3>
    <p>Four options are available: top, right, bottom, and left aligned.</p>
    <twt:FieldSet ID="FieldSet24" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Button ID="Button41" runat="server" Text="Click to toggle popover" UseSubmitBehavior="false">
                <Popover runat="server" Position="Top" Title="Dismissible popover" Text="And here's some amazing content. It's very engaging. Right?" />
            </twt:Button>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader14" runat="server" Title="Modal" />
    <h3>Static example</h3>
    <p>A rendered modal with header, body, and set of actions in the footer.</p>
    <twt:FieldSet ID="FieldSet25" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Button ID="Button26" runat="server" Text="Launch demo modal" ButtonSize="Large" ButtonType="Primary" ModalID="Modal1"></twt:Button>
            <twt:Modal ID="Modal1" runat="server" Title="Modal title">
                <Content>
                    <p>One fine body&hellip;</p>
                </Content>
                <Footer>
                    <twt:Button ID="Button28" runat="server" Text="Close" ButtonType="Default" UseSubmitBehavior="false"></twt:Button>
                    <twt:Button ID="Button27" runat="server" Text="Save changes" ButtonType="Primary"></twt:Button>
                </Footer>
            </twt:Modal>
        </Content>
    </twt:FieldSet>

    <h3>Optional sizes</h3>
    <p>Modals have two optional sizes, available via modifier classes to be placed on a .modal-dialog.</p>
    <twt:FieldSet ID="FieldSet26" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Button ID="Button29" runat="server" Text="Large modal" ButtonType="Primary" ModalID="Modal2"></twt:Button>
            <twt:Button ID="Button32" runat="server" Text="Small modal" ButtonType="Primary" ModalID="Modal3"></twt:Button>

            <twt:Modal ID="Modal2" runat="server" Title="Modal title" Size="Large">
                <Content>
                    <p>One second body&hellip;</p>
                </Content>
            </twt:Modal>
            <twt:Modal ID="Modal3" runat="server" Title="Modal title" Size="Small">
                <Content>
                    <p>One third body&hellip;</p>
                </Content>
            </twt:Modal>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader15" runat="server" Title="Tabs" />
    <p>Note the .nav-tabs class requires the .nav base class..</p>
    <twt:FieldSet ID="FieldSet27" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:TabControl ID="TabControl1" runat="server" ActiveTabPage="0" AutoPostBack="true" OnTabPageChanged="TabControl1_TabPageChanged">
                <TabPages>
                    <twt:TabPage Title="Home">
                        <Content>
                            <p>Selects the given tab and shows its associated content. Any other tab that was previously selected becomes unselected and its associated content is hidden. Returns to the caller before the tab pane has actually been shown (i.e. before the shown.bs.tab event occurs).</p>
                        </Content>
                    </twt:TabPage>
                    <twt:TabPage Title="Profile"></twt:TabPage>
                    <twt:TabPage Title="Messages"></twt:TabPage>
                </TabPages>
            </twt:TabControl>
        </Content>
    </twt:FieldSet>

    <h3>Pills</h3>
    <p>Take that same HTML, but use .nav-pills instead:</p>
    <twt:FieldSet ID="FieldSet28" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:TabControl ID="TabControl2" runat="server" ActiveTabPage="0" Pills="true">
                <TabPages>
                    <twt:TabPage Title="Home"></twt:TabPage>
                    <twt:TabPage Title="Profile"></twt:TabPage>
                    <twt:TabPage Title="Messages"></twt:TabPage>
                </TabPages>
            </twt:TabControl>
        </Content>
    </twt:FieldSet>

    <p>Pills are also vertically stackable. Just add .nav-stacked.</p>
    <twt:FieldSet ID="FieldSet29" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:TabControl ID="TabControl3" runat="server" ActiveTabPage="0" Pills="true" Stacked="true">
                <TabPages>
                    <twt:TabPage Title="Home"></twt:TabPage>
                    <twt:TabPage Title="Profile"></twt:TabPage>
                    <twt:TabPage Title="Messages"></twt:TabPage>
                </TabPages>
            </twt:TabControl>
        </Content>
    </twt:FieldSet>

    <h3>Justified</h3>
    <p>Easily make tabs or pills equal widths of their parent at screens wider than 768px with .nav-justified. On smaller screens, the nav links are stacked</p>
    <twt:FieldSet ID="FieldSet30" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:TabControl ID="TabControl4" runat="server" ActiveTabPage="0" Pills="false" Justified="true">
                <TabPages>
                    <twt:TabPage Title="Home"></twt:TabPage>
                    <twt:TabPage Title="Profile"></twt:TabPage>
                    <twt:TabPage Title="Messages"></twt:TabPage>
                </TabPages>
            </twt:TabControl>
            <twt:TabControl ID="TabControl5" runat="server" ActiveTabPage="0" Pills="true" Justified="true">
                <TabPages>
                    <twt:TabPage Title="Home"></twt:TabPage>
                    <twt:TabPage Title="Profile"></twt:TabPage>
                    <twt:TabPage Title="Messages"></twt:TabPage>
                </TabPages>
            </twt:TabControl>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader16" runat="server" Title="Carousel" />
    <h3>Example</h3>
    <twt:FieldSet ID="FieldSet31" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Carousel ID="Carousel1" runat="server">
                <Items>
                    <twt:CarouselItem ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iOTAwIiBoZWlnaHQ9IjUwMCIgdmlld0JveD0iMCAwIDkwMCA1MDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzkwMHg1MDAvYXV0by8jNzc3OiM1NTUvdGV4dDpGaXJzdCBzbGlkZQpDcmVhdGVkIHdpdGggSG9sZGVyLmpzIDIuNi4wLgpMZWFybiBtb3JlIGF0IGh0dHA6Ly9ob2xkZXJqcy5jb20KKGMpIDIwMTItMjAxNSBJdmFuIE1hbG9waW5za3kgLSBodHRwOi8vaW1za3kuY28KLS0+PGRlZnM+PHN0eWxlIHR5cGU9InRleHQvY3NzIj48IVtDREFUQVsjaG9sZGVyXzE1MTI1ZDAwOWFlIHRleHQgeyBmaWxsOiM1NTU7Zm9udC13ZWlnaHQ6Ym9sZDtmb250LWZhbWlseTpBcmlhbCwgSGVsdmV0aWNhLCBPcGVuIFNhbnMsIHNhbnMtc2VyaWYsIG1vbm9zcGFjZTtmb250LXNpemU6NDVwdCB9IF1dPjwvc3R5bGU+PC9kZWZzPjxnIGlkPSJob2xkZXJfMTUxMjVkMDA5YWUiPjxyZWN0IHdpZHRoPSI5MDAiIGhlaWdodD0iNTAwIiBmaWxsPSIjNzc3Ii8+PGc+PHRleHQgeD0iMzA4LjI5Njg3NSIgeT0iMjcwLjEiPkZpcnN0IHNsaWRlPC90ZXh0PjwvZz48L2c+PC9zdmc+" Title="First slide label" Text="Nulla vitae elit libero, a pharetra augue mollis interdum."></twt:CarouselItem>
                    <twt:CarouselItem ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iOTAwIiBoZWlnaHQ9IjUwMCIgdmlld0JveD0iMCAwIDkwMCA1MDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzkwMHg1MDAvYXV0by8jNzc3OiM1NTUvdGV4dDpGaXJzdCBzbGlkZQpDcmVhdGVkIHdpdGggSG9sZGVyLmpzIDIuNi4wLgpMZWFybiBtb3JlIGF0IGh0dHA6Ly9ob2xkZXJqcy5jb20KKGMpIDIwMTItMjAxNSBJdmFuIE1hbG9waW5za3kgLSBodHRwOi8vaW1za3kuY28KLS0+PGRlZnM+PHN0eWxlIHR5cGU9InRleHQvY3NzIj48IVtDREFUQVsjaG9sZGVyXzE1MTI1ZDAwOWFlIHRleHQgeyBmaWxsOiM1NTU7Zm9udC13ZWlnaHQ6Ym9sZDtmb250LWZhbWlseTpBcmlhbCwgSGVsdmV0aWNhLCBPcGVuIFNhbnMsIHNhbnMtc2VyaWYsIG1vbm9zcGFjZTtmb250LXNpemU6NDVwdCB9IF1dPjwvc3R5bGU+PC9kZWZzPjxnIGlkPSJob2xkZXJfMTUxMjVkMDA5YWUiPjxyZWN0IHdpZHRoPSI5MDAiIGhlaWdodD0iNTAwIiBmaWxsPSIjNzc3Ii8+PGc+PHRleHQgeD0iMzA4LjI5Njg3NSIgeT0iMjcwLjEiPkZpcnN0IHNsaWRlPC90ZXh0PjwvZz48L2c+PC9zdmc+" Title="Second slide label" Text="Nulla vitae elit libero, a pharetra augue mollis interdum."></twt:CarouselItem>
                    <twt:CarouselItem ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iOTAwIiBoZWlnaHQ9IjUwMCIgdmlld0JveD0iMCAwIDkwMCA1MDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzkwMHg1MDAvYXV0by8jNzc3OiM1NTUvdGV4dDpGaXJzdCBzbGlkZQpDcmVhdGVkIHdpdGggSG9sZGVyLmpzIDIuNi4wLgpMZWFybiBtb3JlIGF0IGh0dHA6Ly9ob2xkZXJqcy5jb20KKGMpIDIwMTItMjAxNSBJdmFuIE1hbG9waW5za3kgLSBodHRwOi8vaW1za3kuY28KLS0+PGRlZnM+PHN0eWxlIHR5cGU9InRleHQvY3NzIj48IVtDREFUQVsjaG9sZGVyXzE1MTI1ZDAwOWFlIHRleHQgeyBmaWxsOiM1NTU7Zm9udC13ZWlnaHQ6Ym9sZDtmb250LWZhbWlseTpBcmlhbCwgSGVsdmV0aWNhLCBPcGVuIFNhbnMsIHNhbnMtc2VyaWYsIG1vbm9zcGFjZTtmb250LXNpemU6NDVwdCB9IF1dPjwvc3R5bGU+PC9kZWZzPjxnIGlkPSJob2xkZXJfMTUxMjVkMDA5YWUiPjxyZWN0IHdpZHRoPSI5MDAiIGhlaWdodD0iNTAwIiBmaWxsPSIjNzc3Ii8+PGc+PHRleHQgeD0iMzA4LjI5Njg3NSIgeT0iMjcwLjEiPkZpcnN0IHNsaWRlPC90ZXh0PjwvZz48L2c+PC9zdmc+" Title="Third slide label" Text="Nulla vitae elit libero, a pharetra augue mollis interdum."></twt:CarouselItem>
                    <twt:CarouselItem ImageUrl="data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iOTAwIiBoZWlnaHQ9IjUwMCIgdmlld0JveD0iMCAwIDkwMCA1MDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzkwMHg1MDAvYXV0by8jNzc3OiM1NTUvdGV4dDpGaXJzdCBzbGlkZQpDcmVhdGVkIHdpdGggSG9sZGVyLmpzIDIuNi4wLgpMZWFybiBtb3JlIGF0IGh0dHA6Ly9ob2xkZXJqcy5jb20KKGMpIDIwMTItMjAxNSBJdmFuIE1hbG9waW5za3kgLSBodHRwOi8vaW1za3kuY28KLS0+PGRlZnM+PHN0eWxlIHR5cGU9InRleHQvY3NzIj48IVtDREFUQVsjaG9sZGVyXzE1MTI1ZDAwOWFlIHRleHQgeyBmaWxsOiM1NTU7Zm9udC13ZWlnaHQ6Ym9sZDtmb250LWZhbWlseTpBcmlhbCwgSGVsdmV0aWNhLCBPcGVuIFNhbnMsIHNhbnMtc2VyaWYsIG1vbm9zcGFjZTtmb250LXNpemU6NDVwdCB9IF1dPjwvc3R5bGU+PC9kZWZzPjxnIGlkPSJob2xkZXJfMTUxMjVkMDA5YWUiPjxyZWN0IHdpZHRoPSI5MDAiIGhlaWdodD0iNTAwIiBmaWxsPSIjNzc3Ii8+PGc+PHRleHQgeD0iMzA4LjI5Njg3NSIgeT0iMjcwLjEiPkZpcnN0IHNsaWRlPC90ZXh0PjwvZz48L2c+PC9zdmc+" Title="Fourth slide label" Text="Nulla vitae elit libero, a pharetra augue mollis interdum."></twt:CarouselItem>
                </Items>
            </twt:Carousel>
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader17" runat="server" Title="Wells" />
    <h3>Default well</h3>
    <p>Use the well as a simple effect on an element to give it an inset effect..</p>
    <twt:FieldSet ID="FieldSet32" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Well ID="Well1" runat="server" Text="Look, I'm in a well!" />
        </Content>
    </twt:FieldSet>

    <h3>Optional classes</h3>
    <p>Control padding and rounded corners with two optional modifier classes.</p>
    <twt:FieldSet ID="FieldSet33" runat="server" Legend="Example" CssClass="test">
        <Content>
            <twt:Well ID="Well2" runat="server" Text="Look, I'm in a large well!" Size="Large" />
            <twt:Well ID="Well3" runat="server" Text="Look, I'm in a small  well!" Size="Small" />
        </Content>
    </twt:FieldSet>

    <twt:PageHeader ID="PageHeader22" runat="server" Title="Tables" />
    <twt:GridView ID="GridView1" runat="server" Condensed="true" Responsive="true"></twt:GridView>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <twt:Affix ID="Affix1" runat="server" OffsetTop="20" OffsetBottom="20">
        <ul class="nav bs-docs-sidenav">
            <li>
                <a href="#js-overview">Overview</a>
                <ul class="nav">
                    <li><a href="#js-individual-compiled">Individual or compiled</a></li>
                    <li><a href="#js-data-attrs">Data attributes</a></li>
                    <li><a href="#js-programmatic-api">Programmatic API</a></li>
                    <li><a href="#js-noconflict">No conflict</a></li>
                    <li><a href="#js-events">Events</a></li>
                    <li><a href="#js-version-nums">Version numbers</a></li>
                    <li><a href="#js-disabled">When JavaScript is disabled</a></li>
                    <li><a href="#callout-third-party-libs">Third-party libraries</a></li>
                </ul>
            </li>
            <li><a href="#transitions">Transitions</a></li>
            <li>
                <a href="#modals">Modal</a>
                <ul class="nav">
                    <li><a href="#modals-examples">Examples</a></li>
                    <li><a href="#modals-sizes">Sizes</a></li>
                    <li><a href="#modals-remove-animation">Remove animation</a></li>
                    <li><a href="#modals-related-target">Varying content based on trigger button</a></li>
                    <li><a href="#modals-usage">Usage</a></li>
                    <li><a href="#modals-options">Options</a></li>
                    <li><a href="#modals-methods">Methods</a></li>
                    <li><a href="#modals-events">Events</a></li>
                </ul>
            </li>
            <li>
                <a href="#dropdowns">Dropdown</a>
                <ul class="nav">
                    <li><a href="#dropdowns-examples">Examples</a></li>
                    <li><a href="#dropdowns-usage">Usage</a></li>
                    <li><a href="#dropdowns-methods">Methods</a></li>
                    <li><a href="#dropdowns-events">Events</a></li>
                </ul>
            </li>
            <li>
                <a href="#scrollspy">Scrollspy</a>
                <ul class="nav">
                    <li><a href="#scrollspy-examples">Examples</a></li>
                    <li><a href="#scrollspy-usage">Usage</a></li>
                    <li><a href="#scrollspy-methods">Methods</a></li>
                    <li><a href="#scrollspy-options">Options</a></li>
                    <li><a href="#scrollspy-events">Events</a></li>
                </ul>
            </li>
            <li>
                <a href="#tabs">Tab</a>
                <ul class="nav">
                    <li><a href="#tabs-examples">Examples</a></li>
                    <li><a href="#tabs-usage">Usage</a></li>
                    <li><a href="#tabs-methods">Methods</a></li>
                    <li><a href="#tabs-events">Events</a></li>
                </ul>
            </li>
            <li>
                <a href="#tooltips">Tooltip</a>
                <ul class="nav">
                    <li><a href="#tooltips-examples">Examples</a></li>
                    <li><a href="#tooltips-usage">Usage</a></li>
                    <li><a href="#tooltips-options">Options</a></li>
                    <li><a href="#tooltips-methods">Methods</a></li>
                    <li><a href="#tooltips-events">Events</a></li>
                </ul>
            </li>
            <li>
                <a href="#popovers">Popover</a>
                <ul class="nav">
                    <li><a href="#popovers-examples">Examples</a></li>
                    <li><a href="#popovers-usage">Usage</a></li>
                    <li><a href="#popovers-options">Options</a></li>
                    <li><a href="#popovers-methods">Methods</a></li>
                    <li><a href="#popovers-events">Events</a></li>
                </ul>
            </li>
            <li>
                <a href="#alerts">Alert</a>
                <ul class="nav">
                    <li><a href="#alerts-examples">Examples</a></li>
                    <li><a href="#alerts-usage">Usage</a></li>
                    <li><a href="#alerts-methods">Methods</a></li>
                    <li><a href="#alerts-events">Events</a></li>
                </ul>
            </li>
            <li>
                <a href="#buttons">Button</a>
                <ul class="nav">
                    <li><a href="#buttons-stateful">Stateful</a></li>
                    <li><a href="#buttons-single-toggle">Single toggle</a></li>
                    <li><a href="#buttons-checkbox-radio">Checkbox / Radio</a></li>
                    <li><a href="#buttons-methods">Methods</a></li>
                </ul>
            </li>
            <li class="">
                <a href="#collapse">Collapse</a>
                <ul class="nav">
                    <li><a href="#collapse-example">Example</a></li>
                    <li class=""><a href="#collapse-example-accordion">Accordion example</a></li>
                    <li class=""><a href="#collapse-usage">Usage</a></li>
                    <li><a href="#collapse-options">Options</a></li>
                    <li><a href="#collapse-methods">Methods</a></li>
                    <li><a href="#collapse-events">Events</a></li>
                </ul>
            </li>
            <li class="active">
                <a href="#carousel">Carousel</a>
                <ul class="nav">
                    <li class=""><a href="#carousel-examples">Examples</a></li>
                    <li class="active"><a href="#carousel-usage">Usage</a></li>
                    <li class=""><a href="#carousel-options">Options</a></li>
                    <li class=""><a href="#carousel-methods">Methods</a></li>
                    <li class=""><a href="#carousel-events">Events</a></li>
                </ul>
            </li>
            <li class="">
                <a href="#affix">Affix</a>
                <ul class="nav">
                    <li class=""><a href="#affix-examples">Examples</a></li>
                    <li class=""><a href="#affix-usage">Usage</a></li>
                    <li class=""><a href="#affix-options">Options</a></li>
                    <li><a href="#affix-methods">Methods</a></li>
                    <li><a href="#affix-events">Events</a></li>
                </ul>
            </li>
        </ul>
    </twt:Affix>
</asp:Content>
