// MediaObject.cs

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
using System.Web.UI.WebControls;

namespace Tie.Controls.Bootstrap
{
    public enum ImageAlign
    {
        Left = 0,
        Right = 1
    }

    [ToolboxData("<{0}:MediaObject runat=server></{0}:MediaObject>")]
    [DefaultProperty("Title")]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class MediaObject : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaObject" /> class.
        /// </summary>
        public MediaObject()
            : base()
        {
            this.ImageAlign = ImageAlign.Left;
            this.NavigationUrl = "#";
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(MediaObject))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the image align.
        /// </summary>
        /// <value>
        /// The image align.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(ImageAlign.Left)]
        public ImageAlign ImageAlign
        {
            get { return (ImageAlign)ViewState["ImageAlign"]; }
            set { ViewState["ImageAlign"] = value; }
        }

        /// <summary>
        /// Gets or sets the navigation URL.
        /// </summary>
        /// <value>
        /// The navigation URL.
        /// </value>
        [Category("Link")]
        [DefaultValue("#")]
        public string NavigationUrl
        {
            get { return (string)ViewState["NavigationUrl"]; }
            set { ViewState["NavigationUrl"] = value; }
        }


        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        public string Title
        {
            get { return (string)ViewState["Title"]; }
            set { ViewState["Title"] = value; }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        public string Description
        {
            get { return (string)ViewState["Description"]; }
            set { ViewState["Description"] = value; }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        [UrlProperty]
        public string ImageUrl
        {
            get { return (string)ViewState["ImageUrl"]; }
            set { ViewState["ImageUrl"] = value; }
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
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());

            base.Render(writer);
        }

        /// <summary>
        /// Renders the contents.
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void RenderContents(HtmlTextWriter output)
        {
            if (ImageAlign == Bootstrap.ImageAlign.Left)
            {
                this.RenderImage(output);
            }
            
            output.AddAttribute(HtmlTextWriterAttribute.Class, "media-body");
            output.RenderBeginTag(HtmlTextWriterTag.Div);

            this.RenderTitle(output);
            this.RenderDescription(output);

            output.RenderBeginTag(HtmlTextWriterTag.Div);
            this.RenderChildren(output);
            output.RenderEndTag();

            output.RenderEndTag(); // Div   

            if (ImageAlign == Bootstrap.ImageAlign.Right)
            {
                this.RenderImage(output);
            }
        }

        /// <summary>
        /// Renders the image.
        /// </summary>
        /// <param name="output">The output.</param>
        private void RenderImage(HtmlTextWriter output)
        {
            switch (ImageAlign)
            {
                case ImageAlign.Left:
                    output.AddAttribute(HtmlTextWriterAttribute.Class, "media-left");
                    output.RenderBeginTag(HtmlTextWriterTag.Div);
                    break;

                case ImageAlign.Right:
                    output.AddAttribute(HtmlTextWriterAttribute.Class, "media-right");
                    output.RenderBeginTag(HtmlTextWriterTag.Div);
                    break;
            }
            
            output.AddAttribute(HtmlTextWriterAttribute.Href, ResolveUrl(this.NavigationUrl));
            output.RenderBeginTag(HtmlTextWriterTag.A);            

            output.AddAttribute(HtmlTextWriterAttribute.Class, "media-object");
            output.AddAttribute("data-src", this.ImageUrl);
            output.AddAttribute("src", this.ImageUrl);
            output.RenderBeginTag(HtmlTextWriterTag.Img);
            output.RenderEndTag(); // Img
            output.RenderEndTag(); // A
            output.RenderEndTag(); // Div
        }

        /// <summary>
        /// Renders the title.
        /// </summary>
        /// <param name="output">The output.</param>
        private void RenderTitle(HtmlTextWriter output)
        {
            output.AddAttribute(HtmlTextWriterAttribute.Class, "media-heading");
            output.RenderBeginTag(HtmlTextWriterTag.H4);
            output.Write(this.Title);
            output.RenderEndTag();
        }

        /// <summary>
        /// Renders the description.
        /// </summary>
        /// <param name="output">The output.</param>
        private void RenderDescription(HtmlTextWriter output)
        {
            output.RenderBeginTag(HtmlTextWriterTag.P);
            output.Write(this.Description);
            output.RenderEndTag();
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

        private string BuildCss()
        {
            string str = "media";

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }
    }
}
