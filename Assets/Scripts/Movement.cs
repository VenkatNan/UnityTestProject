using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject cube;

    void Start()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(1,1,1);
        cube.transform.position = new Vector3(-0.2f, 1.3f, -35);
    }

    // Update is called once per frame
    void Update()
    {
        if (cube)
        {
            cube.transform.position = cube.transform.position + new Vector3(0, 0, 0.01f);
        }

        if (cube.transform.position.z > 37)
        {
            cube.transform.position = new Vector3(-0.2f, 1.3f, -35);
        }

    }
}
