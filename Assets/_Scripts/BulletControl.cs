using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    [SerializeField]
    ObjectPool bullets;

    Lifetime.Lifespan lifespan = new Lifetime.Lifespan();

    float timeCount = 0;
    float speed = 10;
    private void OnEnable()
    {
        timeCount = 0;

        Lifetime.initPlugin();
        //  Lifetime.setLifespan(ref lifespan, 10);
    }

    private void OnDestroy()
    {
        Lifetime.closePlugin();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        timeCount += Time.deltaTime;
        if (timeCount >= lifespan.span)
            bullets.removeObject(gameObject);

    }
}