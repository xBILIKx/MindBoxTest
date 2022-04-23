using System;
using NUnit.Framework;
using Squares;
using Squares.Figures;
using Squares.Interfaces;

namespace Tests;

public class Tests
{   
    [Test]
    public void TriangleExist()
    {
        Assert.Throws<Exception>(() => new Triangle(3, 2, 15));
        Assert.Throws<Exception>(() => new Triangle(32, 3, 23));
        Assert.Throws<Exception>(() => new Triangle(34, 54, 98));
        Assert.Throws<Exception>(() => new Triangle(20, 65, 43));
        
        Assert.DoesNotThrow(() => new Triangle(8, 9, 15));
        Assert.DoesNotThrow(() =>new Triangle(15, 12, 24));
        Assert.DoesNotThrow(() =>new Triangle(13, 14, 16));
        Assert.DoesNotThrow(() =>new Triangle(57, 58, 80));
    }

    [Test]
    public void TriangleIsRight()
    {
        Assert.True(new Triangle(4, 3, 5).IsRight());
        Assert.True(new Triangle(40, 9, 41).IsRight());
        Assert.True(new Triangle(12, 35, 37).IsRight());
        Assert.True(new Triangle(8, 15, 17).IsRight());
        
        Assert.False(new Triangle(8, 9, 15).IsRight());
        Assert.False(new Triangle(15, 12, 24).IsRight());
        Assert.False(new Triangle(13, 14, 16).IsRight());
        Assert.False(new Triangle(57, 58, 80).IsRight());
    }

    [Test]
    public void TriangleSquare()
    {
        Assert.AreEqual(29.933, new Triangle(8, 9, 15).Square);
        Assert.AreEqual(73.634, new Triangle(15, 12, 24).Square);
        Assert.AreEqual(86.824, new Triangle(13, 14, 16).Square);
        Assert.AreEqual(1652.142, new Triangle(57, 58, 80).Square);
        Assert.AreEqual(6.0, new Triangle(4, 3, 5).Square);
        Assert.AreEqual(180.0, new Triangle(40, 9, 41).Square);
        Assert.AreEqual(210.0, new Triangle(12, 35, 37).Square);
        Assert.AreEqual(60.0, new Triangle(8, 15, 17).Square);
    }

    [Test]
    public void CircleExist()
    {
        Assert.Throws<Exception>(() => new Circle(-31434));
        Assert.Throws<Exception>(() => new Circle(-9.234432));
        Assert.Throws<Exception>(() => new Circle(0));
        Assert.Throws<Exception>(() => new Circle(-0.1));
        
        Assert.DoesNotThrow(() => new Circle(0.1));
        Assert.DoesNotThrow(() => new Circle(25234));
        Assert.DoesNotThrow(() => new Circle(3.4435243));
        Assert.DoesNotThrow(() => new Circle(4452.2345));
        Assert.DoesNotThrow(() => new Circle(98.1241));
    }

    [Test]
    public void CircleSquare()
    {
        Assert.AreEqual(78.540, new Circle(5).Square);
        Assert.AreEqual(12.566, new Circle(2).Square);
        Assert.AreEqual(156228.261, new Circle(223).Square);
        Assert.AreEqual(1520.531, new Circle(22).Square);
        Assert.AreEqual(6.158, new Circle(1.4).Square);
        Assert.AreEqual(1827.698, new Circle(24.12).Square);
    }

    [Test]
    public void FigureSquare()
    {
        Assert.AreEqual(6.158, new Figure(new Circle(1.4)).Square);
        Assert.AreEqual(1520.531, new Figure(new Circle(22)).Square);
        Assert.AreEqual(156228.261, new Figure(new Circle(223)).Square);
        Assert.AreEqual(29.933, new Figure(new Triangle(8, 9, 15)).Square);
        Assert.AreEqual(73.634, new Figure(new Triangle(15, 12, 24)).Square);
        Assert.AreEqual(180.0, new Figure(new Triangle(40, 9, 41)).Square);
    }
}