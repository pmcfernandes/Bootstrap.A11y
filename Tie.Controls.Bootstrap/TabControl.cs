// TabControl.cs

// Copyright (C) 2013 Pedro Fernandes

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tie.Controls.Bootstrap
{

    public class TabPageChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the index of the page.
        /// </summary>
        /// <value>
        /// The index of the page.
        /// </value>
        public int Index
        {
            get;
            set;
        }
    }
    
    [ToolboxData("<{0}:TabControl runat=server></{0}:TabControl>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Image))]
    [ParseChildren(true, "TabPages")]
    [PersistChildren(false)]
    public class TabControl : WebControl, INamingContainer, IPostBackDataHandler
    {
        public event EventHandler<TabPageChangedEventArgs> TabPageChanged;
        private TabCollection _Tabs;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TabControl" /> class.
        /// </summary>
        public TabControl()
            : base()
        {
            _Tabs = new TabCollection(this);
            this.ActiveTabPage = 0;
            this.Pills = false;
            this.Stacked = false;
            this.Justified = false;
            this.AutoPostBack = false;
        }

        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <value>
        /// The tab pages.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] 
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public TabCollection TabPages
        {
            get { return _Tabs; }
        }

        /// <summary>
        /// Gets or sets the active tab page.
        /// </summary>
        /// <value>
        /// The active tab page.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public int ActiveTabPage
        {
            get { return (int)ViewState["ActiveTabPage"]; }
            set { ViewState["ActiveTabPage"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TabControl"/> is pills.
        /// </summary>
        /// <value>
        ///   <c>true</c> if pills; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Pills
        {
            get { return (bool)ViewState["Pills"]; }
            set { ViewState["Pills"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TabControl"/> is stacked.
        /// </summary>
        /// <value>
        ///   <c>true</c> if stacked; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Stacked
        {
            get { return (bool)ViewState["Stacked"]; }
            set { ViewState["Stacked"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TabControl"/> is justified.
        /// </summary>
        /// <value>
        ///   <c>true</c> if justified; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Justified
        {
            get { return (bool)ViewState["Justified"]; }
            set { ViewState["Justified"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic post back].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic post back]; otherwise, <c>false</c>.
        /// </value>
        [Category("Behavior")]
        [DefaultValue(false)]
        public bool AutoPostBack
        {
            get { return (bool)ViewState["AutoPostBack"]; }
            set { ViewState["AutoPostBack"] = value; }
        }

        /// <summary>
        /// Renders the HTML opening tag of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.Ul);
        }

        /// <summary>
        /// Renders the HTML closing tag of the control into the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "tab-content");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            for (int i = 0; i < this.TabPages.Count; i++)
            {
                TabPage tabPage = this.TabPages[i];
                tabPage.ID = this.ID + "_" + "tab-" + (i + 1);

                string strCssClass = "tab-pane fade ";
                if (this.ActiveTabPage == i)
                {
                    strCssClass += "in active";
                }

                writer.AddAttribute(HtmlTextWriterAttribute.Id, tabPage.ID);
                writer.AddAttribute(HtmlTextWriterAttribute.Class, strCssClass.Trim());
                writer.AddAttribute("role", "tabpanel");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
                tabPage.Container.RenderControl(writer);
                writer.RenderEndTag();
            }

            writer.RenderEndTag();
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            writer.AddAttribute("role", "tablist");

            base.Render(writer);           
        }

        /// <summary>
        /// Renders the list items of a <see cref="T:System.Web.UI.WebControls.BulletedList" /> control as bullets into the specified <see cref="T:System.Web.UI.HtmlTextWriter" />.
        /// </summary>
        /// <param name="writer">An <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            for (int i = 0; i < this.TabPages.Count; i++)
            {
                TabPage tabPage = this.TabPages[i];
                tabPage.ID = this.ID + "_" + "tab-" + (i + 1);
                tabPage.Index = i;

                string strCssClass = "";

                if (this.ActiveTabPage == i)
                {
                    strCssClass += " active";
                }

                if (tabPage.Enabled == false)
                {
                    strCssClass += " disabled";
                }

                if (!String.IsNullOrEmpty(strCssClass))
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, strCssClass.Trim());
                }

                writer.AddAttribute("role", "presentation");
                writer.RenderBeginTag(HtmlTextWriterTag.Li);

                tabPage.RenderControl(writer);
                writer.RenderEndTag();
            }
        }

        /// <summary>
        /// Notifies the server control that an element, either XML or HTML, was parsed, and adds the element to the server control's <see cref="T:System.Web.UI.ControlCollection" /> object.
        /// </summary>
        /// <param name="obj">An <see cref="T:System.Object" /> that represents the parsed element.</param>
        protected override void AddParsedSubObject(object obj)
        {
            if (obj is TabPage)
            {
                TabPages.Add((TabPage)obj);
                return;
            }
        }

        /// <summary>
        /// Gets a <see cref="T:System.Web.UI.ControlCollection" /> object that represents the child controls for a specified server control in the UI hierarchy.
        /// </summary>
        /// <returns>
        /// The collection of child controls for the specified server control.
        ///   </returns>
        public override ControlCollection Controls
        {
            get
            {
                this.EnsureChildControls();
                return base.Controls;
            }
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "nav";
            str += " " + (this.Pills ? "nav-pills" : "nav-tabs");
            str += " " + (this.Stacked ? " nav-stacked" : "");
            str += " " + (this.Justified ? " nav-justified" : "");

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            if (this.AutoPostBack)
            {
                this.Page.RegisterRequiresPostBack(this);
            }

            base.OnInit(e);
        }

        /// <summary>
        /// When implemented by a class, processes postback data for an ASP.NET server control.
        /// </summary>
        /// <param name="postDataKey">The key identifier for the control.</param>
        /// <param name="postCollection">The collection of all incoming name values.</param>
        /// <returns>
        /// true if the server control's state changes as a result of the postback; otherwise, false.
        /// </returns>
        public bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
        {
            if (this.AutoPostBack)
            {
                if (!(postCollection["__EVENTTARGET"] == this.UniqueID))
                {
                    return false;
                }

                int tabPageIndex = Convert.ToInt32(postCollection["__EVENTARGUMENT"]);

                if (!(this.ActiveTabPage == tabPageIndex))
                {
                    this.ActiveTabPage = tabPageIndex;
                    return true;
                }        
            }

            return false;
        }

        /// <summary>
        /// Signals the server control to notify the ASP.NET application that the state of the control has changed.
        /// </summary>
        public void RaisePostDataChangedEvent()
        {
            OnTabPageChanged();
        }

        /// <summary>
        /// Called when [tab page changed].
        /// </summary>
        private void OnTabPageChanged()
        {
            if (TabPageChanged != null)
            {
                TabPageChanged(this, new TabPageChangedEventArgs() { Index = this.ActiveTabPage });
            }
        }
    }
}