using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    public float maxHP = 3;
    public float currentHP;
    //public SpriteRenderer spriteRenderer;

    public float MaxHp => maxHP;
    public float CurrentHp => currentHP;

    void Start()
    {
        currentHP = maxHP;
        //spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;

        if(currentHP <= 0)
        {
            gameObject.SetActive(false);
            
        }
    }
}
