// Label.cs

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
    public enum LabelTypes
    {
        Default = 0,
        Success = 1,
        Warning = 2,
        Primary = 3,
        Info = 4,
        Danger = 5
    }

    [ToolboxData("<{0}:Label runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Label))]
    [DefaultProperty("Text")]
    public class Label : System.Web.UI.WebControls.Label
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        public Label()
            : base()
        {
            this.LabelType = LabelTypes.Default;
            this.Text = "Label";
        }

        /// <summary>
        /// Gets or sets the type of the label.
        /// </summary>
        /// <value>
        /// The type of the label.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(LabelTypes.Default)]
        public LabelTypes LabelType
        {
            get { return (LabelTypes)ViewState["LabelType"]; }
            set { ViewState["LabelType"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
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
            string str = "label";
            str += " " + this.GetCssLabelType();

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }

        /// <summary>
        /// Gets the type of the CSS label.
        /// </summary>
        /// <returns></returns>
        private string GetCssLabelType()
        {
            string str = "";

            switch (this.LabelType)
            {
                case LabelTypes.Success:
                    str = "label-success";
                    break;

                case LabelTypes.Warning:
                     str = "label-warning";
                    break;

                case LabelTypes.Primary:
                    str = "label-primary";
                    break;

                case LabelTypes.Info:
                     str = "label-info";
                    break;

                case LabelTypes.Danger:
                    str = "label-danger";
                    break;

                default:
                    str = "label-default";
                    break;
            }

            return str;
        }

    }

}