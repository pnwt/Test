using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] public float _GroundSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -40)
        {
            transform.position = new Vector3(37,transform.position.y, transform.position.z);
        }
        transform.Translate(-transform.right * _GroundSpeed * Time.deltaTime);
    }
}
