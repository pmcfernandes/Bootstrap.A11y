// Dropdown.cs

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
    [ToolboxData("<{0}:Dropdown runat=server></{0}:Dropdown>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.DropDownList))]
    [ParseChildren(true, "Items")]
    [PersistChildren(false)]
    public class Dropdown : WebControl, INamingContainer
    {
        private ListItemCollection _items;

        /// <summary>
        /// Initializes a new instance of the <see cref="DropdownMenu" /> class.
        /// </summary>
        public Dropdown()
            : base()
        {
            this._items = new ListItemCollection();
            this.RightToLeft = false;
            this.DropUp = false;
            this.Text = "";
        }

        /// <summary>
        /// Gets or sets the type of the alert.
        /// </summary>
        /// <value>
        /// The type of the alert.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool RightToLeft
        {
            get { return (bool)ViewState["RightToLeft"]; }
            set { ViewState["RightToLeft"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [drop up].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [drop up]; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool DropUp
        {
            get { return (bool)ViewState["DropUp"]; }
            set { ViewState["DropUp"] = value; }
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Text
        {
            get { return (string)ViewState["Text"]; }
            set { ViewState["Text"] = value; }
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public ListItemCollection Items
        {
            get { return _items; }
        }

        /// <summary>
        /// Renders the HTML opening tag of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "btn btn-default dropdown-toggle");
            writer.AddAttribute("type", "button");
            writer.AddAttribute("data-toggle", "dropdown");
            writer.AddAttribute("aria-haspopup", "true");
            writer.AddAttribute("aria-expanded", "true");
            writer.RenderBeginTag(HtmlTextWriterTag.Button);
            writer.Write(this.Text);

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "caret");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag(); // Span

            writer.RenderEndTag(); // Button

            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCssInternal());
            writer.RenderBeginTag(HtmlTextWriterTag.Ul);
        }

        /// <summary>
        /// Renders the HTML closing tag of the control into the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();
            writer.RenderEndTag();
        }

        /// <summary>
        /// Writes the <see cref="T:System.Web.UI.WebControls.BulletedList" /> control content to the specified <see cref="T:System.Web.UI.HtmlTextWriter" /> object for display on the client.
        /// </summary>
        /// <param name="writer">An <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);
        }

        /// <summary>
        /// Notifies the server control that an element, either XML or HTML, was parsed, and adds the element to the server control's <see cref="T:System.Web.UI.ControlCollection" /> object.
        /// </summary>
        /// <param name="obj">An <see cref="T:System.Object" /> that represents the parsed element.</param>
        protected override void AddParsedSubObject(object obj)
        {
            if (obj is ListItem || obj is ListHeader | obj is ListSeparator)
            {
                Items.Add((IListItem)obj);
                return;
            }
        }       

        /// <summary>
        /// Renders the list items of a <see cref="T:System.Web.UI.WebControls.BulletedList" /> control as bullets into the specified <see cref="T:System.Web.UI.HtmlTextWriter" />.
        /// </summary>
        /// <param name="writer">An <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            foreach (Control item in this.Items)
            {
                item.RenderControl(writer);              
            }            
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = (this.DropUp ? "dropup" : "dropdown");

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }

        /// <summary>
        /// Builds the CSS internal.
        /// </summary>
        /// <returns></returns>
        private string BuildCssInternal()
        {
            string str = "dropdown-menu";

            if (this.RightToLeft == true)
            {
                str += " dropdown-menu-right";
            }

            return str.Trim();
        }

        /// <summary>
        /// Gets a <see cref="T:System.Web.UI.ControlCollection" /> object that represents the child controls for a specified server control in the UI hierarchy.
        /// </summary>
        public override ControlCollection Controls
        {
            get
            {
                this.EnsureChildControls();
                return base.Controls;
            }
        }
    }
}
