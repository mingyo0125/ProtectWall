using UnityEngine;
using System.Collections;


public class PlayerMove : MonoBehaviour
{
    public float speed = 3f;
    public Animator ani;
    Rigidbody2D rb;
    public bool isGround;
    public StageData stageData;
    private void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0,3,0);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(0,-3,0);
        }      
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }

}
