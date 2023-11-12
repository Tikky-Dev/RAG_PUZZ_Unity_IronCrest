using System;
using NUnit.Framework;
using UnityEngine;

public class DirectionsTest
{
    [Test]
    public void _0_givenNorthStringWhenGetDirectionsShouldReturnVector3Forward()
    {
        
        Vector3 expected = Vector3.forward;
        Vector3 actual;
        
        actual = Directions.getDirection("North");
        Assert.AreEqual(expected, actual);
        
        actual = Directions.getDirection("north");
        Assert.AreEqual(expected, actual);
        
        actual = Directions.getDirection("nOrTh");
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void _1_givenSouthStringWhenGetDirectionsShouldReturnVector3Back()
    {
        
        Vector3 expected = Vector3.back;
        Vector3 actual;
        
        actual = Directions.getDirection("South");
        Assert.AreEqual(expected, actual);
        
        actual = Directions.getDirection("south");
        Assert.AreEqual(expected, actual);
        
        actual = Directions.getDirection("sOuTh");
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void _2_givenEasthStringWhenGetDirectionsShouldReturnVector3Right()
    {
        
        Vector3 expected = Vector3.right;
        Vector3 actual;
        
        actual = Directions.getDirection("East");
        Assert.AreEqual(expected, actual);
        
        actual = Directions.getDirection("east");
        Assert.AreEqual(expected, actual);
        
        actual = Directions.getDirection("eAsT");
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void _3_givenWestStringWhenGetDirectionsShouldReturnVector3Left()
    {
        
        Vector3 expected = Vector3.left;
        Vector3 actual;
        
        actual = Directions.getDirection("West");
        Assert.AreEqual(expected, actual);
        
        actual = Directions.getDirection("west");
        Assert.AreEqual(expected, actual);
        
        actual = Directions.getDirection("wEsT");
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void _4_givenBadStringWhenGetDirectionsShouldThrowError()
    {
        Assert.That(() => Directions.getDirection("BadString"),
                Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void _5_givenDirectionWhenGetDirectionShouldReturnApropriateVector3()
    {
        Vector3 expected;
        Vector3 actual;

        expected = Vector3.forward;
        actual = Directions.getDirection(Directions.Direction.NORTH);
        Assert.AreEqual(expected,actual);
        
        expected = Vector3.back;
        actual = Directions.getDirection(Directions.Direction.SOUTH);
        Assert.AreEqual(expected,actual);
        
        expected = Vector3.right;
        actual = Directions.getDirection(Directions.Direction.EAST);
        Assert.AreEqual(expected,actual);
        
        expected = Vector3.left;
        actual = Directions.getDirection(Directions.Direction.WEST);
        Assert.AreEqual(expected,actual);
    }
}