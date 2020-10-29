using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class MatthewBot : BotController {

    private void Start()
    {

    }

    private void Update() 
    {
        PositionEntity[] enemies = DetectInConeOfVision(new Vector3[0]);
        if (enemies.Length > 0)
        {
            PathTowardsPoint(enemies[0].centrePoint);
        }
    }
}