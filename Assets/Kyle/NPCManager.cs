﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public Transform minimum, maximum;
    public static Transform min, max;

    private void Start()
    {
        min = minimum;
        max = maximum;
    }
}
