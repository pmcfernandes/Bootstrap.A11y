// Image.cs

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

namespace Tie.Controls.Bootstrap
{

    public enum ImageTypes
    {
        None = 0,
        Rounded = 1,
        Circle = 2,
        Polaroid = 3
    }

    [ToolboxData("<{0}:Image runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Image))]
    [DefaultProperty("ImageUrl")]
    public class Image : System.Web.UI.WebControls.Image
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
            : base()
        {
            this.ImageType = ImageTypes.None;
            this.Responsive = false;
        }

        /// <summary>
        /// Gets or sets the type of the image.
        /// </summary>
        /// <value>
        /// The type of the image.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(ImageTypes.None)]
        public ImageTypes ImageType
        {
            get { return (ImageTypes)ViewState["ImageType"]; }
            set { ViewState["ImageType"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Image"/> is responsive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if responsive; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Responsive
        {
            get { return (bool)ViewState["Responsive"]; }
            set { ViewState["Responsive"] = value; }
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
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = (this.Responsive ? "img-responsive" : "");
            str += " " + this.GetCssImageType();

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }

        /// <summary>
        /// Gets the type of the CSS image.
        /// </summary>
        /// <returns></returns>
        private string GetCssImageType()
        {
            string str = "";
           
            switch (this.ImageType)
            {
                case ImageTypes.Rounded:
                    str = "img-rounded";
                    break;

                case ImageTypes.Polaroid:
                    str = "img-thumbnail";
                    break;

                case ImageTypes.Circle:
                    str = "img-circle";
                    break;

                default:
                    str = "";
                    break;
            }

            return str;
        }
    }
}