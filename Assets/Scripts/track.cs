using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track : MonoBehaviour
{
    public Material material;
    private Vector2 offset;

    public float xVelocity, yVelocity;

    void Start() {
        offset = new Vector2(xVelocity, yVelocity);
    }

    void Update() {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
