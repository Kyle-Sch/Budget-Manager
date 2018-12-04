using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Transactions;
using Budget_Manager.DAL;
using Budget_Manager.Models;
namespace BudgetManagerTestProject
{
    [TestClass]
    public class DALTests
    {
        private string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=NPGeek;Integrated Security=true";
        private  IBudgetDal budgetDal = null;
        TransactionScope trans = null;

        [TestInitialize]
        public void Init()
        {
            budgetDal = new BudgetSqlDal(connString);

            trans = new TransactionScope();
        }
        [TestCleanup]
        public void CleanUp()
        {
            trans.Dispose();
        }

        [TestMethod]
        public void GetAllParksInitialTests()
        {
            List<BudgetPost> bPost = budgetDal.GetAllPosts();

            Assert.IsNotNull(bPost);
            Assert.AreNotEqual(0, bPost.Count);
        }
    }
}
