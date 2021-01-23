using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController Dawn;
    public CharacterController Dusk;
    public float speed = 12f;
    public string current;

    // Start is called before the first frame update
    void Start()
    {
        current = "Dawn";
        Dawn.enabled = true;
        Dusk.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            DuskToDawn();
            current = "Dawn";
        }
        else if (Input.GetKeyDown(KeyCode.H)){
            DawnToDusk();
            current = "Dusk";
        }

        if(current == "Dawn"){
            float x = Input.GetAxis("Horizontal");
            Vector3 move = transform.right * x;
            Dawn.Move(move * speed * Time.deltaTime);
        }
        else if (current == "Dusk"){
            float x = Input.GetAxis("Horizontal");
            Vector3 move = transform.right * x;
            Dusk.Move(move * speed * Time.deltaTime);
        }
    }

    public void DawnToDusk() {
        Dawn.enabled = false;
        Dusk.enabled = true;
    }

    public void DuskToDawn() {
        Dusk.enabled = false;
        Dawn.enabled = true;
    }
}
