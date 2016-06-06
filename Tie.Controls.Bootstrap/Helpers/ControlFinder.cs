using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Tie.Controls.Bootstrap.Helpers
{
    class ControlFinder
    {
        /// <summary>
        /// Gets the control by identifier.
        /// </summary>
        /// <param name="controlId">The control identifier.</param>
        /// <returns></returns>
        public static object GetControlById(string controlId)
        {
            Page page = (Page)System.Web.HttpContext.Current.Handler;

            foreach (Control container in page.Controls)
            {
                foreach (Control item in ControlFinder.GetAllControls(container))
                {
                    if (item.ID == controlId)
                    {
                        return item;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Gets all controls.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        public static Control[] GetAllControls(Control container)
        {
            ArrayList al = new ArrayList();
            foreach (Control ctl in container.Controls)
            {
                GetAllControlsHelper(ctl, al);
            }

            return (Control[])al.ToArray(typeof(Control));
        }

        /// <summary>
        /// Gets all controls helper.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="al">The al.</param>
        public static void GetAllControlsHelper(Control container, ArrayList al)
        {
            // add this control to the ArrayList 
            al.Add(container);

            // add all its child controls, by calling this routine recursively 
            foreach (Control ctl in container.Controls)
            {
                GetAllControlsHelper(ctl, al);
            }
        }
    }
}
