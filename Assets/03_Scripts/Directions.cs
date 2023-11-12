using System;
using System.ComponentModel;
using UnityEngine;

public class Directions
{
    public enum Direction
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }

    private static Direction Parse(String direction)
    {
        return (Direction)System.Enum.Parse(typeof(Direction), direction.ToUpper());
    }

    public static Vector3 getDirection(String direction)
    {
        return getDirection(Parse(direction));
    }

    public static Vector3 getDirection(Direction direction)
    {
        Vector3 returnDirection;

        switch (direction)
        {
            case Direction.NORTH:
                returnDirection = Vector3.forward;
                break;
            case Direction.SOUTH:
                returnDirection = Vector3.back;
                break;
            case Direction.EAST:
                returnDirection = Vector3.right;
                break;
            case Direction.WEST:
                returnDirection = Vector3.left;
                break;
            default:
                throw new InvalidEnumArgumentException(String.Format(
                    "The direction {0} is invalid direction. The direction must be North, South, East or West",
                    direction));
        }

        return returnDirection;
    }
}
