// InputGroup.cs

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
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tie.Controls.Bootstrap
{
    [ToolboxData("<{0}:InputGroup runat=server></{0}:InputGroup>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Panel))]
    [DefaultProperty("CssClass")]
    [ParseChildren(true, "Input")]
    [PersistChildren(false)]
    public class InputGroup : WebControl, INamingContainer
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Container"/> class.
        /// </summary>
        public InputGroup()
            : base()
        {
            this.Size = Size.Default;
            this.Prefix = "";
            this.Suffix = "";
        }

        /// <summary>
        /// Gets or sets the rows.
        /// </summary>
        /// <value>
        /// The rows.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Row))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Input
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(Size.Default)]
        public Size Size
        {
            get { return (Size)ViewState["Size"]; }
            set { ViewState["Size"] = value; }
        }

        /// <summary>
        /// Gets or sets the prefix.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Prefix
        {
            get { return (string)ViewState["Prefix"]; }
            set { ViewState["Prefix"] = value; }
        }

        /// <summary>
        /// Gets or sets the suffix.
        /// </summary>
        /// <value>
        /// The suffix.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Suffix
        {
            get { return (string)ViewState["Suffix"]; }
            set { ViewState["Suffix"] = value; }
        }

        /// <summary>
        /// Renders the HTML opening tag of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
        }

        /// <summary>
        /// Renders the HTML closing tag of the control into the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());

            base.Render(writer);
        }

        /// <summary>
        /// Renders the contents.
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void RenderContents(HtmlTextWriter output)
        {
            if (!String.IsNullOrEmpty(this.Prefix))
            {
                output.AddAttribute(HtmlTextWriterAttribute.Class, "input-group-addon");
                output.RenderBeginTag(HtmlTextWriterTag.Span);
                output.Write(this.Prefix);
                output.RenderEndTag();
            }

            this.RenderChildren(output);

            if (!String.IsNullOrEmpty(this.Suffix))
            {
                output.AddAttribute(HtmlTextWriterAttribute.Class, "input-group-addon");
                output.RenderBeginTag(HtmlTextWriterTag.Span);
                output.Write(this.Suffix);
                output.RenderEndTag();
            }
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
            var container = new Control();
            this.Input.InstantiateIn(container);

            this.Controls.Clear();
            this.Controls.Add(container);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "input-group";
            str += " " + this.GetCssSize();

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
        private string GetCssSize()
        {
            string str = "";

            switch (this.Size)
            {
                case Size.Large:
                    str = "input-group-lg";
                    break;

                case Size.Small:
                    str = "input-group-sm";
                    break;

                default:
                    str = "";
                    break;
            }

            return str;
        }
    }
}
