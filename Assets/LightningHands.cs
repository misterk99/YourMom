using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningHands : MonoBehaviour
{
    [SerializeField]
    Valve.VR.InteractionSystem.Hand hand;
    [SerializeField]
    DigitalRuby.LightningBolt.LightningBoltScript lightningBolt;
    [SerializeField]
    GameObject amingTarget;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward * 5000, out hit))
        {
            amingTarget.transform.position = hit.point + new Vector3(0, 0, 0.1f);
        }
    }
}
