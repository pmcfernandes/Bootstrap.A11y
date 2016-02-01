// ButtonGroup.cs

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

    [ToolboxData("<{0}:ButtonGroup runat=server></{0}:ButtonGroup>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Button))]
    [DefaultProperty("CssClass")]
    [ParseChildren(true, "Buttons")]
    [PersistChildren(false)]
    public class ButtonGroup : WebControl, INamingContainer
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonGroup"/> class.
        /// </summary>
        public ButtonGroup()
            : base()
        {
            this.Orientation = System.Web.UI.WebControls.Orientation.Horizontal;
            this.ButtonSize = ButtonSizes.Default;
            this.Justified = false;
            this.Toolbar = false;
        }

        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>
        /// The orientation.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(Orientation.Horizontal)]
        public Orientation Orientation
        {
            get { return (Orientation)ViewState["Orientation"]; }
            set { ViewState["Orientation"] = value; }
        }

        /// <summary>
        /// Gets or sets the size of the button.
        /// </summary>
        /// <value>
        /// The size of the button.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(ButtonSizes.Default)]
        public ButtonSizes ButtonSize
        {
            get { return (ButtonSizes)ViewState["ButtonSize"]; }
            set { ViewState["ButtonSize"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ButtonGroup"/> is justified.
        /// </summary>
        /// <value>
        ///   <c>true</c> if justified; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Justified
        {
            get { return (bool)ViewState["Justified"]; }
            set { ViewState["Justified"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ButtonGroup"/> is toolbar.
        /// </summary>
        /// <value>
        ///   <c>true</c> if toolbar; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Toolbar
        {
            get { return (bool)ViewState["Toolbar"]; }
            set { ViewState["Toolbar"] = value; }
        }

        /// <summary>
        /// Gets or sets the buttons.
        /// </summary>
        /// <value>
        /// The buttons.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(ButtonGroup))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Buttons
        {
            get;
            set;
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

            if (this.Toolbar == true)
            {
                writer.AddAttribute("role", "toolbar");
            }
            else
            {
                writer.AddAttribute("role", "group");
            }


            base.Render(writer);
        }

        /// <summary>
        /// Renders the contents.
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void RenderContents(HtmlTextWriter output)
        {
            this.RenderChildren(output);
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
            this.Buttons.InstantiateIn(container);

            this.Controls.Clear();
            this.Controls.Add(container);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = (this.Toolbar ? "btn-toolbar" : "btn-group");
            str += " " + this.GetCssButtonSize();

            if (this.Justified == true)
            {
                str += " btn-group-justified";
            }

            if (this.Orientation == System.Web.UI.WebControls.Orientation.Vertical)
            {
                str += " btn-group-vertical";
            }

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }

        /// <summary>
        /// Gets the size of the CSS button.
        /// </summary>
        /// <returns></returns>
        private string GetCssButtonSize()
        {
            string str = "";

            switch (this.ButtonSize)
            {
                case ButtonSizes.Large:
                    str += "btn-group-lg";
                    break;

                case ButtonSizes.Small:
                    str += "btn-group-sm";
                    break;

                case ButtonSizes.Mini:
                    str += "btn-group-xs";
                    break;

                default:
                    break;
            }

            return str;
        }
    }
}