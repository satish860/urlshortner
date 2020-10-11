using System;
using Xunit;
using Urlshortner.core;
using FluentAssertions;

namespace UrlShortner.core.tests
{
    public class UrlShortnerTests
    {
        [Fact]
        public void Should_Be_Able_to_Short_An_URL_to_Charcter()
        {
            Shortner shortner = new Shortner();
            var token = shortner.Encode(125);
            token.Should().Be("4p");
        }

        [Fact]
        public void Should_Be_Able_to_Decode_the_token_to_Number()
        {
            Shortner shortner = new Shortner();
            var token = shortner.Decode("4p");
            token.Should().Be(125);
        }
    }
}
