using UnityEngine;

public class MatthewBot : BotController {
    
    private void Update() {
        
        if (hp < 10) {
            Move();
        }
    }
}