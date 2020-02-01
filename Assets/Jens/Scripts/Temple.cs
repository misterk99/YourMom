using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temple : MonoBehaviour {

    [Header("Temple variables")]
    public int m_CurrencyOverTime;
    public int m_ReceivedDestroyCurrency;
    public float m_WaitBeforeDestroy;

    private GameObject m_PlayerThatDestroys;
    private bool m_IsBeingDestroyed;
    private bool m_IsDestroyed;

    public IEnumerator Attack(GameObject a_AttackObject) {
        m_PlayerThatDestroys = a_AttackObject;
        yield return new WaitForSeconds(m_WaitBeforeDestroy);
        m_PlayerThatDestroys.GetComponent<PlayerInteraction>().m_InteractableText.enabled = false;
        m_PlayerThatDestroys.GetComponent<PlayerInteraction>().m_InteractableText.text = "E";
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
