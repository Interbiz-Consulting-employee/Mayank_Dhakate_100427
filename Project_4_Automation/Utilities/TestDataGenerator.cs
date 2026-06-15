using System;

namespace Project4.Utilities
{
    public static class TestDataGenerator
    {
        public static string GetUniqueOrganizationName()
        {
            return "TestOrg_" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}