namespace DotNetFqdnParser.Tests
{
    [TestClass]
    public class FqdnParserTest
    {
        [DataRow("example.com", null, "example", "com")]
        [DataRow("api.example.com", "api", "example", "com")]
        [DataTestMethod]
        public void Parse(string fqdn, string subdomain, string secondLevelDomain, string topLevelDomain)
        {
            var result = FqdnParser.Parse(fqdn);

            Assert.AreEqual(subdomain, result.Subdomain);
            Assert.AreEqual(secondLevelDomain, result.SecondLevelDomain);
            Assert.AreEqual(topLevelDomain, result.TopLevelDomain);
        }
    }
}