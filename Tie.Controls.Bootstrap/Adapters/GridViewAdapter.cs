using System;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;

namespace Tie.Controls.Bootstrap.Adapters
{
    public class GridViewAdapter : WebControlAdapter
    {
        private System.Web.UI.WebControls.GridView gridView; 

        /// <summary>
        /// Overrides the <see cref="M:System.Web.UI.Control.OnPreRender(System.EventArgs)" /> method for the associated control.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnPreRender(EventArgs e)
        {
            gridView = this.Control as System.Web.UI.WebControls.GridView; 

            if (gridView != null)
            {
                gridView.GridLines = GridLines.None;
                gridView.UseAccessibleHeader = true;

                if (gridView.HeaderRow != null) gridView.HeaderRow.TableSection = TableRowSection.TableHeader;
                if (gridView.FooterRow != null) gridView.FooterRow.TableSection = TableRowSection.TableFooter;
                if (gridView.BottomPagerRow != null) gridView.BottomPagerRow.TableSection = TableRowSection.TableFooter;
                if (gridView.TopPagerRow != null) gridView.TopPagerRow.TableSection = TableRowSection.TableHeader;
            }

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