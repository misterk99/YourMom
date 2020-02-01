using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [Header("UI Interaction")]
    public Text m_InteractableText;

    private GameObject m_CanInteractableObject;
    private GameObject m_InteractableObject;

    private bool m_CanInteract = false;
    private bool m_IsDestroying = false;
    private float m_DestroyCounter = 0;

    void Start() {
        m_InteractableText.enabled = false;
    }

    void Update() {
        if (m_CanInteract) {
            if (Input.GetKeyDown(KeyCode.E)) {
                Interact();
            }
        }

        if (m_IsDestroying) {
            m_DestroyCounter = m_DestroyCounter + Time.deltaTime;

            if (Input.GetKeyUp(KeyCode.E)) {
                m_IsDestroying = false;
                m_CanInteract = true;
            }
            else if (m_DestroyCounter >= 3.0f) {
                m_InteractableObject.GetComponent<Temple>().Attack(this.gameObject);
                m_IsDestroying = false;
                m_CanInteract = true;
            }
        }
    }

    public void Interact() {
        m_DestroyCounter = 0;
        m_CanInteract = false;
        m_InteractableObject = m_CanInteractableObject;
        m_InteractableText.text = "Destroying..";
        m_IsDestroying = true;
    }

    public void OnCanInteractWithObject(GameObject a_Object) {
        m_CanInteractableObject = a_Object;
        m_InteractableText.enabled = true;
        m_CanInteract = true;
    }

    public void OnDisableInteractWithObject(GameObject a_Object) {
        if (m_CanInteractableObject = a_Object) {
            m_CanInteractableObject = null;
        }
        m_InteractableText.enabled = false;
        m_CanInteract = false;
    }
}
