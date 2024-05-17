using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public interface IInteractable
{
    public void Interact();
}

public class Interaction : MonoBehaviour
{
    public float limiteDistance = 5f;
    public TMP_Text detecteur;

    private void Awake()
    {
        detecteur.gameObject.SetActive(false);
    }

    private void Update()
    {
        Ray r = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(r, out RaycastHit hit, limiteDistance))
        {
            if (hit.collider.gameObject.TryGetComponent(out IInteractable interactable))
            {
                detecteur.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
            else
            {
                detecteur.gameObject.SetActive(false);
            }
        }
    }
}
