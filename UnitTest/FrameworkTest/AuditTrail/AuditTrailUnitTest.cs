using System;
using CCNUnitTests.FrameworkTest.TestService;
using Cedar.Core.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CCNUnitTests.FrameworkTest.AuditTrail
{
    [TestClass]
    public class AuditTrailUnitTest
    {
        //private static IAuditTrailManagementService iAuditTrailManagementService;
        private static ITestService iTestService;
        private static IServiceLocator iServiceLocate;

        public AuditTrailUnitTest()
        {
            //iAuditTrailManagementService = ServiceLocatorFactory.GetServiceLocator().GetService<IAuditTrailManagementService>();
            iServiceLocate = ServiceLocatorFactory.GetServiceLocator();
            iTestService = iServiceLocate.GetService<ITestService>();
        }

        [TestMethod]
        public void AuditTrailCallHandlerTestMethod()
        {
            Cedar.Core.ApplicationContexts.ApplicationContext.Current.UserId = Guid.NewGuid().ToString();
            Cedar.Core.ApplicationContexts.ApplicationContext.Current.TransactionId = Guid.NewGuid().ToString();
            Cedar.Core.ApplicationContexts.ApplicationContext.Current.UserName = Guid.NewGuid().ToString();
            //AuditTrailSettings at = ConfigManager.GetConfigurationSection<AuditTrailSettings>();
            //at.Configure(iServiceLocate);
            var result = iTestService.SayHello(new {id = "1", name = "name"});
            Assert.IsFalse(string.IsNullOrEmpty(result));
        }
    }
}