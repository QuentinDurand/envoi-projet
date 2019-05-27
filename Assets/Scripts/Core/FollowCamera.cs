﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] public Transform target;

        void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}
