using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject arrow;
    void Update()
    {
            StartCoroutine("attack");
    }

    IEnumerator attack()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            arrow.transform.position = transform.position;
            Instantiate(arrow);
            yield return new WaitForSeconds(0);
        }
    }
}
