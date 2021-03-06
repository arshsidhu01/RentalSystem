﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_spGetAllCustomerTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_spGetAllVideosTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition2;
            this.dbo_spGetAllCustomerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_spGetAllVideosTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_spGetAllCustomerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_spGetAllVideosTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            checksumCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            // 
            // dbo_spGetAllCustomerTest_TestAction
            // 
            dbo_spGetAllCustomerTest_TestAction.Conditions.Add(checksumCondition1);
            resources.ApplyResources(dbo_spGetAllCustomerTest_TestAction, "dbo_spGetAllCustomerTest_TestAction");
            // 
            // dbo_spGetAllVideosTest_TestAction
            // 
            dbo_spGetAllVideosTest_TestAction.Conditions.Add(checksumCondition2);
            resources.ApplyResources(dbo_spGetAllVideosTest_TestAction, "dbo_spGetAllVideosTest_TestAction");
            // 
            // dbo_spGetAllCustomerTestData
            // 
            this.dbo_spGetAllCustomerTestData.PosttestAction = null;
            this.dbo_spGetAllCustomerTestData.PretestAction = null;
            this.dbo_spGetAllCustomerTestData.TestAction = dbo_spGetAllCustomerTest_TestAction;
            // 
            // dbo_spGetAllVideosTestData
            // 
            this.dbo_spGetAllVideosTestData.PosttestAction = null;
            this.dbo_spGetAllVideosTestData.PretestAction = null;
            this.dbo_spGetAllVideosTestData.TestAction = dbo_spGetAllVideosTest_TestAction;
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "2010718385";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // checksumCondition2
            // 
            checksumCondition2.Checksum = "219765096";
            checksumCondition2.Enabled = true;
            checksumCondition2.Name = "checksumCondition2";
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_spGetAllCustomerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_spGetAllCustomerTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_spGetAllVideosTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_spGetAllVideosTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_spGetAllCustomerTestData;
        private SqlDatabaseTestActions dbo_spGetAllVideosTestData;
    }
}
