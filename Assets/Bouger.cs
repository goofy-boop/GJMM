using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouger : MonoBehaviour
{
    public float vitesse = 5f;

    public CharacterController controlleur;

    public Animator animator;

    public AudioSource audio;

    public float gravity = -9.18f;

    public Transform verifieDeSol;
    public float distanceAuSolMax = 0.4f;
    public LayerMask cQuoiLeSol;

    bool bouge;
    bool toucheLeSol;

    Vector3 direction;

    Vector3 velocity;

    private void Awake()
    {
        audio.gameObject.SetActive(false);
    }

    private void Update()
    {
        toucheLeSol = Physics.CheckSphere(verifieDeSol.position, distanceAuSolMax, cQuoiLeSol);

        if (!toucheLeSol)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = -0.2f;
        }

        float x = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;

        direction = transform.forward * z + transform.right * x;

        controlleur.Move(direction);

        controlleur.Move(velocity * Time.deltaTime);



        bouge = x != 0 || z != 0;
        animator.SetBool("Bouge", bouge);

        if (bouge)
        {
            audio.gameObject.SetActive(true);
        }
        else
        {
            audio.gameObject.SetActive(false);
        }
    }

    public void TourneADirectionQueBouge(Transform romero)
    {
        romero.rotation = Quaternion.LookRotation(direction);
    }
}
