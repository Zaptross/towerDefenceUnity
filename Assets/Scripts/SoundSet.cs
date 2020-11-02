using UnityEngine;
using System.Collections;

public struct SoundSet
{
    public Vector3 Forward { get; private set; }
    public Vector3 Back { get; private set; }
    public Vector3 Left { get; private set; }
    public Vector3 Right { get; private set; }
    public Vector3 Up { get; private set; }
    public Vector3 Down { get; private set; }

    public SoundSet(Vector3 forward, Vector3 back, Vector3 left, Vector3 right, Vector3 up, Vector3 down)
    {
        Forward = forward;
        Back = back;
        Left = left;
        Right = right;
        Up = up;
        Down = down;
    }

    public SoundSet(Vector3[] vector3s)
    {
        Forward = vector3s[0];
        Back = vector3s[1];
        Left = vector3s[2];
        Right = vector3s[3];
        Up = vector3s[4];
        Down = vector3s[5];
    }

    public Vector3[] ToArray()
    {
        return new Vector3[] { Forward, Back, Left, Right, Up, Down };
    }
}