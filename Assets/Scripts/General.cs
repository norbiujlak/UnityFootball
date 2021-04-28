using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public static class General
{
    public static float CalculateDistanceOfTwoPoints(float firstX, float firstY, float secondX, float secondY)
    {
        float moveX = firstX - secondX;
        float moveY = firstY - secondY;
        float distance = Mathf.Sqrt(Mathf.Pow(moveX, 2) + Mathf.Pow(moveY, 2));
        return distance;
    }
}
