using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int mHp = 100;
    public int cH;
    void Start()
    {
        cH = mHp;
    }
    
   public void TakeDamage(int damage)
    {
        cH -= damage;
        if (cH <= 0)
        {
            Die();
        }
    }

    void Die()
    {
       // Debug.Log("Enemy died");
       Destroy(gameObject);
    }
}
