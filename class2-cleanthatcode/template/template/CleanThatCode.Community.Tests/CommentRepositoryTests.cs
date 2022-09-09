using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanThatCode.Community.Common;
using CleanThatCode.Community.Repositories.Implementations;
using CleanThatCode.Community.Tests.Mocks;
using CleanThatCode.Community.Repositories.Data;
using Moq;
using System.Collections.Generic;
using CleanThatCode.Community.Models.Entities;
namespace CleanThatCode.Community.Tests
{
[TestClass]
    public class CommentRepositoryTests
    {
        private CommentRepository _commentRepository;
        // private Mock<ICleanThatCodeDbContext> _cleanThatCodeDbContextMock = new Mock<ICleanThatCodeDbContext>();
        private CleanThatCodeDbContextMock _cleanThatCodeDbContextMock = new CleanThatCodeDbContextMock();

        [TestInitialize]
        public void Initialize()
        {
           _commentRepository = new CommentRepository(_cleanThatCodeDbContextMock);
        }

        
    }
}
