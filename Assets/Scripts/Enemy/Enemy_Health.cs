using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    private Score Score;
    private int health = 100;

    private void Start()
    {
        Score = GameObject.Find("Game").GetComponent<Score>();
    }
    public void TakeDamage(int dmg)
    {
        if (health <= dmg)
        {
            Score.SetScore(health);
            Destroy(this.gameObject);
        }
        else
        {
            health -= dmg;
            Score.SetScore(dmg);
        }        
    }
}
