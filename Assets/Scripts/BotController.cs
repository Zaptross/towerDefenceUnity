using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

[RequireComponent(typeof(Trackable))]
public class BotController : MonoBehaviour
{

    // Constants
    protected const float maximumHitPoints = 100.0f;
    protected const float maximumAmmoCapacity = 100.0f;
    protected const float speedModifier = 5.0f;

    // Variables


    // When the bot script is loaded
    private void Awake()
    {
        GameManager.instance.TrackObject(GetComponent<Trackable>());
    }

    // Sensing Functions
    /// <summary>
    /// Returns array of PositionEntities that are within this bot's cone of vision.
    /// </summary>
    /// <param name="visionConePoints"></param>
    /// <returns></returns>
    protected PositionEntity[] DetectInConeOfVision(Vector3[] visionConePoints) // "See"
    {
        PositionEntity[] positions = GameManager.instance.GetObjectPositions();

        // Compare positions of all entities to the vision cone points
        // to determine if they are within the bounds created by the vision cone points
        // -> vision cone points will be points relative to the transform's position

        return new PositionEntity[0]; // Return an gameobject array
    }
    /// <summary>
    /// Returns array of 6 sound directions relative to this bot's forward direction. Magnitude of vector represents intensity of sounds heard.
    /// </summary>
    /// <returns></returns>
    protected SoundSet DetectSoundInDirections() // "Hear"
    {
        Vector3[] soundPositions = GameManager.instance.GetSoundPositions();

        // Return array of sound positions abstracted to Left, Right, Forward, Back, Up Down
        // -> Directions should be relative to this transform's forward direction.
        
        return new SoundSet(Enumerable.Repeat<Vector3>(Vector3.zero, 6).ToArray()); // Return an array of 6 Zero vectors, representing no sounds heard
    }

    // Action Functions
    /// <summary>
    /// 
    /// </summary>
    /// <param name="direction"></param>
    protected void MoveInDirection(Vector3 direction)
    {
        Debug.Log("MoveInDirection Not Implemented");
    }
    protected void PathTowardsPoint(Vector3 point)
    {
        Debug.Log("MoveTowardsPoint Not Implemented");
    }
    protected void RotateToFaceDirection(Vector3 direction)
    {
        Debug.Log("RotateToFaceDirection Not Implemented");
    }
    protected void Jump()
    {
        Debug.Log("Jump Not Implemented");
    }
    protected void Shoot()
    {
        Debug.Log("Shoot Not Implemented");
    }

    // Status functions
}