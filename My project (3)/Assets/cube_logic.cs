using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class cube_logic : MonoBehaviour
{
    public GameObject cube;
    private Rigidbody rb;
    public TMP_InputField SpeedInput;
    public TMP_InputField DistanceInput;
    public float speed;
    private float StartZ;
    public float distance;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cube = (GameObject)this.gameObject;
        StartZ = cube.transform.position.z;
    }
   
    // Update is called once per frame
    void Update()
    { 
        try
        {
            distance = Int32.Parse(DistanceInput.text);
        }
        catch
        {
            distance = 10;
        }
        try
        {
            speed = Int32.Parse(SpeedInput.text);
        }
        catch
        {
            speed = 5;
        }
        rb.velocity = new Vector3(0, 0 , speed);
        if (cube.transform.position.z - StartZ >= distance && cube.tag != "Unbreak")
        {
            Destroy(cube);
        }
        

    }
}
