// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class DeleteVariantItemTests
    {
        public static DeleteVariantItemController Fixture()
        {
            DeleteVariantItemController controller = new DeleteVariantItemController(new DeleteVariantItemRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new DeleteVariantItemController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}