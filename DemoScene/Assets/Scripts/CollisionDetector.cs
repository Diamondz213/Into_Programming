using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionDetector : MonoBehaviour
{
    public float hitCounter;
    public TextMeshProUGUI numberText;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hitCounter += 1;
            print("I've been hit " + hitCounter + " times.");
            
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        hitCounter += 1;
        print("Someone has entered my radius " + hitCounter + " times.");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
