using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetect : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeHealth(1);
            ScoreManager.instance.ChangeScore(1);
            Destroy(gameObject);
        }
    }
}
