using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class unit_test
{
    [Test]
    public void test__TakeDamage_Should_ReturnFalse_When_Called()
    {
        bool expected = false;
        bool actual = HealthCalculator.TakeDamage(5, 10);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__TakeDamage_Should_ReturnTrue_When_Called()
    {
        bool expected = true;
        bool actual = HealthCalculator.TakeDamage(10, 10);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__Heal_Should_ReturnFullHealth_When_CalledWhileDamaged()
    {
        int expected = 10;
        int actual = HealthCalculator.Heal(10, 10, 1);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__Heal_Should_ReturnFullHealth_When_CalledWithMaxHealth()
    {
        int expected = 10;
        int actual = HealthCalculator.Heal(10, 10, 10);
        Assert.AreEqual(expected, actual);
    }
}
