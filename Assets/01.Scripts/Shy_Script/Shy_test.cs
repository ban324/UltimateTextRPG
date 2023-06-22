using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shy_test : MonoBehaviour
{
    public void Test()
    {
        Debug.Log("Test");
    }

    private void Update()
    {
        float x = Input.GetAxis("Mouse ScrollWheel") * 10;
        Debug.Log(x);
        Debug.Log((int)x);
    }
}
