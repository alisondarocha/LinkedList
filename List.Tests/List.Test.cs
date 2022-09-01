using System;
using NUnit.Framework;
using LinkedList.Code;

namespace LinkedList.Tests
{   
    [TestFixture]
    public class ListTest
    {
        [Test]
        public void AddValueTest_ReturnDynamicInt() //Test to validate that AddValue receives integer type.
        {
            //setup
            dynamic valueInt = 2002;
            dynamic expectationResult = 2002;

            //execution
            var result = new ListForm().AddValue(valueInt);

            //expectation
            Assert.AreEqual(result, expectationResult);
        }

        [Test]
        public void AddValueTest_ReturnDynamicString() //Test to validate that AddValue receives strings type.
        {
            //setup
            string valueString = "Hello World";
            string expectationResult = "Hello World";

            //execution
            var result = new ListForm().AddValue(valueString);

            //expectation
            Assert.AreEqual(result, expectationResult);
        }

        [Test]
        public void AddValueTest_ReturnNull() //Test to validate that AddValue receives null type.
        {   
            //execution
            var result = new ListForm().AddValue(null);

            //expectation
            Assert.IsNull(result);
        }

        [Test]
        public void AddValueTest_ReturnData() //Test to validate that AddValue receives types from the system.
        {
            //setup
            dynamic valueData = System.DateTime.Today;
            dynamic expectationResult = System.DateTime.Today;

            //execution
            var result = new ListForm().AddValue(valueData);

            //expectation
            Assert.AreEqual(result, expectationResult);
        }

        [Test]
        public void AddValueTest_ReturnBool() //Test to validate that AddValue receives boolean type.
        {
            //setup
            bool valueBool = true;

            //execution
            bool result = new ListForm().AddValue(valueBool);

            //expectation
            Assert.IsTrue(result);
        }

        [Test]
        public void AddValueTest_ReturnObject() //Test to validate that AddValue receives object type.
        {
            //setup
            object valueObject = "Tchau";
            object valueExpectation = "Tchau";

            //execution
            object result = new ListForm().AddValue(valueObject);

            //expectation
            Assert.AreEqual(result, valueExpectation);
        }

        [Test]
        public void InvertListTest_ReturnListInvert() //Test to validate InvertList, returning inverted list elements, comparing each element using Get method.
        {

            //setup
            dynamic valueExpectation1 = 1.5;
            dynamic valueExpectation2 = "Oi";
            dynamic valueExpectation3 = System.DateTime.Today;
            dynamic valueExpectation4 = 2002;
            var list = new ListForm();
            list.AddValue(valueExpectation1);
            list.AddValue(valueExpectation2);
            list.AddValue(valueExpectation3);
            list.AddValue(valueExpectation4);

            //execution
            list.InvertList();

            //Expectation
            Assert.AreEqual(list.Get(0), valueExpectation4);
            Assert.AreEqual(list.Get(1), valueExpectation3);
            Assert.AreEqual(list.Get(2), valueExpectation2);
            Assert.AreEqual(list.Get(3), valueExpectation1);
        }

        [Test]
        public void GetTest_ReturnValueSelected() //Test to validate the Get method, in case it returns the same expected element
        {
            //setup
            dynamic valueExpectation = "Hello World";
            var list = new ListForm();
            list.AddValue(1999); //0
            list.AddValue(2.2); //1
            list.AddValue("Bye"); //2
            list.AddValue(new DateTime(2022, 01, 22)); //3
            list.AddValue("Hello World"); //4

            //execution
            var valueList = list.Get(4);

            //expectation
            Assert.AreEqual(valueList, valueExpectation);
        }
    }
}