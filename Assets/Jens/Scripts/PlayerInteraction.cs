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

    void Start() {
        m_InteractableText.enabled = false;
    }

    void Update() {
        if (m_CanInteract) {
            if (Input.GetKey(KeyCode.E)) {
                Interact();
            }
        }
    }

    public void Interact() {
        m_CanInteract = false;

        m_InteractableObject = m_CanInteractableObject;
        m_InteractableText.text = "Destroying..";
        Debug.Log(m_InteractableObject.name);
        StartCoroutine(m_InteractableObject.GetComponent<Temple>().Attack(this.gameObject));
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
