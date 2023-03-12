using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHitPoints = 200f;

    public void DecreasePlayerHealth(float damage)
    {
        playerHitPoints -= damage;
        if(playerHitPoints <= 0)
        {
            Debug.Log("Player is dead");
        }

    }
}
