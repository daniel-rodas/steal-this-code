﻿using Dispatching.Framework;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dispatching.Tests.UnitTests.Framework.Id
{
    [TestClass]
    [TestCategory("UnitTests")]
    public class IdTest
    {
        [TestMethod]
        public void WhenEmptyGuid_ShouldThrowArgumentException()
        {
            // Arrange
            var guid = Guid.Empty;

            // Act
            Action act = () => new Id<TestEntity>(guid);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        private class TestEntity : Entity<TestEntity>
        {
            public TestEntity(Id<TestEntity> id) : base(id)
            {
            }
        }
    }
}
