using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;

        void LateUpdate() // ensures this is updated last
        {
            transform.position = target.position;
        }
    }
}
