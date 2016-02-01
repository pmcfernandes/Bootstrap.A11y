using System;
using System.Collections.Generic;
using System.Text;

namespace Tie.Controls.Bootstrap
{
    public interface IListItem
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        string Text { get; set; }

        /// <summary>
        /// Gets or sets the navigate URL.
        /// </summary>
        /// <value>
        /// The navigate URL.
        /// </value>
        string NavigateUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IListItem"/> is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        bool Enabled { get; set; }
    }
}
