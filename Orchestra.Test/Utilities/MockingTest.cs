using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace Orchestra.Test.Utilities
{
    [TestFixture]
    public class MockingTest
    {
        protected MockRepository Mocks;

        protected T Mock<T>(Action<T> makeExpectations)
        {
            var mock = Mocks.StrictMock<T>();
            makeExpectations(mock);
            return mock;
        }

        protected void ReplayAll()
        {
            Mocks.ReplayAll();
        }

        protected void VerifyAll()
        {
            Mocks.VerifyAll();
        }

        [SetUp]
        protected void BaseSetUp()
        {
            Mocks = new MockRepository();
            OnSetUp();
        }

        protected virtual void OnSetUp()
        {
        }
    }
}