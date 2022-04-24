using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Moq;

public class unit_test
{
    [Test]
    public void test__TakeDamage_Should_ReturnFalse_When_Called()
    {
        bool expected = false;
        bool actual = HealthCalc.DamageCalculator(10);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__TakeDamage_Should_ReturnTrue_When_Called()
    {
        bool expected = true;
        bool actual = HealthCalc.DamageCalculator(0);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__Heal_Should_ReturnFullHealth_When_CalledWhileDamaged()
    {
        int expected = 10;
        int actual = HealthCalc.HealCalculator(15, 10);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void test__Heal_Should_ReturnFullHealth_When_CalledWithMaxHealth()
    {
        int expected = 5;
        int actual = HealthCalc.HealCalculator(5, 10);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCase(10, 10)]
    public void test__TakeRandomDamage_Should_ReturnRandomDmg_When_Called(int randomDmg, int expected)
    {
        var statsValue = new Mock<Stats>();
        statsValue.Setup(x => x.getDmg()).Returns(randomDmg);

        int actual = RandomDmg.TakeRandomDamage(statsValue.Object);

        Assert.AreEqual(expected, actual);
    }
}