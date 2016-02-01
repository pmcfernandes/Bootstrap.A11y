// CarouselItem.cs

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
using System.Text;
using System.Web.UI;

namespace Tie.Controls.Bootstrap
{
    [ToolboxData("<{0}:CarouselItem runat=server></{0}:CarouselItem>")]
    [ToolboxItem(false)]
    public class CarouselItem : Control, INamingContainer
    {

        public CarouselItem()
            : base()
        {
            this.Text = "";
            this.Title = "";
            this.ImageUrl = "";
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
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("")]
        public string Text
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
        [DefaultValue("")]
        public string ImageUrl
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
            writer.AddAttribute(HtmlTextWriterAttribute.Src, ResolveUrl(this.ImageUrl));
            writer.AddAttribute(HtmlTextWriterAttribute.Alt, this.Title);
            writer.RenderBeginTag(HtmlTextWriterTag.Img);
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "carousel-caption");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            if (!String.IsNullOrEmpty(this.Title) || !String.IsNullOrEmpty(this.Text))
            {
                if (!String.IsNullOrEmpty(this.Title))
                {
                    writer.RenderBeginTag(HtmlTextWriterTag.H3);
                    writer.Write(this.Title);
                    writer.RenderEndTag(); // H3
                }

                if (!String.IsNullOrEmpty(this.Text))
                {
                    writer.RenderBeginTag(HtmlTextWriterTag.P);
                    writer.Write(this.Text);
                    writer.RenderEndTag(); // P
                }
            }

            writer.RenderEndTag(); // Div            

            base.Render(writer);
        }

    }
}
