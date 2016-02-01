// ButtonAdapter.cs

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
using System.Web.UI.WebControls.Adapters;

namespace Tie.Controls.Bootstrap.Adapters
{
    public class ButtonAdapter : WebControlAdapter
    {
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Class, "btn btn-default" + (!String.IsNullOrEmpty(this.Control.CssClass) ? " " + this.Control.CssClass : ""));
            base.Render(writer);
        }
    }
}
