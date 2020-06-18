using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] float waitToLoad = 1f;
    [SerializeField] GameObject loseLabel;
    bool playerDead = false;

    void Start()
    {
        loseLabel.SetActive(false);
    }

    void Update()
    {
        if (playerDead)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        loseLabel.SetActive(true);
        yield return new WaitForSeconds(waitToLoad);
    }

    public void Finish()
    {
        playerDead = true;
        Time.timeScale = 0;
    }

    public bool PlayerDead()
    {
        if (playerDead) { return true; }
        else { return false; }
    }
}
