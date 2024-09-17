using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBuilding : MonoBehaviour
{
    private GameObject cube;
    private UnityEngine.Vector3 scaleChange, positionChange;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(3, 13, 5);
        cube.transform.position = new Vector3(0, 13, 0);
        //cube.transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.localScale += scaleChange;
        cube.transform.localScale += positionChange;
        if (cube.transform.localScale.y < 0.1f || cube.transform.localScale.y > 30.0f)
        {
            scaleChange = -scaleChange;
            positionChange = -positionChange;
        }
    }

}
