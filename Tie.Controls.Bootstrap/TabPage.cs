// TabPage.cs

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
using System.ComponentModel;
using System.Web.UI;

namespace Tie.Controls.Bootstrap
{
    /// <summary>
    /// The individual TabPage class that holds the intermediary Tab page values
    /// </summary>
    [ToolboxData("<{0}:TabPage runat=server></{0}:TabPage>")]
    [ToolboxItem(false)]
    [ParseChildren(true, "Content")]
    [PersistChildren(true)]
    public class TabPage : Control, INamingContainer
    {
        private Control container;
        private string strPostBackScript;

        /// <summary>
        /// Initializes a new instance of the <see cref="TabPage" /> class.
        /// </summary>
        public TabPage()
        {
            this.Enabled = true;
            this.Title = this.ID;
            this.Index = 0;
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(FieldSet))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TabPage" /> is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        internal int Index
        {
            get;
            set;
        }


        /// <summary>
        /// Sends server control content to a provided <see cref="T:System.Web.UI.HtmlTextWriter" /> object, which writes the content to be rendered on the client.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the server control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            TabControl tabControl = (TabControl)this.Parent;
            
            if (tabControl.AutoPostBack)
            {
                strPostBackScript = this.Page.ClientScript.GetPostBackClientHyperlink(tabControl, this.Index.ToString());
                writer.AddAttribute(HtmlTextWriterAttribute.Onclick, strPostBackScript);
            }

            writer.AddAttribute(HtmlTextWriterAttribute.Href, "#" + this.ID);
            writer.AddAttribute("aria-controls", this.ID);
            writer.AddAttribute("role", "tab");
            writer.AddAttribute("data-toggle", "tab");
            writer.RenderBeginTag(HtmlTextWriterTag.A);
            writer.Write(this.Title);
            writer.RenderEndTag();

            base.Render(writer);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(System.EventArgs e)
        {
            base.OnInit(e);

            this.CreateChildControls();
            this.ChildControlsCreated = true;
        }

        /// <summary>
        /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
        /// </summary>
        protected override void CreateChildControls()
        {
            this.container = new Control();
            this.Content.InstantiateIn(container);
        }

        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        /// <value>
        /// The container.
        /// </value>
        internal Control Container
        {
            get { return this.container; }
            set { this.container = value; }
        }

    }
}