﻿/*
Problem 1. Structure
Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
Implement the ToString() to enable printing a 3D point.
Problem 2. Static read-only field
Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
Add a static property to return the point O.
Problem 3. Static class
Write a static class with a static method to calculate the distance between two points in the 3D space.
Problem 4. Path
Create a class Path to hold a sequence of points in the 3D space.
Create a static class PathStorage with static methods to save and load paths from a text file.
Use a file format of your choice.
 */
namespace _01_04.Structure
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Threading;
    
   
    class RunSructurel
    {

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Point3D pointA = new Point3D(1.5, 2.5, 3.5); 
            Point3D pointB = new Point3D(-1, -4, 7);
            Point3D pointC = new Point3D(1, 2, 3);
            Point3D pointD = new Point3D(-1, -2, 3);
            Point3D pointE = new Point3D(1.25, 2.375, 33.9);

            Path testPath = new Path(); 

            testPath.AddPoint(pointA);
            testPath.AddPoint(pointB);
            testPath.AddPoint(pointC);
            testPath.AddPoint(pointD);
            testPath.AddPoint(pointE);

            PathStorage.SavePath(testPath, @"../../pathsample.txt"); 

            Path loadedPath = PathStorage.LoadPath(@"../../pathsample.txt"); 

            for (int i = 0; i < loadedPath.PathList.Count; i++)
            {
                Console.WriteLine(loadedPath.PathList[i]);
            }
            Console.WriteLine("Distanse between point A and point B is {0}", DistanceBetweenTowPoints.DistanceBetweenPoints(pointA, pointB));
        }

    }
}
