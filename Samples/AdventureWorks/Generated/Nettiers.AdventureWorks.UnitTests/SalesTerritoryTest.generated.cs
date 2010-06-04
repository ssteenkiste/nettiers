﻿

/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file SalesTerritoryTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;
using Nettiers.AdventureWorks.Data.Bases;

#endregion

namespace Nettiers.AdventureWorks.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="SalesTerritory"/> objects (entity, collection and repository).
    /// </summary>
   public partial class SalesTerritoryTest
    {
    	// the SalesTerritory instance used to test the repository.
		protected SalesTerritory mock;
		
		// the TList<SalesTerritory> instance used to test the repository.
		protected TList<SalesTerritory> mockCollection;
		
		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the SalesTerritory Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   		
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }
    
    
		/// <summary>
		/// Inserts a mock SalesTerritory entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SalesTerritoryProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.SalesTerritoryProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all SalesTerritory objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.SalesTerritoryProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.SalesTerritoryProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.SalesTerritoryProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all SalesTerritory children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.SalesTerritoryProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.SalesTerritoryProvider.DeepLoading += new EntityProviderBaseCore<SalesTerritory, SalesTerritoryKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.SalesTerritoryProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("SalesTerritory instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.SalesTerritoryProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock SalesTerritory entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SalesTerritory mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SalesTerritoryProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.SalesTerritoryProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.SalesTerritoryProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock SalesTerritory entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (SalesTerritory)CreateMockInstance(tm);
				DataRepository.SalesTerritoryProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.SalesTerritoryProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.SalesTerritoryProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock SalesTerritory entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SalesTerritory.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock SalesTerritory entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SalesTerritory.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<SalesTerritory>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a SalesTerritory collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SalesTerritoryCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<SalesTerritory> mockCollection = new TList<SalesTerritory>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<SalesTerritory> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a SalesTerritory collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SalesTerritoryCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<SalesTerritory>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<SalesTerritory> mockCollection = (TList<SalesTerritory>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<SalesTerritory> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SalesTerritory entity = CreateMockInstance(tm);
				bool result = DataRepository.SalesTerritoryProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SalesTerritory entity = CreateMockInstance(tm);
				bool result = DataRepository.SalesTerritoryProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				SalesTerritory t0 = DataRepository.SalesTerritoryProvider.GetByName(tm, entity.Name);
				SalesTerritory t1 = DataRepository.SalesTerritoryProvider.GetByRowguid(tm, entity.Rowguid);
				SalesTerritory t2 = DataRepository.SalesTerritoryProvider.GetByTerritoryId(tm, entity.TerritoryId);
			}
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				SalesTerritory entity = mock.Copy() as SalesTerritory;
				entity = (SalesTerritory)mock.Clone();
				Assert.IsTrue(SalesTerritory.ValueEquals(entity, mock), "Clone is not working");
			}
		}
		
		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				SalesTerritory mock = CreateMockInstance(tm);
				bool result = DataRepository.SalesTerritoryProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				SalesTerritoryQuery query = new SalesTerritoryQuery();
			
				query.AppendEquals(SalesTerritoryColumn.TerritoryId, mock.TerritoryId.ToString());
				query.AppendEquals(SalesTerritoryColumn.Name, mock.Name.ToString());
				query.AppendEquals(SalesTerritoryColumn.CountryRegionCode, mock.CountryRegionCode.ToString());
				query.AppendEquals(SalesTerritoryColumn.Group, mock.Group.ToString());
				query.AppendEquals(SalesTerritoryColumn.SalesYtd, mock.SalesYtd.ToString());
				query.AppendEquals(SalesTerritoryColumn.SalesLastYear, mock.SalesLastYear.ToString());
				query.AppendEquals(SalesTerritoryColumn.CostYtd, mock.CostYtd.ToString());
				query.AppendEquals(SalesTerritoryColumn.CostLastYear, mock.CostLastYear.ToString());
				query.AppendEquals(SalesTerritoryColumn.Rowguid, mock.Rowguid.ToString());
				query.AppendEquals(SalesTerritoryColumn.ModifiedDate, mock.ModifiedDate.ToString());
				
				TList<SalesTerritory> results = DataRepository.SalesTerritoryProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed SalesTerritory Entity with mock values.
		///</summary>
		static public SalesTerritory CreateMockInstance_Generated(TransactionManager tm)
		{		
			SalesTerritory mock = new SalesTerritory();
						
			mock.Name = TestUtility.Instance.RandomString(24, false);;
			mock.CountryRegionCode = TestUtility.Instance.RandomString(3, false);;
			mock.Group = TestUtility.Instance.RandomString(24, false);;
			mock.SalesYtd = TestUtility.Instance.RandomShort();
			mock.SalesLastYear = TestUtility.Instance.RandomShort();
			mock.CostYtd = TestUtility.Instance.RandomShort();
			mock.CostLastYear = TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();
			
		
			// create a temporary collection and add the item to it
			TList<SalesTerritory> tempMockCollection = new TList<SalesTerritory>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (SalesTerritory)mock;
		}
		
		
		///<summary>
		///  Update the Typed SalesTerritory Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, SalesTerritory mock)
		{
			mock.Name = TestUtility.Instance.RandomString(24, false);;
			mock.CountryRegionCode = TestUtility.Instance.RandomString(3, false);;
			mock.Group = TestUtility.Instance.RandomString(24, false);;
			mock.SalesYtd = TestUtility.Instance.RandomShort();
			mock.SalesLastYear = TestUtility.Instance.RandomShort();
			mock.CostYtd = TestUtility.Instance.RandomShort();
			mock.CostLastYear = TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();
			
		}
		#endregion
    }
}
