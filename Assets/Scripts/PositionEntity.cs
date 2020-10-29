using UnityEngine;
using System.Collections;

public struct PositionEntity
{
    public Vector3 centrePoint { get; private set; }
    public float radius { get; private set; }
    public Trackable trackable { get; private set; }

    public PositionEntity(Vector3 centrePoint, float radius, Trackable trackable)
    {
        this.centrePoint = centrePoint;
        this.radius = radius;
        this.trackable = trackable;
    }
}