using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Tie.Controls.Bootstrap
{
    public enum Size
    {
        Default = 0,
        Large = 1,
        Small = 2
    }

    [ToolboxData("<{0}:Well runat=server></{0}:Well>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Label))]
    public class Well : System.Web.UI.WebControls.Label, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Well"/> class.
        /// </summary>
        public Well()
            : base()
        {
            this.Size = Size.Default;
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(Size.Default)]
        public Size Size
        {
            get { return (Size)ViewState["Size"]; }
            set { ViewState["Size"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            base.Render(writer);
        }

        /// <summary>
        /// Renders the contents of the <see cref="T:System.Web.UI.WebControls.Label" /> into the specified writer.
        /// </summary>
        /// <param name="writer">The output stream that renders HTML content to the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            base.RenderContents(writer);
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
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "well";
            str += " " + this.GetCssSize();

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }

        /// <summary>
        /// Gets the type of the CSS button.
        /// </summary>
        /// <returns></returns>
        private string GetCssSize()
        {
            string str = "";

            switch (this.Size)
            {
                case Size.Large:
                    str = "well-lg";
                    break;

                case Size.Small:
                    str = "well-sm";
                    break;

                default:
                    str = "";
                    break;
            }

            return str;
        }
    }
}
