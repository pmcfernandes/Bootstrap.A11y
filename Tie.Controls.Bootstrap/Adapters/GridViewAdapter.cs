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
        private System.Web.UI.WebControls.GridView GridView; 

        /// <summary>
        /// Initializes a new instance of the <see cref="GridViewAdapter"/> class.
        /// </summary>
        public GridViewAdapter()
        {
            this.GridView = ((System.Web.UI.WebControls.GridView)this.Control);
            this.GridView.GridLines = GridLines.None;
        }

        /// <summary>
        /// Overrides the <see cref="M:System.Web.UI.Control.OnPreRender(System.EventArgs)" /> method for the associated control.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnPreRender(EventArgs e)
        {
            this.GridView.UseAccessibleHeader = true;
            this.GridView.HeaderRow.TableSection = System.Web.UI.WebControls.TableRowSection.TableHeader;
            base.OnPreRender(e);
        }

        /// <summary>
        /// Creates the beginning tag for the Web control in the markup that is transmitted to the target browser.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> containing methods to render the target-specific output.</param>
        protected override void RenderBeginTag(System.Web.UI.HtmlTextWriter writer)
        {
            base.RenderBeginTag(writer);
            writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Class, "table" + (!String.IsNullOrEmpty(this.Control.CssClass) ? " " + this.Control.CssClass : ""));
        }
    }
}