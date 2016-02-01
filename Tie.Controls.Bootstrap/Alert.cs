// Alert.cs

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

    public enum AlertTypes
    {
        Warning = 0,
        Danger = 1,
        Success = 2,
        Info = 3
    }

    [ToolboxData("<{0}:Alert runat=server></{0}:Alert>")]
    [DefaultProperty("CssClass")]
    [ParseChildren(true, "Content")]
    [PersistChildren(true)]
    public class Alert : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        public Alert()
            : base()
        {
            this.AlertType = AlertTypes.Danger;
            this.Dismissible = false;
        }

        /// <summary>
        /// Gets or sets the type of the alert.
        /// </summary>
        /// <value>
        /// The type of the alert.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(AlertTypes.Warning)]
        public AlertTypes AlertType
        {
            get { return (AlertTypes)ViewState["AlertType"]; }
            set { ViewState["AlertType"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Alert"/> is dismissible.
        /// </summary>
        /// <value>
        ///   <c>true</c> if dismissible; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Dismissible
        {
            get { return (bool)ViewState["Dismissible"]; }
            set { ViewState["Dismissible"] = value; }
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Alert))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
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
            writer.AddAttribute("role", "alert");
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
            if (this.Dismissible == true)
            {
                output.AddAttribute(HtmlTextWriterAttribute.Class, "close");
                output.AddStyleAttribute("type", "button");
                output.AddStyleAttribute("data-dismiss", "alert");
                output.RenderBeginTag(HtmlTextWriterTag.Button);

                output.RenderBeginTag(HtmlTextWriterTag.Span);
                output.Write("&times;");

                output.RenderEndTag(); // Span
                output.RenderEndTag(); // Button
            }

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
            this.Content.InstantiateIn(container);

            this.Controls.Clear();
            this.Controls.Add(container);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "alert";
            str += " " + this.GetAlertType();

            if (this.Dismissible == true)
            {
                str += " alert-dismissible";
            }

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }


        /// <summary>
        /// Gets the type of the alert.
        /// </summary>
        /// <returns></returns>
        private string GetAlertType()
        {
            string str = "";

            switch (this.AlertType)
            {
                case AlertTypes.Success:
                    str = "alert-success";
                    break;

                case AlertTypes.Warning:
                    str = "alert-warning";
                    break;

                case AlertTypes.Danger:
                    str = "alert-danger";
                    break;

                case AlertTypes.Info:
                    str = "alert-info";
                    break;

                default:
                    str = "";
                    break;
            }

            return str.Trim();
        }
    }
}