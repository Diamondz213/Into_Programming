using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigibodyMovement : MonoBehaviour
{
    public float moveSpeed; // Controls Speed
    private Rigidbody rigibody;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigibody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigibody.velocity.y, Input.GetAxis("Vertical")) * moveSpeed;
        Debug.Log(rigibody);
    }
}
