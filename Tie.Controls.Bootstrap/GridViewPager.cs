using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tie.Controls.Bootstrap.Helpers;

namespace Tie.Controls.Bootstrap
{
    [ToolboxData("<{0}:GridViewPager runat=server></{0}:GridViewPager>")]
    public class GridViewPager : WebControl, INamingContainer, IPostBackDataHandler
    {
        private System.Web.UI.WebControls.GridView GridView;

        /// <summary>
        /// Occurs when [page index changed].
        /// </summary>
        public event EventHandler<PageChangedEventArgs> PageIndexChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="GridViewPager"/> class.
        /// </summary>
        public GridViewPager()
            : base()
        {
            
        }

        /// <summary>
        /// Gets or sets the grid view identifier.
        /// </summary>
        /// <value>
        /// The grid view identifier.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string GridViewID
        {
            get { return (string)ViewState["GridViewID"]; }
            set { ViewState["GridViewID"] = value; }
        }

        #region IPostBackDataHandler methods

        /// <summary>
        /// When implemented by a class, processes postback data for an ASP.NET server control.
        /// </summary>
        /// <param name="postDataKey">The key identifier for the control.</param>
        /// <param name="postCollection">The collection of all incoming name values.</param>
        /// <returns>
        /// true if the server control's state changes as a result of the postback; otherwise, false.
        /// </returns>
        public bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
        {
            if (!(postCollection["__EVENTTARGET"] == this.UniqueID))
            {
                return false;
            }

            int pageIndex = Convert.ToInt32(postCollection["__EVENTARGUMENT"]) - 1;

#if _4_0
            this.GridView.SetPageIndex(pageIndex);
#else
            this.GridView.PageIndex = pageIndex;
#endif
            return true;
        }

        /// <summary>
        /// When implemented by a class, signals the server control to notify the ASP.NET application that the state of the control has changed.
        /// </summary>
        public void RaisePostDataChangedEvent()
        {
            OnPageIndexChanged();
        }

        /// <summary>
        /// Called when [page index changed].
        /// </summary>
        private void OnPageIndexChanged()
        {
            if (PageIndexChanged != null)
                PageIndexChanged(this, new PageChangedEventArgs() { Index = this.GridView.PageIndex });
        }

        #endregion

        /// <summary>
        /// Gets the total pages.
        /// </summary>
        /// <returns></returns>
        private int GetTotalPages()
        {
            int intTotalRows = 0;

            if (this.GridView.DataSource is System.Data.DataSet)
            {
                System.Data.DataSet ds = (System.Data.DataSet)this.GridView.DataSource;

                if (String.IsNullOrEmpty(this.GridView.DataMember))
                {
                    intTotalRows = ds.Tables[0].Rows.Count;
                }
                else
                {
                    intTotalRows = ds.Tables[this.GridView.DataMember].Rows.Count;
                }
            }

            if (this.GridView.DataSource is System.Data.DataTable)
            {
               System.Data.DataTable dt  = (System.Data.DataTable)this.GridView.DataSource;
               intTotalRows = dt.Rows.Count;
            }

            if (this.GridView.DataSource is ICollection)
            {
                intTotalRows = ((ICollection)this.GridView.DataSource).Count;
            }

            return Convert.ToInt32(Math.Ceiling(Decimal.Divide((decimal)intTotalRows, (decimal)this.GridView.PageSize)));
        }

        /// <summary>
        /// Handles the PageIndexChanging event of the ctrl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="GridViewPageEventArgs"/> instance containing the event data.</param>
        void ctrl_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView.PageIndex = e.NewPageIndex;
            this.GridView.DataBind();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            this.GridView = ControlFinder.GetControlById(this.GridViewID) as System.Web.UI.WebControls.GridView;
            this.GridView.PageIndexChanging += ctrl_PageIndexChanging;

            if (this.GridView == null)
            {
                return;
            }

            this.Page.RegisterRequiresPostBack(this);
            base.OnInit(e);
        }

        /// <summary>
        /// Renders the contents.
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void RenderContents(HtmlTextWriter output)
        {
            for (int i = 0; i < GetTotalPages(); i++)
            {
                if (this.GridView.PageIndex == i)
                {
                    output.AddAttribute(HtmlTextWriterAttribute.Class, "active");
                }

                output.RenderBeginTag(HtmlTextWriterTag.Li);

                output.AddAttribute(HtmlTextWriterAttribute.Href, Page.ClientScript.GetPostBackClientHyperlink(this, (i + 1).ToString(), false));
                output.RenderBeginTag(HtmlTextWriterTag.A);
                output.Write((i + 1).ToString());
                output.RenderEndTag();

                output.RenderEndTag();
            }

            this.RenderChildren(output);
        }
       
        /// <summary>
        /// Renders the HTML opening tag of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.Ul);
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
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());

            base.Render(writer);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "pagination";

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str;
        }

    }
}
