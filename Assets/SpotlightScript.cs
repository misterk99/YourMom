using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightScript : MonoBehaviour
{
    [SerializeField]
    Light spotLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward * 5000, out hit))
        {
            if (spotLight)
            {
                spotLight.transform.position = hit.point + new Vector3(0, 3, 0);
            }
           // Debug.Log("Hitted Object " + hit.transform.gameObject.name);
        }
        Debug.DrawRay(transform.position, transform.forward * 5000, Color.red);
    }
}
