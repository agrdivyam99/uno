﻿using System.Collections.Generic;

namespace Windows.UI.Xaml.Controls
{
	public interface ISelector : IItemsControl
	{
		object SelectedItem { 
			get;
			set;
		}
		/*
		object SelectedValue { 
			get;
			set;
		}

		string SelectedValuePath { 
			get;
			set;
		}
		*/
		event SelectionChangedEventHandler SelectionChanged;
	}
	//
	public delegate void SelectionChangedEventHandler (object sender, SelectionChangedEventArgs e);
	//
	public partial class SelectionChangedEventArgs : RoutedEventArgs
	{
		public SelectionChangedEventArgs(object originalSource, IList<object> removedItems, IList<object> addedItems)
			: base(originalSource)
		{
			RemovedItems = removedItems;
			AddedItems = addedItems;
		}

		public IList<object> RemovedItems { 
			get;
			private set;
		}

		public IList<object> AddedItems { 
			get;
			private set;
		}
	}
}

