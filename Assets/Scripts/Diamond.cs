using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    float currentSpeeds = 4f;
    LevelController levelController;

    void Start()
    {
        levelController = FindObjectOfType<LevelController>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeeds * Time.deltaTime);
    }
}
