using Cedar.AuditTrail.Interception;

namespace CCNUnitTests.FrameworkTest
{
    public class DemoInstanceService
    {
        [AuditTrailCallHandler("test")]
        public string TestMethod(string input)
        {
            return input;
        }
    }
}