using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    ObjectPool bulletPool;


    void fire()
    {
        bulletPool.getNewObject(transform.position, new Vector3(0, 0, 180));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
