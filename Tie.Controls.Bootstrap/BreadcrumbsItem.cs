using System;
using System.ComponentModel;
using System.Web.UI;

namespace Tie.Controls.Bootstrap
{
    [ToolboxData("<{0}:BreadcrumbsItem runat=server></{0}:BreadcrumbsItem>")]
    [ToolboxItem(false)]
    public class BreadcrumbsItem:Control, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbsItem"/> class.
        /// </summary>
        public BreadcrumbsItem()
            : base()
        {
            this.Text = "";
            this.NavigateUrl = "#";
        }

         /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("")]
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the navigate URL.
        /// </summary>
        /// <value>
        /// The navigate URL.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue("#")]
        [UrlProperty]
        public string NavigateUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Sends server control content to a provided <see cref="T:System.Web.UI.HtmlTextWriter" /> object, which writes the content to be rendered on the client.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the server control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            if (!String.IsNullOrEmpty(this.NavigateUrl))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Href, ResolveClientUrl(this.NavigateUrl));
                writer.RenderBeginTag(HtmlTextWriterTag.A);
            }

            writer.Write(this.Text);

            if (!String.IsNullOrEmpty(this.NavigateUrl))
            {
                writer.RenderEndTag();
            }
        }
    }
}
