using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 10, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(UnityEngine.Input.GetAxisRaw("Horizontal"), 0, UnityEngine.Input.GetAxisRaw("Vertical"));
        //print(input);
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;
        
        //transform.position += moveAmount;
        transform.Translate(moveAmount);
    }
}
