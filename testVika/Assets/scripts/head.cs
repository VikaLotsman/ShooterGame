using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head : MonoBehaviour
{

    public GameObject RightHandObject;

    [Header("Чувствительность мыши")]
     
    public float sensitivityMouse = 200f;
    public Transform Player;

    public bool active = true;

    float xRotation = 0;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            if (RightHandObject != null)
            {
                RightHandObject.transform.parent = null;
                RightHandObject.GetComponent<Collider>().enabled = true;
                RightHandObject.GetComponent<Rigidbody>().isKinematic = false ;
                RightHandObject.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
            }
        }
        
        if (active)
        {
            RaycastHit hit;
            float mouseX = Input.GetAxis("Mouse X") * sensitivityMouse;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivityMouse;

            xRotation = xRotation - mouseY;
            xRotation = Mathf.Clamp(xRotation, -40, 40);
            transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
            Player.Rotate(Vector3.up * mouseX);   

           
            //if (Input.GetKey(KeyCode.Mouse0))
            {
                
                if (Physics.Raycast(transform.position, transform.forward, out hit))
                {
                    Debug.Log(hit.transform.name);
                    enemy that_enemy = hit.transform.GetComponent<enemy>();
                    if (that_enemy && (Input.GetKey(KeyCode.Mouse0)))
                    {
                        Debug.Log("hit");
                        that_enemy.Damage(35);
                    }
                    else
                    {
                        TNT that_tnt= hit.transform.GetComponent<TNT>();
                        if (that_tnt)
                        {
                            Debug.Log("hit 2");
                            
                        }
                    }

                    interactive that_interactive= hit.transform.GetComponent<interactive>();

                    if (that_interactive&&  (Input.GetKey(KeyCode.E) ))
                    {
                        that_interactive.Interact(this);
                    }

                }
            }
        }
    }
}