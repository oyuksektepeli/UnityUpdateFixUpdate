using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Used for reqular updates such as:
    // Moving non-physics objects
    // Simple Timers
    // Receiving Input

    // Updates Interval times vary
    void Update()
    {
        Debug.Log("Update time: " + Time.deltaTime);
    }

    // Called every physics step
    // FixedUpdate intervals are consistent
    // Adjusting physics (RigidBody) objects
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }


}
