// NavBar.cs

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
    public enum Position
    {
        None = 0,
        Top = 1,
        Bottom = 2
    }

    [ToolboxData("<{0}:NavBar runat=server></{0}:NavBar>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Menu))]
    [ParseChildren(true)]
    [PersistChildren(false)]
    public class NavBar : WebControl, INamingContainer
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NavBar" /> class.
        /// </summary>
        public NavBar()
            : base()
        {
            this.Position = Position.None;
            this.Inverted = true;
            this.Fixed = false;
        }

        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        /// <value>
        /// The brand.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(NavBar))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Brand
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the content of the left.
        /// </summary>
        /// <value>
        /// The content of the left.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(NavBar))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate LeftContent
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the content of the right.
        /// </summary>
        /// <value>
        /// The content of the right.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(NavBar))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate RightContent
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(Position.None)]
        public Position Position
        {
            get { return (Position)ViewState["Position"]; }
            set { ViewState["Position"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NavBar" /> is inverted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if inverted; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Inverted
        {
            get { return (bool)ViewState["Inverted"]; }
            set { ViewState["Inverted"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NavBar" /> is fixed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if fixed; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Fixed
        {
            get { return (bool)ViewState["Fixed"]; }
            set { ViewState["Fixed"] = value; }
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

            base.Render(writer);
        }

        /// <summary>
        /// Renders the contents.
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void RenderContents(HtmlTextWriter output)
        {
            output.AddAttribute(HtmlTextWriterAttribute.Class, "container-fluid");
            output.RenderBeginTag(HtmlTextWriterTag.Div);
           
            this.RenderChildren(output);

            output.RenderEndTag(); // Close Div   
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
            this.Controls.Clear();

            if (this.Brand != null)
            {
                var brandItem = new Control();
                this.Brand.InstantiateIn(brandItem);
                this.Controls.Add(brandItem);
            }

            if (this.LeftContent != null)
            {
                var leftItem = new Control();
                leftItem.ID = "navbar-left";
                this.LeftContent.InstantiateIn(leftItem);
                this.Controls.Add(leftItem);
            }

            if (this.RightContent != null)
            {
                var rightItem = new Control();
                rightItem.ID = "navbar-right";
                this.RightContent.InstantiateIn(rightItem);
                this.Controls.Add(rightItem);
            }
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "navbar";

            if (this.Inverted)
            {
                str += " navbar-inverse";
            }
            else
            {
                str += " navbar-default";
            }
           
            switch (this.Position)
            {
                case Position.Top:
                    str += " navbar-" + (this.Fixed ? "fixed" : "static") + "-top";
                    break;

                case Position.Bottom:
                    str += " navbar-" + (this.Fixed ? "fixed" : "static") + "-bottom";
                    break;

                default:
                    break;
            }

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }
    }
}
