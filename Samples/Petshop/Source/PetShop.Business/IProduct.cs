﻿using System;
using System.ComponentModel;

namespace PetShop.Business
{
	/// <summary>
	///		The data structure representation of the 'Product' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IProduct 
	{
		/// <summary>			
		/// ProductId : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Product"</remarks>
		string ProductId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		string OriginalProductId { get; set; }
			
		
		
		/// <summary>
		/// CategoryId : 
		/// </summary>
		string  CategoryId  { get; set; }
		
		/// <summary>
		/// Name : 
		/// </summary>
		string  Name  { get; set; }
		
		/// <summary>
		/// Descn : 
		/// </summary>
		string  Descn  { get; set; }
		
		/// <summary>
		/// Image : 
		/// </summary>
		string  Image  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _itemProductId
		/// </summary>	
		TList<Item> ItemCollection {  get;  set;}	

		#endregion Data Properties

	}
}


