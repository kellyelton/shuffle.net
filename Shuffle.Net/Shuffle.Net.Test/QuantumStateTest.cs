using Shuffle.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Shuffle.Net.Test
{
    
    
    /// <summary>
    ///This is a test class for QuantumStateTest and is intended
    ///to contain all QuantumStateTest Unit Tests
    ///</summary>
	[TestClass()]
	public class QuantumStateTest
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
		///A test for QuantumState`1 Constructor
		///</summary>
		public void QuantumStateConstructorTestHelper<T>()
		{
			T item = default(T); // TODO: Initialize to an appropriate value
			bool observed = false; // TODO: Initialize to an appropriate value
			QuantumState<T> target = new QuantumState<T>(item, observed);
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		[TestMethod()]
		public void QuantumStateConstructorTest()
		{
			QuantumStateConstructorTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Item
		///</summary>
		public void ItemTestHelper<T>()
		{
			T item = default(T); // TODO: Initialize to an appropriate value
			bool observed = false; // TODO: Initialize to an appropriate value
			QuantumState<T> target = new QuantumState<T>(item, observed); // TODO: Initialize to an appropriate value
			T expected = default(T); // TODO: Initialize to an appropriate value
			T actual;
			target.Item = expected;
			actual = target.Item;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void ItemTest()
		{
			ItemTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Observed
		///</summary>
		public void ObservedTestHelper<T>()
		{
			T item = default(T); // TODO: Initialize to an appropriate value
			bool observed = false; // TODO: Initialize to an appropriate value
			QuantumState<T> target = new QuantumState<T>(item, observed); // TODO: Initialize to an appropriate value
			bool expected = false; // TODO: Initialize to an appropriate value
			bool actual;
			target.Observed = expected;
			actual = target.Observed;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void ObservedTest()
		{
			ObservedTestHelper<GenericParameterHelper>();
		}
	}
}
