﻿

/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file PurchaseOrderDetailTest.cs instead.
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
    /// Provides tests for the and <see cref="PurchaseOrderDetail"/> objects (entity, collection and repository).
    /// </summary>
   public partial class PurchaseOrderDetailTest
    {
    	// the PurchaseOrderDetail instance used to test the repository.
		protected PurchaseOrderDetail mock;
		
		// the TList<PurchaseOrderDetail> instance used to test the repository.
		protected TList<PurchaseOrderDetail> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the PurchaseOrderDetail Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock PurchaseOrderDetail entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PurchaseOrderDetailProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.PurchaseOrderDetailProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all PurchaseOrderDetail objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.PurchaseOrderDetailProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.PurchaseOrderDetailProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.PurchaseOrderDetailProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all PurchaseOrderDetail children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.PurchaseOrderDetailProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.PurchaseOrderDetailProvider.DeepLoading += new EntityProviderBaseCore<PurchaseOrderDetail, PurchaseOrderDetailKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.PurchaseOrderDetailProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("PurchaseOrderDetail instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.PurchaseOrderDetailProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock PurchaseOrderDetail entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PurchaseOrderDetail mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.PurchaseOrderDetailProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.PurchaseOrderDetailProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.PurchaseOrderDetailProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock PurchaseOrderDetail entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (PurchaseOrderDetail)CreateMockInstance(tm);
				DataRepository.PurchaseOrderDetailProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.PurchaseOrderDetailProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.PurchaseOrderDetailProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock PurchaseOrderDetail entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PurchaseOrderDetail.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock PurchaseOrderDetail entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PurchaseOrderDetail.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<PurchaseOrderDetail>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a PurchaseOrderDetail collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PurchaseOrderDetailCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<PurchaseOrderDetail> mockCollection = new TList<PurchaseOrderDetail>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<PurchaseOrderDetail> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a PurchaseOrderDetail collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_PurchaseOrderDetailCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<PurchaseOrderDetail>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<PurchaseOrderDetail> mockCollection = (TList<PurchaseOrderDetail>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<PurchaseOrderDetail> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PurchaseOrderDetail entity = CreateMockInstance(tm);
				bool result = DataRepository.PurchaseOrderDetailProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<PurchaseOrderDetail> t1 = DataRepository.PurchaseOrderDetailProvider.GetByPurchaseOrderId(tm, entity.PurchaseOrderId, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				PurchaseOrderDetail entity = CreateMockInstance(tm);
				bool result = DataRepository.PurchaseOrderDetailProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				TList<PurchaseOrderDetail> t0 = DataRepository.PurchaseOrderDetailProvider.GetByProductId(tm, entity.ProductId);
				PurchaseOrderDetail t1 = DataRepository.PurchaseOrderDetailProvider.GetByPurchaseOrderIdPurchaseOrderDetailId(tm, entity.PurchaseOrderId, entity.PurchaseOrderDetailId);
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
				
				PurchaseOrderDetail entity = mock.Copy() as PurchaseOrderDetail;
				entity = (PurchaseOrderDetail)mock.Clone();
				Assert.IsTrue(PurchaseOrderDetail.ValueEquals(entity, mock), "Clone is not working");
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
				PurchaseOrderDetail mock = CreateMockInstance(tm);
				bool result = DataRepository.PurchaseOrderDetailProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				PurchaseOrderDetailQuery query = new PurchaseOrderDetailQuery();
			
				query.AppendEquals(PurchaseOrderDetailColumn.PurchaseOrderId, mock.PurchaseOrderId.ToString());
				query.AppendEquals(PurchaseOrderDetailColumn.PurchaseOrderDetailId, mock.PurchaseOrderDetailId.ToString());
				query.AppendEquals(PurchaseOrderDetailColumn.DueDate, mock.DueDate.ToString());
				query.AppendEquals(PurchaseOrderDetailColumn.OrderQty, mock.OrderQty.ToString());
				query.AppendEquals(PurchaseOrderDetailColumn.ProductId, mock.ProductId.ToString());
				query.AppendEquals(PurchaseOrderDetailColumn.UnitPrice, mock.UnitPrice.ToString());
				query.AppendEquals(PurchaseOrderDetailColumn.ReceivedQty, mock.ReceivedQty.ToString());
				query.AppendEquals(PurchaseOrderDetailColumn.RejectedQty, mock.RejectedQty.ToString());
				query.AppendEquals(PurchaseOrderDetailColumn.ModifiedDate, mock.ModifiedDate.ToString());
				
				TList<PurchaseOrderDetail> results = DataRepository.PurchaseOrderDetailProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed PurchaseOrderDetail Entity with mock values.
		///</summary>
		static public PurchaseOrderDetail CreateMockInstance_Generated(TransactionManager tm)
		{		
			PurchaseOrderDetail mock = new PurchaseOrderDetail();
						
			mock.DueDate = TestUtility.Instance.RandomDateTime();
			mock.OrderQty = TestUtility.Instance.RandomShort();
			mock.UnitPrice = TestUtility.Instance.RandomShort();
			mock.ReceivedQty = (decimal)TestUtility.Instance.RandomShort();
			mock.RejectedQty = (decimal)TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();
			
			//OneToOneRelationship
			Product mockProductByProductId = ProductTest.CreateMockInstance(tm);
			DataRepository.ProductProvider.Insert(tm, mockProductByProductId);
			mock.ProductId = mockProductByProductId.ProductId;
			//OneToOneRelationship
			PurchaseOrderHeader mockPurchaseOrderHeaderByPurchaseOrderId = PurchaseOrderHeaderTest.CreateMockInstance(tm);
			DataRepository.PurchaseOrderHeaderProvider.Insert(tm, mockPurchaseOrderHeaderByPurchaseOrderId);
			mock.PurchaseOrderId = mockPurchaseOrderHeaderByPurchaseOrderId.PurchaseOrderId;
		
			// create a temporary collection and add the item to it
			TList<PurchaseOrderDetail> tempMockCollection = new TList<PurchaseOrderDetail>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (PurchaseOrderDetail)mock;
		}
		
		
		///<summary>
		///  Update the Typed PurchaseOrderDetail Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, PurchaseOrderDetail mock)
		{
			mock.DueDate = TestUtility.Instance.RandomDateTime();
			mock.OrderQty = TestUtility.Instance.RandomShort();
			mock.UnitPrice = TestUtility.Instance.RandomShort();
			mock.ReceivedQty = (decimal)TestUtility.Instance.RandomShort();
			mock.RejectedQty = (decimal)TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();
			
			//OneToOneRelationship
			Product mockProductByProductId = ProductTest.CreateMockInstance(tm);
			DataRepository.ProductProvider.Insert(tm, mockProductByProductId);
			mock.ProductId = mockProductByProductId.ProductId;
					
			//OneToOneRelationship
			PurchaseOrderHeader mockPurchaseOrderHeaderByPurchaseOrderId = PurchaseOrderHeaderTest.CreateMockInstance(tm);
			DataRepository.PurchaseOrderHeaderProvider.Insert(tm, mockPurchaseOrderHeaderByPurchaseOrderId);
			mock.PurchaseOrderId = mockPurchaseOrderHeaderByPurchaseOrderId.PurchaseOrderId;
					
		}
		#endregion
    }
}
