using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour
{
    Player player;
    LevelController levelController;

    void Start()
    {
        player = FindObjectOfType<Player>();
        levelController = FindObjectOfType<LevelController>();
    }

    void OnMouseDown()
    {
        if (!levelController.PlayerDead())
        {
            player.SwitchGravity();
        }
    }
}
