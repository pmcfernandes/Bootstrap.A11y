using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tie.Controls.Bootstrap
{

    [ToolboxData("<{0}:Icon runat=server></{0}:Icon>")]
    [ToolboxBitmap(typeof(DropDownList))]
    public class Icon : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Icon"/> class.
        /// </summary>
        public Icon()
             : base()
        {
        }

        /// <summary>
        /// Gets or sets the icon string.
        /// </summary>
        /// <value>
        /// The icon string.
        /// </value>
        [Category("Appearance")]
        public string IconStr
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
            writer.AddAttribute(HtmlTextWriterAttribute.Class, IconStr);
            writer.RenderBeginTag(HtmlTextWriterTag.I);
        }

        /// <summary>
        /// Renders the HTML closing tag of the control into the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();
        }
    }
}
