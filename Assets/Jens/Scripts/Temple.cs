using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temple : MonoBehaviour {

    [Header("Temple variables")]
    public int m_CurrencyOverTime;
    public int m_ReceivedDestroyCurrency;

    private GameObject m_PlayerThatDestroys;
    private bool m_IsBeingDestroyed;
    private bool m_IsDestroyed;

    public void Attack(GameObject a_AttackObject) {
        m_PlayerThatDestroys = a_AttackObject;
        m_PlayerThatDestroys.GetComponent<PlayerInteraction>().m_InteractableText.enabled = false;
        m_PlayerThatDestroys.GetComponent<PlayerInteraction>().m_InteractableText.text = "E";
        m_PlayerThatDestroys.GetComponent<SinglePlayerStats>().m_Points += m_ReceivedDestroyCurrency;
        Destroy(gameObject);
    }

    void OnTriggerStay(Collider other) {
        if (other.gameObject.GetComponent<PlayerInteraction>()) {
            other.gameObject.GetComponent<PlayerInteraction>().OnCanInteractWithObject(this.gameObject);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.GetComponent<PlayerInteraction>()) {
            other.gameObject.GetComponent<PlayerInteraction>().OnDisableInteractWithObject(this.gameObject);
        }
    }
}
