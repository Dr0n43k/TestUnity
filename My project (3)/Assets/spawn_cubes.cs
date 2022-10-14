using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
public class spawn_cubes : MonoBehaviour
{
    public TMP_InputField TimeInput;
    public GameObject[] objects;
    private GameObject cube;
    private Rigidbody rb;
    public int time_create;
    private float start_time;
    // Start is called before the first frame update

    void Start()
    {
        cube = Instantiate(objects[0], objects[0].transform.localPosition = new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        objects[0].transform.localPosition = new Vector3(-100f, 0, 0);//убираю исходный объект с экрана
        cube.tag = "cube";//мен€ю тег, чтобы объекты стали разрушаемыми 
        rb = GetComponent<Rigidbody>();
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        try
        {
            time_create = Int32.Parse(TimeInput.text);
        }
        catch 
        {
            time_create = 5;
        }
        if (Time.time - start_time >= time_create)
        {
            cube = Instantiate(objects[0], objects[0].transform.localPosition = new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            objects[0].transform.localPosition = new Vector3(-100f, 0, 0);
            cube.tag = "cube";
            start_time = Time.time;
        }

    }
}
//P.S. некоторые проблемы можно было не решать, если бы € не делал изменение параметров в реальном времени :)
