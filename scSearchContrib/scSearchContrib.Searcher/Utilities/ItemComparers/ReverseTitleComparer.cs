﻿//------------------------------------------------------------------------------------------------- 
// <copyright file="ReverseTitleComparer.cs" company="Sitecore Shared Source">
// Copyright (c) Sitecore.  All rights reserved.
// </copyright>
// <summary>
// Defines the Sitecore.Sharedsource.Data.Comparers.ItemComparers.ReverseTitleComparer type.
// </summary>
// <license>
// http://sdn.sitecore.net/Resources/Shared%20Source/Shared%20Source%20License.aspx
// </license>
// <url>http://trac.sitecore.net/FieldValueComparer/</url>
//-------------------------------------------------------------------------------------------------

namespace Sitecore.SharedSource.Data.Comparers.ItemComparers
{
	/// <summary>
	/// Example sublcass of Sitecore.Sharedsource.Data.Comparers.ItemComparers.TitleComparer
	/// to reverse the sort order.
	/// </summary>
	public class ReverseTitleComparer : Sitecore.SharedSource.Data.Comparers.ItemComparers.TitleComparer
	{
		/// <summary>
		/// Compare the two items in reverse order.
		/// </summary>
		/// <param name="firstItem">The first item to compare.</param>
		/// <param name="secondItem">The second item to compare.</param>
		/// <returns>
		/// 1 if the first item sorts before the second, 0 if the items sort equivalently,
		/// or -1 if the first item sorts after the second.
		/// </returns>
		public override int Compare(
		  Sitecore.Data.Items.Item firstItem,
		  Sitecore.Data.Items.Item secondItem)
		{
			Sitecore.Diagnostics.Assert.IsNotNull(firstItem, "firstItem");
			Sitecore.Diagnostics.Assert.IsNotNull(secondItem, "secondItem");
			return base.Compare(firstItem, secondItem) * -1;
		}
	}
}
