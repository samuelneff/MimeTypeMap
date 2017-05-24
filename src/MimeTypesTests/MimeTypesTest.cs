using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using MimeTypes;

namespace MimeTypesTests
{
    [TestClass]
    public class MimeTypesTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetMimeTypeTestNull()
        {
            MimeTypeMap.GetMimeType(null);
        }

        [TestMethod]
        public void GetMimeTypeTestWithoutDot()
        {
            Assert.AreEqual(MimeTypeMap.GetMimeType("bin"), MimeTypeMap.GetMimeType(".bin"));
        }

        [TestMethod]
        public void GetMimeTypeTestSuccess()
        {
            Assert.AreEqual(MimeTypeMap.GetMimeType("bin"), "application/octet-stream");
        }

        [TestMethod]
        public void GetMimeTypeTestFailureWithDefault()
        {
            Assert.AreEqual(MimeTypeMap.GetMimeType("unknownExtension"), MimeTypeMap.DefaultMimeType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMimeTypeTestFailureWithoutDefault()
        {
            MimeTypeMap.GetMimeType("unknownExtension", false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetExtensionTestNull()
        {
            MimeTypeMap.GetExtension(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetExtenstionTestNotValid()
        {
            MimeTypeMap.GetExtension(".mimeTypeWithDot");
        }

        [TestMethod]
        public void GetExtenstionTestSuccess()
        {
            Assert.AreEqual(MimeTypeMap.GetExtension("application/msword"), ".doc");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetExtenstionTestFailureWithoutDefault()
        {
            MimeTypeMap.GetExtension("unknownMimeType");
        }

        [TestMethod]
        public void GetExtenstionTestFailureWithDefault()
        {
            Assert.AreEqual(MimeTypeMap.GetExtension("unknownMimeType", true), MimeTypeMap.DefaultExtension);
        }

        [TestMethod]
        public void TryGetMimeTypeSuccess()
        {
            string mimeType;
            Assert.IsTrue(MimeTypeMap.TryGetMimeType(".bin", out mimeType));
        }

        [TestMethod]
        public void TryGetMimeTypeFailure()
        {
            string mimeType;
            Assert.IsFalse(MimeTypeMap.TryGetMimeType("unknownExtension", out mimeType));
        }

        [TestMethod]
        public void TryGetExtensionSuccess()
        {
            string extension;
            Assert.IsTrue(MimeTypeMap.TryGetExtension("application/octet-stream", out extension));
        }

        [TestMethod]
        public void TryGetExtensionFailure()
        {
            string extension;
            Assert.IsFalse(MimeTypeMap.TryGetExtension("unknownMimeType", out extension));
        }
    }
}
