using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroigScript : MonoBehaviour
{
    public Transform StandRight;
    public Transform StandUp;
    public Transform StandDown;
    public Transform StandLeft;
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Ray rayUp = new Ray(StandUp.position , transform.up);
    }
}
