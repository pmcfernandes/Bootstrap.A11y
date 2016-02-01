// Popover.cs

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
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tie.Controls.Bootstrap
{
    [ToolboxData("<{0}:Popover runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Label))]
    [DefaultProperty("Text")]
    public class Popover : WebControl, INamingContainer
    {
        public Popover()
            : base()
        {
            this.Position = Bootstrap.Position.Bottom;
            this.Title = "";
            this.Text = "";
        }

        [Category("Behavior")]
        [DefaultValue("")]
        public string Title
        {
            get { return (string)ViewState["Title"]; }
            set { ViewState["Title"] = value; }
        }

        [Category("Behavior")]
        [DefaultValue("")]
        public string Text
        {
            get { return (string)ViewState["Text"]; }
            set { ViewState["Text"] = value; }
        }

        [Category("Appearance")]
        [DefaultValue(Position.Bottom)]
        public Position Position
        {
            get { return (Position)ViewState["Position"]; }
            set { ViewState["Position"] = value; }
        }
        
    }
}
