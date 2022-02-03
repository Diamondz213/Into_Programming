using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviorScript : MonoBehaviour
{ 
    public int moveSpeed;//controls how fast the player moves

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))// If player hits right arrow key, object moves right
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))// If player hits left arrow key, object moves left
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;
        }
        if (Input.GetKey(KeyCode.UpArrow))// If player hits up arrow key, object moves up
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward;
        }
        if(Input.GetKey(KeyCode.DownArrow))// If player hits down arrow key, object moves down
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;
        }

    }
}
