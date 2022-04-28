using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Moq;

public class AcceptanceTest_test
{
    [Test]
    public void Stats_AcceptanceTest()
    {
        Stats statsObject = new Stats();
        bool expected = true;
        bool actual = statsObject.RunSuccessfully();

        Assert.AreEqual(expected, actual);
    }
}
