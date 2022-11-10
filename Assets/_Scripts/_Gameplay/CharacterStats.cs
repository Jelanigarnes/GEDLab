using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currenthealth;

    public int damage;
    public int armor;

    public event System.Action<int, int> OnHealthChanged;
    private void Awake()
    {
        currenthealth = maxHealth;

    }

    public virtual void TakeDamage(int damage)
    {
        damage -= armor;
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        currenthealth -= damage;
        if(OnHealthChanged != null)
        {
            OnHealthChanged(maxHealth, currenthealth);
        }
        if(currenthealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        
    }
}
