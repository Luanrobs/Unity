using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimatedValue : UIBehaviour
{
    /// <summary>
    /// Whenever any script property is animated, OnDidApplyAnimationProperties will be called.
    /// </summary>
    [SerializeField] private int value;
    protected override void OnDidApplyAnimationProperties()
    {
        Debug.Log(value);
    }
}
