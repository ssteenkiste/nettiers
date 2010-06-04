﻿	

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;
using System.ServiceModel;

using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Entities.Validation;

using Nettiers.AdventureWorks.Data;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace Nettiers.AdventureWorks.Contracts.Services
{		
	/// <summary>
	/// An interface type implementation of the 'ProductModel' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[ServiceContract]
	public partial interface IProductModelService : Nettiers.AdventureWorks.Contracts.Services.IProductModelServiceBase
	{
				
	}//End Class

} // end namespace
