using CustomPasswordCheker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace UnitTestPasswordCheker
{
    [TestClass]
    public class UnitTestVefivy
    {
        [TestMethod]
        public void Verify_more_than7()
        {
            var mock = new MockRepository();
            var repository = mock.DynamicMock<IUserRepositiry>();
            Expect.Call(repository.CreateUser(null , null)).IgnoreArguments().Return(123);
            Expect.Call(repository.UserNameIsUsed(null)).IgnoreArguments().Return(false);
            var cheker = new PasswordChecker(repository);


            mock.ReplayAll();
            var res = cheker.Verify("12345678ASd", "user", false);
            mock.VerifyAll();


            Assert.AreEqual(123, res);
        }

        
        [TestMethod]
        public void Verify_has_alphabetic()
        {
            var mock = new MockRepository();
            var repository = mock.DynamicMock<IUserRepositiry>();
            Expect.Call(repository.CreateUser(null, null)).IgnoreArguments().Return(123);
            Expect.Call(repository.UserNameIsUsed(null)).IgnoreArguments().Return(false);
            var cheker = new PasswordChecker(repository);


            mock.ReplayAll();
            var res = cheker.Verify("123456Q", "user", false);
            mock.VerifyAll();


            Assert.AreEqual(123, res);
        }


        
        [TestMethod]
        public void Verify_has_spec_symbol_admin()
        {
            var mock = new MockRepository();
            var repository = mock.DynamicMock<IUserRepositiry>();
            Expect.Call(repository.CreateUser(null, null)).IgnoreArguments().Return(123);
            Expect.Call(repository.UserNameIsUsed(null)).IgnoreArguments().Return(false);
            var cheker = new PasswordChecker(repository);


            mock.ReplayAll();
            var res = cheker.Verify("123456Arrrr", "user", true);
            mock.VerifyAll();


            Assert.AreEqual(123, res);
        }


        [TestMethod]
        public void Verify_has_onedigit()
        {
            var mock = new MockRepository();
            var repository = mock.DynamicMock<IUserRepositiry>();
            Expect.Call(repository.CreateUser(null, null)).IgnoreArguments().Return(123);
            Expect.Call(repository.UserNameIsUsed(null)).IgnoreArguments().Return(false);
            var cheker = new PasswordChecker(repository);


            mock.ReplayAll();
            var res = cheker.Verify("qwerty76", "user", false);
            mock.VerifyAll();


            Assert.AreEqual(123, res);
        }

        [TestMethod]
        public void Verify_more_than10_admin()
        {
            var mock = new MockRepository();
            var repository = mock.DynamicMock<IUserRepositiry>();
            Expect.Call(repository.CreateUser(null, null)).IgnoreArguments().Return(123);
            Expect.Call(repository.UserNameIsUsed(null)).IgnoreArguments().Return(false);
            var cheker = new PasswordChecker(repository);


            mock.ReplayAll();
            var res = cheker.Verify("qwerty12345p", "user", false);
            mock.VerifyAll();


            Assert.AreEqual(123, res);
        }
    }
}
