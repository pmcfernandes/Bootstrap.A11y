// Carousel.cs

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

    [ToolboxData("<{0}:Carousel runat=server></{0}:Carousel>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Image))]
    [ParseChildren(true, "Items")]
    [PersistChildren(false)]
    public class Carousel : WebControl, INamingContainer
    {
        private CarouselCollection _Items;

        /// <summary>
        /// Initializes a new instance of the <see cref="TabControl" /> class.
        /// </summary>
        public Carousel()
        {
            _Items = new CarouselCollection(this);
            this.ActiveCarouselItem = 0;
        }

        [Category("Appearance")]
        [DefaultValue(true)]
        public int ActiveCarouselItem
        {
            get { return (int)ViewState["ActiveCarouselItem"]; }
            set { ViewState["ActiveCarouselItem"] = value; }
        }

        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <value>
        /// The tab pages.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public CarouselCollection Items
        {
            get { return _Items; }
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
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "left carousel-control");
            writer.AddAttribute(HtmlTextWriterAttribute.Href, "#" + this.ClientID);
            writer.AddAttribute("role","button");
            writer.AddAttribute("data-slide", "prev");
            writer.RenderBeginTag(HtmlTextWriterTag.A);

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "glyphicon glyphicon-chevron-left");
            writer.AddAttribute("aria-hidden", "true");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag(); // Span

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");            
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write("Previous");
            writer.RenderEndTag(); // Span
            writer.RenderEndTag(); // A

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "right carousel-control");
            writer.AddAttribute(HtmlTextWriterAttribute.Href, "#" + this.ClientID);
            writer.AddAttribute("role", "button");
            writer.AddAttribute("data-slide", "next");
            writer.RenderBeginTag(HtmlTextWriterTag.A);

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "glyphicon glyphicon-chevron-right");
            writer.AddAttribute("aria-hidden", "true");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag(); // Span

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");            
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write("Next");
            writer.RenderEndTag(); // Span
            writer.RenderEndTag(); // A

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
            writer.AddAttribute("data-ride", "carousel");

            base.Render(writer);
        }

        /// <summary>
        /// Renders the list items of a <see cref="T:System.Web.UI.WebControls.BulletedList" /> control as bullets into the specified <see cref="T:System.Web.UI.HtmlTextWriter" />.
        /// </summary>
        /// <param name="writer">An <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "carousel-indicators");
            writer.RenderBeginTag(HtmlTextWriterTag.Ol);

            for (int i = 0; i < this.Items.Count; i++)
            {
                CarouselItem item = this.Items[i];

                string strCssClass = "";
                if (this.ActiveCarouselItem == i)
                {
                    strCssClass += " active";
                }

                writer.AddAttribute(HtmlTextWriterAttribute.Class, strCssClass);
                writer.AddAttribute("data-target", "#" + this.ClientID);
                writer.AddAttribute("data-slide-to", i.ToString());
                writer.RenderBeginTag(HtmlTextWriterTag.Li);
                writer.RenderEndTag(); // Li
            }

            writer.RenderEndTag(); // Ol

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "carousel-inner");
            writer.AddAttribute("role", "listbox");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            for (int i = 0; i < this.Items.Count; i++)
            {
                CarouselItem item = this.Items[i];

                string strCssClass = "item";
                if (this.ActiveCarouselItem == i)
                {
                    strCssClass += " active";
                }

                if (!String.IsNullOrEmpty(strCssClass))
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, strCssClass);
                }

                writer.RenderBeginTag(HtmlTextWriterTag.Div);               
                item.RenderControl(writer);
                writer.RenderEndTag(); // Div
            }
            
            writer.RenderEndTag(); // Div
        }

        /// <summary>
        /// Notifies the server control that an element, either XML or HTML, was parsed, and adds the element to the server control's <see cref="T:System.Web.UI.ControlCollection" /> object.
        /// </summary>
        /// <param name="obj">An <see cref="T:System.Object" /> that represents the parsed element.</param>
        protected override void AddParsedSubObject(object obj)
        {
            if (obj is CarouselItem)
            {
                this.Items.Add((CarouselItem)obj);
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
            string str = "carousel slide";

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }
    }
}