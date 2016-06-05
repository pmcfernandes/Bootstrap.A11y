using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web.UI;

namespace Tie.Controls.Bootstrap
{
    public class GridView : System.Web.UI.WebControls.GridView
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GridView"/> class.
        /// </summary>
        public GridView()
        {
            this.GridLines = System.Web.UI.WebControls.GridLines.None;
            this.Condensed = false;
            this.HoverRow = false;
            this.Stripped = false;
            this.Responsive = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GridView"/> is condensed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if condensed; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Condensed
        {
            get { return (bool)ViewState["Condensed"]; }
            set { ViewState["Condensed"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [hover row].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [hover row]; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool HoverRow
        {
            get { return (bool)ViewState["HoverRow"]; }
            set { ViewState["HoverRow"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GridView"/> is stripped.
        /// </summary>
        /// <value>
        ///   <c>true</c> if stripped; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Stripped
        {
            get { return (bool)ViewState["Stripped"]; }
            set { ViewState["Stripped"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GridView"/> is responsive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if responsive; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Responsive
        {
            get { return (bool)ViewState["Responsive"]; }
            set { ViewState["Responsive"] = value; }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnPreRender(EventArgs e)
        {
            this.UseAccessibleHeader = true;
            this.HeaderRow.TableSection = System.Web.UI.WebControls.TableRowSection.TableHeader;
            base.OnPreRender(e);
        }

        /// <summary>
        /// Renders the Web server control content to the client's browser using the specified <see cref="T:System.Web.UI.HtmlTextWriter" /> object.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> used to render the server control content on the client's browser.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            if (this.Responsive == true)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "table-responsive");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
            }

            base.Render(writer);

            if (this.Responsive == true)
            {
                writer.RenderEndTag();
            }
        }

        /// <summary>
        /// Renders the contents of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            base.RenderContents(writer);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "table";

            if (this.Condensed == true)
            {
                str += " table-condensed";
            }

            if (this.HoverRow == true)
            {
                str += " table-hover";
            }

            if (this.Stripped == true)
            {
                str += " table-striped";
            }

            if (this.GridLines != System.Web.UI.WebControls.GridLines.None)
            {
                this.GridLines = System.Web.UI.WebControls.GridLines.None;
                str += " table-bordered";
            }

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }
    }
}
