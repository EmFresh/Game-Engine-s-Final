using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour, NewControls.IPlayActions
{
    ObjectPool bullets;
    public void OnFire(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            bullets.getNewObject(transform.position, Vector3.zero);
    }

    float direction;
    float speed = 5;
    public void OnMovement(InputAction.CallbackContext ctx)
    {
        direction = ctx.ReadValue<float>();
    }



    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * direction * speed * Time.deltaTime;
    }
}
