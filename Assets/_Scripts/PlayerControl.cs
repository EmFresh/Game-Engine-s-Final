using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour, NewControls.IPlayActions
{
    int lives = 3;
    [SerializeField]
    ObjectPool bullets;
    public void OnFire(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            bullets.getNewObject(transform.position, Vector3.zero).tag = "playerbullet";
    }

    float direction;
    float speed = 5;
    public void OnMovement(InputAction.CallbackContext ctx)
    {
        print("play moce");
        direction = ctx.ReadValue<float>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("player");
        if (other.tag == "enemybullet")
            lives--;

        if (lives == 0)
            Destroy(this);
    }
    NewControls control;
    private void OnEnable()
    {
        if (control == null)
        {
            control = new NewControls();
            control.play.SetCallbacks(this);
        }
        control.play.Enable();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * direction * speed * Time.deltaTime;
    }
}
