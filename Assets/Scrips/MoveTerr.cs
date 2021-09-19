using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTerr : MonoBehaviour
{
    //public GameObject Terr;
    public float speed;

    public Transform startPos;
    public Transform EndPos;

    public Transform[] terrs;

    private float StartZ;
    private float EndZ;


    // Start is called before the first frame update
    void Start()
    {
        //terrs = Terr.GetComponentsInChildren<Transform>();

        StartZ = startPos.position.z;
        EndZ = EndPos.position.z;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach(Transform i in terrs)
        {
            i.position += new Vector3(0, 0, speed);

            if (i.position.z >= EndZ)
            {
                i.position = new Vector3(i.position.x, i.position.y, StartZ);
            }
        }
    }
}
