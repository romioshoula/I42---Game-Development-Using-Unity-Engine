using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpingBall : UnityEngine.MonoBehaviour //fully qualified name
{


    [SerializeField] List<Transform> points;
    [SerializeField] float tValue;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[0].position;


    }

    // Update is called once per frame
    void Update()
    {
         
        transform.position = Vector3.Lerp(transform.position, points[1].position, tValue);
    }
}
