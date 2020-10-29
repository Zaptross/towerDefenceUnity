using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager instance;
    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(this);
        }
    }

    public CameraController cameraController { get; private set; }
    private List<Trackable> objectsToTrack = new List<Trackable>();
    private List<PositionEntity> objectPositions = new List<PositionEntity>();
    private List<BotController> bots = new List<BotController>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnonymousPositions();
    }

    public void TrackObject(Trackable trackObject)
    {
        objectsToTrack.Add(trackObject);

        if (trackObject.trackableType == TrackableType.BOT)
        {
            bots.Add(trackObject.GetComponent<BotController>());
        }
    }
    public PositionEntity[] GetObjectPositions()
    {
        return objectPositions.ToArray();
    }
    private void UpdateAnonymousPositions()
    {
        objectPositions = new List<PositionEntity>();

        for (int i = 0; i < objectsToTrack.Count; i++)
        {
            objectPositions.Add(new PositionEntity(objectsToTrack[i].transform.position, objectsToTrack[i].GetComponent<Trackable>().sizeRadius, objectsToTrack[i]));
        }
    }

    internal Vector3[] GetSoundPositions()
    {
        throw new NotImplementedException();
    }
}
