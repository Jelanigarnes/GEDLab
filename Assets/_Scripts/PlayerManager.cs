using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    
    public GameObject player;

    //int health;

    //public void ChangeHealth(int healthValue)
    //{
    //    health = healthValue;
    //    if (healthValue <= 0)
    //    {
    //        Destroy(player);
    //    }
    //}

    private void Awake() {
        if(instance == null)
        {
            instance = this;
        }
    }


}
