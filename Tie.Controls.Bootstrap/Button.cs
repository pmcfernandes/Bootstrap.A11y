// Button.cs

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
    public enum ButtonTypes
    {
        Default = 0,
        Primary = 1,
        Info = 2,
        Success = 3,
        Warning = 4,
        Danger = 5,
        Inverse = 6,
        Link = 7
    }

    public enum ButtonSizes
    {
        Default = 0,
        Large = 1,
        Small = 2,
        Mini = 3
    }

    [ToolboxData("<{0}:Button runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Button))]
    [DefaultProperty("Text")]
    public class Button : System.Web.UI.WebControls.Button, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Button" /> class.
        /// </summary>
        public Button()
            : base()
        {
            this.ButtonType = ButtonTypes.Default;
            this.ButtonSize = ButtonSizes.Default;
            this.Block = false;
            this.Pressed = false;
            this.UseSubmitBehavior = true;
            this.ModalID = "";
        }

        /// <summary>
        /// Gets or sets the popover.
        /// </summary>
        /// <value>
        /// The popover.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual Popover Popover
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the button identifier.
        /// </summary>
        /// <value>
        /// The button identifier.
        /// </value>
        [Category("Modal")]
        [DefaultValue("")]
        public string ModalID
        {
            get { return (string)ViewState["ModalID"]; }
            set { ViewState["ModalID"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Button" /> is block.
        /// </summary>
        /// <value>
        ///   <c>true</c> if block; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Block
        {
            get { return (bool)ViewState["Block"]; }
            set { ViewState["Block"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Button"/> is pressed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if pressed; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Pressed
        {
            get { return (bool)ViewState["Pressed"]; }
            set { ViewState["Pressed"] = value; }
        }

        /// <summary>
        /// Gets or sets the type of the button.
        /// </summary>
        /// <value>
        /// The type of the button.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(ButtonTypes.Default)]
        public ButtonTypes ButtonType
        {
            get { return (ButtonTypes)ViewState["ButtonType"]; }
            set { ViewState["ButtonType"] = value; }
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
            if (!String.IsNullOrEmpty(this.ModalID))
            {
                Modal modal = (Modal)Modal.FindControlRecursive(this.Page, this.ModalID);

                if (modal != null)
                {
                    this.UseSubmitBehavior = false;
                    writer.AddAttribute("data-toggle", "modal");
                    writer.AddAttribute("data-target", "#" + modal.ClientID);
                }
            }

            if (this.Popover != null)
            {
                writer.AddAttribute("data-toggle", "popover");
                writer.AddAttribute("data-container", "body");
                writer.AddAttribute("data-content", this.Popover.Text);
                writer.AddAttribute("data-placement", this.Popover.Position.ToString().ToLower());

                if (!String.IsNullOrEmpty(this.Popover.Title))
                {
                    writer.AddAttribute("title", this.Popover.Title);
                }
            }

            if (!this.UseSubmitBehavior)
            {
                this.OnClientClick = "return false;";
            }

            this.CssClass = this.BuildCss();            
            this.AddAttributesToRender(writer);
            writer.RenderBeginTag(HtmlTextWriterTag.Button);
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
        /// Renders the contents of the control to the specified writer.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> object that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.Write(this.Text);
            base.RenderContents(writer);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "btn";
            str += " " + this.GetCssButtonType();
            str += " " + this.GetCssButtonSize();
      
            if (this.Block == true)
            {
                str += " btn-block";
            }

            if (this.Enabled == false)
            {
                str += " disabled";
            }

            if (this.Pressed == true)
            {
                str += " active";
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
                    str += "btn-lg";
                    break;

                case ButtonSizes.Small:
                    str += "btn-sm";
                    break;

                case ButtonSizes.Mini:
                    str += "btn-xs";
                    break;

                default:
                    break;
            }

            return str;
        }

        /// <summary>
        /// Gets the type of the CSS button.
        /// </summary>
        /// <returns></returns>
        private string GetCssButtonType()
        {
            string str = "";

            switch (this.ButtonType)
            {
                case ButtonTypes.Primary:
                    str = "btn-primary";
                    break;

                case ButtonTypes.Info:
                    str = "btn-info";
                    break;

                case ButtonTypes.Success:
                    str = "btn-success";
                    break;

                case ButtonTypes.Warning:
                    str = "btn-warning";
                    break;

                case ButtonTypes.Danger:
                    str = "btn-danger";
                    break;

                case ButtonTypes.Inverse:
                    str = "btn-inverse";
                    break;

                case ButtonTypes.Link:
                    str = "btn-link";
                    break;

                default:
                    str = "btn-default";
                    break;
            }

            return str;
        }
    }
}