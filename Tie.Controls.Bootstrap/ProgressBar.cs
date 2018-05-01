// ProgressBar.cs

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
using System.Web.UI.WebControls;

namespace Tie.Controls.Bootstrap
{
    public enum ProgressBarStyles
    {
        Info = 0,
        Success = 1,
        Warning = 2,
        Danger = 3
    }

    [ToolboxData("<{0}:ProgressBar runat=server />")]
    public class ProgressBar : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBar" /> class.
        /// </summary>
        public ProgressBar()
            : base()
        {
            this.Animated = false;
            this.Striped = false;
            this.ShowLabel = false;
            this.Value = 50;
            this.ProgressBarStyle = ProgressBarStyles.Info;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [Category("Behavior")]
        public int Value
        {
            get { return (int)ViewState["Value"]; }
            set { ViewState["Value"] = value; }
        }

        /// <summary>
        /// Gets or sets the progress bar style.
        /// </summary>
        /// <value>
        /// The progress bar style.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(ProgressBarStyles.Info)]
        public ProgressBarStyles ProgressBarStyle
        {
            get { return (ProgressBarStyles)ViewState["ProgressBarStyle"]; }
            set { ViewState["ProgressBarStyle"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show label].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show label]; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool ShowLabel
        {
            get { return (bool)ViewState["ShowLabel"]; }
            set { ViewState["ShowLabel"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgressBar"/> is animated.
        /// </summary>
        /// <value>
        ///   <c>true</c> if animated; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Animated
        {
            get { return (bool)ViewState["Animated"]; }
            set { ViewState["Animated"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgressBar" /> is striped.
        /// </summary>
        /// <value>
        ///   <c>true</c> if striped; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Striped
        {
            get { return (bool)ViewState["Striped"]; }
            set { ViewState["Striped"] = value; }
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
        /// Renders the contents of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            Unit uValue = Unit.Parse(this.Value + "%");

            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildInternalCss());
            writer.AddStyleAttribute(HtmlTextWriterStyle.Width, uValue.ToString());
            writer.AddAttribute("role", "progressbar");            
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            if (this.ShowLabel == false)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
                writer.Write(uValue.ToString());
                writer.RenderEndTag();
            }
            else
            {
                writer.Write(uValue.ToString());
            }

            writer.RenderEndTag();
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
        /// Builds the internal CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildInternalCss()
        {
            string str = "progress-bar";

            str += " " + this.GetProgressBarStyles();

            if (this.Striped == true)
            {
                str += " progress-bar-striped";

                if (this.Animated == true)
                {
                    str += " active";
                }
            }

            return str.Trim();
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "progress";
           
            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }

        /// <summary>
        /// Gets the progress bar styles.
        /// </summary>
        /// <returns></returns>
        private string GetProgressBarStyles()
        {
            string str = "";

            switch (this.ProgressBarStyle)
            {
                case ProgressBarStyles.Success:
                    str = "progress-bar-success";
                    break;

                case ProgressBarStyles.Warning:
                    str = "progress-bar-warning";
                    break;

                case ProgressBarStyles.Danger:
                    str = "progress-bar-danger";
                    break;

                case ProgressBarStyles.Info:
                    str = "progress-bar-info";
                    break;

                default:
                    str = "";
                    break;
            }

            return str.Trim();
        }
    }
}
