using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouger : MonoBehaviour
{
    public float vitesse = 5f;

    public CharacterController controller;

    public Animator animator;

    bool bouge;

    Vector3 direction;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;

        direction = transform.forward * z + transform.right * x;

        controller.Move(direction);

        bouge = x != 0 || z != 0;
        animator.SetBool("Bouge", bouge);
    }

    public void TourneADirectionQueBouge(Transform romero)
    {
        romero.rotation = Quaternion.LookRotation(direction);
    }
}
