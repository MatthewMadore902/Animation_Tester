using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Animator cubeAnimator;
    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
            isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == false)
        {
            Debug.Log("SPACE IS HIT");
            cubeAnimator.SetBool("CubeSpinOn", true); 
            isActive = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isActive == true)
        {
            Debug.Log("SPACE HAS BEEN HIT");
            cubeAnimator.SetBool("CubeSpinOn", false);
            isActive = false;
        }
    }
}
