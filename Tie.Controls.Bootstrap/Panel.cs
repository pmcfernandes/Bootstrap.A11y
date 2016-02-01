// Panel.cs

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
using System.Text;
using System.Web.UI;

namespace Tie.Controls.Bootstrap
{
    public enum PanelTypes
    {
        Default = 0,
        Primary = 1,
        Success = 2,
        Info = 3,
        Warning = 4,
        Danger = 5
    }

    [ToolboxData("<{0}:Panel runat=server></{0}:Panel>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Panel))]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class Panel : System.Web.UI.WebControls.Panel, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Panel"/> class.
        /// </summary>
        public Panel()
            : base()
        {
            this.Title = "";
            this.PanelType = PanelTypes.Default;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Title
        {
            get { return (string)ViewState["Title"]; }
            set { ViewState["Title"] = value; }
        }

        /// <summary>
        /// Gets or sets the type of the panel.
        /// </summary>
        /// <value>
        /// The type of the panel.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(PanelTypes.Default)]
        public PanelTypes PanelType
        {
            get { return (PanelTypes)ViewState["PanelType"]; }
            set { ViewState["PanelType"] = value; }
        }

        /// <summary>
        /// Gets or sets the footer.
        /// </summary>
        /// <value>
        /// The footer.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Panel))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            base.Render(writer);
        }

        /// <summary>
        /// Renders the HTML opening tag of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {          
            base.RenderBeginTag(writer);

            if (!String.IsNullOrEmpty(this.Title))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "panel-heading");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
                writer.Write(this.Title);
                writer.RenderEndTag();
            }

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "panel-body");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
        }

        /// <summary>
        /// Renders the HTML closing tag of the control into the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();
            writer.RenderEndTag();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(System.EventArgs e)
        {
            base.OnInit(e);

            // Initialize all child controls.
            this.CreateChildControls();
            this.ChildControlsCreated = true;
        }

        /// <summary>
        /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
        /// </summary>
        protected override void CreateChildControls()
        {
            var container = new Control();
            this.Content.InstantiateIn(container);

            this.Controls.Clear();
            this.Controls.Add(container);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "panel";
            str += " " + this.GetCssPanelType();

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }

        /// <summary>
        /// Gets the type of the CSS button.
        /// </summary>
        /// <returns></returns>
        private string GetCssPanelType()
        {
            string str = "";

            switch (this.PanelType)
            {
                case PanelTypes.Primary:
                    str = "panel-primary";
                    break;

                case PanelTypes.Info:
                    str = "panel-info";
                    break;

                case PanelTypes.Success:
                    str = "panel-success";
                    break;

                case PanelTypes.Warning:
                    str = "panel-warning";
                    break;

                case PanelTypes.Danger:
                    str = "panel-danger";
                    break;

                default:
                    str = "panel-default";
                    break;
            }

            return str;
        }
    }
}
