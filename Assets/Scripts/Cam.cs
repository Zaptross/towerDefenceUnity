using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cam {
    public Camera cam { get; private set; }
    public Vector2 offset { get; private set; }
    public Vector2 scale { get; private set; }
    
    public Cam (Camera cam, Vector2 offset, Vector2 scale) {
        this.cam = cam;
        this.offset = offset;
        this.scale = scale;
    }
    public Cam (Camera cam) {
        this.cam = cam;
        this.offset = Vector2.one;
        this.scale = Vector2.one;
    }

    public bool isOnscreen() {
        return false;
    }

    public void SetOffset(Vector2 offset) { this.offset = offset; }
    public void SetScale(Vector2 scale) { this.scale = scale; }
    public void Offset(Vector2 offset) { this.offset += offset; }
    public void Scale(Vector2 scale) { this.scale += scale; }

    private void Update() {
        SetView();
    }

    public void SetView() {
        
    }
}