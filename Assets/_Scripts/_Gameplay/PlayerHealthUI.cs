using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterStats))]
public class PlayerHealthUI : MonoBehaviour
{
    public GameObject uiPrefab;
    public Transform targetPos;

    Transform ui;
    Image healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        ui = Instantiate(uiPrefab, targetPos.transform).transform;
        ui.transform.SetParent(targetPos.transform);
        healthSlider = ui.GetChild(0).GetComponent<Image>();
        GetComponent<CharacterStats>().OnHealthChanged += OnHealthChanged;
    }

    void OnHealthChanged(int maxHealth, int currentHealth)
    {
        if(ui != null)
        {
            float healthPercentage = (float)currentHealth / maxHealth;
            healthSlider.fillAmount = healthPercentage;

            if (currentHealth <= 0)
            {
                Destroy(ui.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
