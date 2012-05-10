using Shuffle.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections;

namespace Shuffle.Net.Test
{
    
    
    /// <summary>
    ///This is a test class for QuantumListTest and is intended
    ///to contain all QuantumListTest Unit Tests
    ///</summary>
	[TestClass()]
	public class QuantumListTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for QuantumList`1 Constructor
		///</summary>
		public void QuantumListConstructorTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>();
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		[TestMethod()]
		public void QuantumListConstructorTest()
		{
			QuantumListConstructorTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Add
		///</summary>
		public void AddTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			T item = default(T); // TODO: Initialize to an appropriate value
			target.Add(item);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		[TestMethod()]
		public void AddTest()
		{
			AddTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Add
		///</summary>
		public void AddTest1Helper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			T item = default(T); // TODO: Initialize to an appropriate value
			bool observed = false; // TODO: Initialize to an appropriate value
			target.Add(item, observed);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		[TestMethod()]
		public void AddTest1()
		{
			AddTest1Helper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Clear
		///</summary>
		public void ClearTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			target.Clear();
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		[TestMethod()]
		public void ClearTest()
		{
			ClearTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for ClearObservations
		///</summary>
		public void ClearObservationsTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			target.ClearObservations();
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		[TestMethod()]
		public void ClearObservationsTest()
		{
			ClearObservationsTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Contains
		///</summary>
		public void ContainsTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			T item = default(T); // TODO: Initialize to an appropriate value
			bool expected = false; // TODO: Initialize to an appropriate value
			bool actual;
			actual = target.Contains(item);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void ContainsTest()
		{
			ContainsTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for CopyTo
		///</summary>
		public void CopyToTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			T[] array = null; // TODO: Initialize to an appropriate value
			int arrayIndex = 0; // TODO: Initialize to an appropriate value
			target.CopyTo(array, arrayIndex);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		[TestMethod()]
		public void CopyToTest()
		{
			CopyToTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Get
		///</summary>
		public void GetTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			int index = 0; // TODO: Initialize to an appropriate value
			T expected = default(T); // TODO: Initialize to an appropriate value
			T actual;
			actual = target.Get(index);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void GetTest()
		{
			GetTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for GetEnumerator
		///</summary>
		public void GetEnumeratorTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			IEnumerator<T> expected = null; // TODO: Initialize to an appropriate value
			IEnumerator<T> actual;
			actual = target.GetEnumerator();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void GetEnumeratorTest()
		{
			GetEnumeratorTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for IndexOf
		///</summary>
		public void IndexOfTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			T item = default(T); // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			actual = target.IndexOf(item);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void IndexOfTest()
		{
			IndexOfTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Insert
		///</summary>
		public void InsertTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			int index = 0; // TODO: Initialize to an appropriate value
			T item = default(T); // TODO: Initialize to an appropriate value
			target.Insert(index, item);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		[TestMethod()]
		public void InsertTest()
		{
			InsertTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for RandomIntBetween
		///</summary>
		public void RandomIntBetweenTestHelper<T>()
		{
			int min = 0; // TODO: Initialize to an appropriate value
			int max = 0; // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			actual = QuantumList<T>.RandomIntBetween(min, max);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void RandomIntBetweenTest()
		{
			RandomIntBetweenTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Remove
		///</summary>
		public void RemoveTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			T item = default(T); // TODO: Initialize to an appropriate value
			bool expected = false; // TODO: Initialize to an appropriate value
			bool actual;
			actual = target.Remove(item);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void RemoveTest()
		{
			RemoveTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for RemoveAt
		///</summary>
		public void RemoveAtTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			int index = 0; // TODO: Initialize to an appropriate value
			target.RemoveAt(index);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		[TestMethod()]
		public void RemoveAtTest()
		{
			RemoveAtTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for System.Collections.IEnumerable.GetEnumerator
		///</summary>
		public void GetEnumeratorTest1Helper<T>()
		{
			IEnumerable target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			IEnumerator expected = null; // TODO: Initialize to an appropriate value
			IEnumerator actual;
			actual = target.GetEnumerator();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		[DeploymentItem("Shuffle.Net.dll")]
		public void GetEnumeratorTest1()
		{
			GetEnumeratorTest1Helper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Count
		///</summary>
		public void CountTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			int actual;
			actual = target.Count;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void CountTest()
		{
			CountTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for IsReadOnly
		///</summary>
		public void IsReadOnlyTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			bool actual;
			actual = target.IsReadOnly;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void IsReadOnlyTest()
		{
			IsReadOnlyTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Item
		///</summary>
		public void ItemTestHelper<T>()
		{
			QuantumList<T> target = new QuantumList<T>(); // TODO: Initialize to an appropriate value
			int i = 0; // TODO: Initialize to an appropriate value
			T expected = default(T); // TODO: Initialize to an appropriate value
			T actual;
			target[i] = expected;
			actual = target[i];
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void ItemTest()
		{
			ItemTestHelper<GenericParameterHelper>();
		}
	}
}
