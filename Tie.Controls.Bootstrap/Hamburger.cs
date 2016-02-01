// Hamburguer.cs

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
    [ToolboxData("<{0}:Hamburger runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Button))]
    [DefaultProperty("Text")]
    public class Hamburger : System.Web.UI.WebControls.Button, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Button" /> class.
        /// </summary>
        public Hamburger()
            : base()
        {
            this.Text = "Brand";
            this.NavigateUrl = "#";
        }

        /// <summary>
        /// Gets or sets the type of the label.
        /// </summary>
        /// <value>
        /// The type of the label.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("#")]
        public string NavigateUrl
        {
            get { return (string)ViewState["NavigateUrl"]; }
            set { ViewState["NavigateUrl"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            base.Render(writer);
        }

        /// <summary>
        /// Renders the HTML opening tag of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "navbar-header");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            writer.AddAttribute(HtmlTextWriterAttribute.Type, "button");
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            writer.AddAttribute("data-toggle", "data-toggle");
            writer.AddAttribute("aria-expanded", "false");

            writer.RenderBeginTag(HtmlTextWriterTag.Button);
        }

        /// <summary>
        /// Renders the HTML closing tag of the control into the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "navbar-brand");
            writer.AddAttribute(HtmlTextWriterAttribute.Href, ResolveUrl(this.NavigateUrl));            
            writer.RenderBeginTag(HtmlTextWriterTag.A);
            writer.Write(this.Text);
            writer.RenderEndTag();

            writer.RenderEndTag();
        }

        /// <summary>
        /// Renders the contents of the control to the specified writer.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> object that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write("Toggle navigation");
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "icon-bar");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "icon-bar");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "icon-bar");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag();

            base.RenderContents(writer);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "navbar-toggle collapsed";

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }
    }
}
