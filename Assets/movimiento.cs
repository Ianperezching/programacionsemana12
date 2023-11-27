using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float speedx;
    public float horizontal;
    public float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.position = new Vector2(transform.position.x +horizontal*Time.deltaTime*speedx,transform.position.y+vertical*Time.deltaTime*speedx);
    }
}
