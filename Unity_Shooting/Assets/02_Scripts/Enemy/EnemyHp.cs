using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public float maxHp;
    private float currentHp;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        currentHp = maxHp;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void TakeDamage(float damage)
    {
        currentHp -= damage;

        StopCoroutine("Hitani");
        StartCoroutine("Hitani");


        if(currentHp <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    IEnumerator Hitani()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.05f);
        spriteRenderer.color = Color.white;
    }
}
