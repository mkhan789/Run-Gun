using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public Transform target;
    private Vector3 previousPosition;
    public float paralaxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        previousPosition = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((target.position.x -previousPosition.x)/ paralaxSpeed, (target.position.y - previousPosition.y) / paralaxSpeed,0);
        previousPosition = target.position;
    }
}
