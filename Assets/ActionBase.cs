using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBase : MonoBehaviour
{
    enum E_ArmHeight { LOW,MIDDLE,HIGH};
    [SerializeField]
    E_ArmHeight armHeight;
    bool thrust;
    [SerializeField]
    string instult;

}
