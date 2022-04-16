using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class movement_test
{
    [Test]
    public void test__Update_Should_MoveRight_When_RightMovementInput()
    {
        int expected = 1;
        int actual = PlayerMovements.Updates('d');
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__Update_Should_MoveLeft_When_LeftMovementInput()
    {
        int expected = -1;
        int actual = PlayerMovements.Updates('a');
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__Update_Should_MoveUp_When_UpMovementInput()
    {
        int expected = 1;
        int actual = PlayerMovements.Updates('w');
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__Update_Should_MoveDown_When_DownMovementInput()
    {
        int expected = -1;
        int actual = PlayerMovements.Updates('s');
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__Update_Should_NotMove_When_NoMovementInput()
    {
        int expected = -1;
        int actual = PlayerMovements.Updates('s');
        Assert.AreEqual(expected, actual);
    }
}
