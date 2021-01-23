using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera DawnCam;
    public Camera DuskCam;

    // Start is called before the first frame update
    void Start()
    {
        DawnCam.enabled = true;
        DuskCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            DuskToDawn();
        }
        else if (Input.GetKeyDown(KeyCode.H)){
            DawnToDusk();
        }
    }

    public void DawnToDusk() {
        DawnCam.enabled = false;
        DuskCam.enabled = true;
    }

    public void DuskToDawn() {
        DuskCam.enabled = false;
        DawnCam.enabled = true;
    }
}
