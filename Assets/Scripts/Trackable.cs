using UnityEngine;
using System.Collections;

public enum TrackableType { UNKNOWN, PICKUP, HAZARD, BOT }
public class Trackable : MonoBehaviour
{
    public float sizeRadius { get; private set; }
    public TrackableType trackableType { get; private set; }
}