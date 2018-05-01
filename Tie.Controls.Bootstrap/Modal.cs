// Modal.cs

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
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tie.Controls.Bootstrap
{

    public enum ModalSizes
    {        
        Small = 0,
        Default = 1,
        Large = 2
    }

    [ToolboxData("<{0}:Modal runat=server></{0}:Modal>")]
    [DefaultProperty("Text")]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class Modal : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Modal"/> class.
        /// </summary>
        public Modal()
            : base()
        {
            this.Title = "";
            this.Fade = true;
            this.Size = ModalSizes.Default;            
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Title
        {
            get { return (string)ViewState["Title"]; }
            set { ViewState["Title"] = value; }
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        public ModalSizes Size
        {
            get { return (ModalSizes)ViewState["Size"]; }
            set { ViewState["Size"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Modal"/> is fade.
        /// </summary>
        /// <value>
        ///   <c>true</c> if fade; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Fade
        {
            get { return (bool)ViewState["Fade"]; }
            set { ViewState["Fade"] = value; }
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Modal))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the footer.
        /// </summary>
        /// <value>
        /// The footer.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Modal))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Footer
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
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            writer.AddAttribute(HtmlTextWriterAttribute.Tabindex, "-1");
            writer.AddAttribute("role", "dialog");

            base.Render(writer);
        }

        /// <summary>
        /// Renders the contents.
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void RenderContents(HtmlTextWriter output)
        {
            output.AddAttribute(HtmlTextWriterAttribute.Class, ("modal-dialog " + this.GetModalSize()).Trim());
            output.AddAttribute("role", "document");
            output.RenderBeginTag(HtmlTextWriterTag.Div);

            output.AddAttribute(HtmlTextWriterAttribute.Class, "modal-content");
            output.RenderBeginTag(HtmlTextWriterTag.Div);

            output.AddAttribute(HtmlTextWriterAttribute.Class, "modal-header");
            output.RenderBeginTag(HtmlTextWriterTag.Div);

            output.AddAttribute(HtmlTextWriterAttribute.Type, "button");
            output.AddAttribute(HtmlTextWriterAttribute.Class, "close");
            output.AddAttribute("data-dismiss", "modal");
            output.AddAttribute("aria-label", "Close");
            output.RenderBeginTag(HtmlTextWriterTag.Button);

            output.AddAttribute("aria-hidden", "true");
            output.RenderBeginTag(HtmlTextWriterTag.Span);
            output.Write("&times;");
            output.RenderEndTag(); // Span
            output.RenderEndTag(); // Button

            output.AddAttribute(HtmlTextWriterAttribute.Class, "modal-title");
            output.RenderBeginTag(HtmlTextWriterTag.H4);
            output.Write(this.Title);
            output.RenderEndTag(); // H4

            output.RenderEndTag(); // Div

            this.RenderChildren(output);

            output.RenderEndTag(); // Div
            output.RenderEndTag(); // Div
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
            // Remove any controls
#if _4_0
            this.ClearCachedClientID();
#endif
            this.Controls.Clear();

            // Add all content to a container.
            var container = new System.Web.UI.WebControls.Panel();
            container.CssClass = "modal-body";
            this.Content.InstantiateIn(container);
            this.Controls.Add(container);
            
            if (this.Footer != null)
            {
                // Add all footer to a container.
                var footer = new System.Web.UI.WebControls.Panel();
                footer.CssClass = "modal-footer";
                this.Footer.InstantiateIn(footer);
                this.Controls.Add(footer);
            }
        }

        /// <summary>
        /// Opens this instance.
        /// </summary>
        public void Open()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<script type=\"text/javascript\">");
            sb.AppendLine(" $('#" + this.ClientID  + "').modal('show');");
            sb.AppendLine("</script>");

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ModalScript", sb.ToString(), false);
        }

        /// <summary>
        /// Closes this instance.
        /// </summary>
        public void Close()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<script type=\"text/javascript\">");
            sb.AppendLine(" $('#" + this.ClientID + "').modal('hide');");
            sb.AppendLine("</script>");

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ModalScript", sb.ToString(), false);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "modal" + (this.Fade ? " fade" : "");
            
            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }

        /// <summary>
        /// Gets the size of the modal.
        /// </summary>
        /// <returns></returns>
        private string GetModalSize()
        {
            string str = "";

            switch (this.Size)
            {
                case ModalSizes.Large:
                    str = "modal-lg";
                    break;

                case ModalSizes.Small:
                    str = "modal-sm";
                    break;

                default:
                    break;
            }

            return str.Trim();
        }

        /// <summary>
        /// Finds the control recursive.
        /// </summary>
        /// <param name="rootControl">The root control.</param>
        /// <param name="controlID">The control identifier.</param>
        /// <returns></returns>
        internal static Control FindControlRecursive(Control rootControl, string controlID)
        {
            if (rootControl.ID == controlID)
            {
                return rootControl;
            }

            foreach (Control controlToSearch in rootControl.Controls)
            {
                Control controlToReturn = Modal.FindControlRecursive(controlToSearch, controlID);
                if (controlToReturn != null)
                {
                    return controlToReturn;
                }
            }

            return null;
        }
    }
}
