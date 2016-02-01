using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;

namespace Tie.Controls.Bootstrap.Adapters
{
    public class GridViewAdapter : WebControlAdapter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridViewAdapter"/> class.
        /// </summary>
        public GridViewAdapter()
        {

        }

        /// <summary>
        /// Creates the beginning tag for the Web control in the markup that is transmitted to the target browser.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> containing methods to render the target-specific output.</param>
        protected override void RenderBeginTag(System.Web.UI.HtmlTextWriter writer)
        {
            ((System.Web.UI.WebControls.GridView)this.Control).GridLines = GridLines.None;

            base.RenderBeginTag(writer);
            writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Class, "table" + (!String.IsNullOrEmpty(this.Control.CssClass) ? " " + this.Control.CssClass : ""));
        }
    }
}