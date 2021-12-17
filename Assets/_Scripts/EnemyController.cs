using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    ObjectPool bulletPool;


    void fire()
    {
        bulletPool.getNewObject(transform.position, new Vector3(0, 0, 180)).tag = "enemybullet";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("player");
        if (other.tag == "playerbullet")
            Destroy(this);
    }
    float lastCount;
    // Update is called once per frame
    void Update()
    {
        float time = Time.timeSinceLevelLoad;
        if ((int)(time / 4) != (int)lastCount)
        {
            lastCount = (int)(time / 4);

            fire();
        }

        transform.position += -transform.up * Time.deltaTime * 0.5f;
    }
}
