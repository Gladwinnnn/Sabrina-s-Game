using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2d;    
    Score score;
    [SerializeField] int[] gravity;
    [SerializeField] bool autoPlay;
    int count = 0;
    float Timer = 2f;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        score = FindObjectOfType<Score>();
    }

    void Update()
    {
        if (!autoPlay){ return; }

        else
        {   
            Timer -= Time.deltaTime;
            if (Timer <= 0f)
            {
                SwitchGravity();
                Timer = 2f;
            }
        }
    }

    public void SwitchGravity()
    {
        count ++;
        if (count == gravity.Length)
        {
            count = 0;
        }
        rigidbody2d.gravityScale = gravity[count];
    }

    public int Counter()
    {
        return count;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Diamond")
        {
            Destroy(other.gameObject);
            score.AddToScore();
        }
    }
}
