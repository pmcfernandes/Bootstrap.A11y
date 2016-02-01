// ListItemCollection.cs

// Copyright (C) 2013 Pedro Fernandes

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Tie.Controls.Bootstrap
{
    public class ListItemCollection : CollectionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TabCollection" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public ListItemCollection()
            : base()
        {
            
        }

        /// <summary>
        /// Indexer property for the collection that returns and sets an item
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public IListItem this[int index]
        {
            get { return (IListItem)List[index]; }
            set { List[index] = value; }
        }

        /// <summary>
        /// Adds the specified tab.
        /// </summary>
        /// <param name="Tab">The tab.</param>
        public void Add(IListItem item)
        {
            List.Add(item);
        }

        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="item">The item.</param>
        public void Insert(int index, IListItem item)
        {
            List.Insert(index, item);
        }

        /// <summary>
        /// Removes the specified tab.
        /// </summary>
        /// <param name="Tab">The tab.</param>
        public void Remove(IListItem item)
        {
            List.Remove(item);
        }

        /// <summary>
        /// Determines whether [contains] [the specified tab].
        /// </summary>
        /// <param name="Tab">The tab.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified tab]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(IListItem item)
        {
            return List.Contains(item);
        }

        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public int IndexOf(IListItem item)
        {
            return List.IndexOf(item);
        }

        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        public void CopyTo(IListItem[] array, int index)
        {
            List.CopyTo(array, index);
        }
    }
}