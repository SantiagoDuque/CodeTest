using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTest.Vectors.Test
{
    [TestClass]
    public class VectorServiceTest
    {
        [TestMethod]
        public void VectorService_Filter_Should_Return_A_Set_Of_Even_Numbers_And_A_Count_Of_This_Numbers_Got_From_Vector_Parameter()
        {
            var service = new VectorService();
            var vector = new List<int> { 1,2,3,4,5,6,7,8};

            CollectionAssert.AreEqual(
               expected: new List<int> { 2,4,6,8,4 },
               actual: service.Filter(vector).ToList(),
               message: "The result is not the expected");
        }

        [TestMethod]
        public void VectorService_Filter_Should_Return_A_Set_With_Only_A_Zero_When_Vector_Contains_Odd_Elements()
        {
            var service = new VectorService();
            var vector = new List<int> { 1, 3, 5, 7, 9 };

            CollectionAssert.AreEqual(
               expected: new List<int> { 0 },
               actual: service.Filter(vector).ToList(),
               message: "The result is not the expected");
        }

        [TestMethod]
        public void VectorService_Filter_Should_Return_A_Set_With_Only_A_Zero_When_Vector_Contains_Zero_Elements()
        {
            var service = new VectorService();
            var vector = new List<int>();

            CollectionAssert.AreEqual(
               expected: new List<int> { 0 },
               actual: service.Filter(vector).ToList(),
               message: "The result is not the expected");
        }
    }
}
