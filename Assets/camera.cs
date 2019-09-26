using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;

    Vector3 offsetVector;
    void Start()
    {
        offsetVector = this.transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = target.position + offsetVector;
        //discarding y and z
        newpos.y = this.transform.position.y;
        newpos.z = this.transform.position.z;

        this.transform.position = Vector3.Lerp(this.transform.position, newpos, 0.2f);
    }
}
