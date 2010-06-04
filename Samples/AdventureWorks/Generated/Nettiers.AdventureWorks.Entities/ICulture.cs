﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'Culture' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ICulture 
	{
		/// <summary>			
		/// CultureID : Primary key for Culture records.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Culture"</remarks>
		System.String CultureId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalCultureId { get; set; }
			
		
		
		/// <summary>
		/// Name : Culture description.
		/// </summary>
		System.String  Name  { get; set; }
		
		/// <summary>
		/// ModifiedDate : Date and time the record was last updated.
		/// </summary>
		System.DateTime  ModifiedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _productModelProductDescriptionCultureCultureId
		/// </summary>	
		TList<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultureCollection {  get;  set;}	

		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the junction table productModelIdProductModelCollectionFromProductModelProductDescriptionCulture
		/// </summary>	
		TList<ProductModel> ProductModelIdProductModelCollection_From_ProductModelProductDescriptionCulture { get; set; }	

		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the junction table productDescriptionIdProductDescriptionCollectionFromProductModelProductDescriptionCulture
		/// </summary>	
		TList<ProductDescription> ProductDescriptionIdProductDescriptionCollection_From_ProductModelProductDescriptionCulture { get; set; }	

		#endregion Data Properties

	}
}


