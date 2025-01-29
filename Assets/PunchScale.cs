using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PunchScale : MonoBehaviour
{
    [SerializeField] private float punchScale;
    [SerializeField] private float duration;
    [SerializeField] private int vibrato;
    [SerializeField] private int elasticity;
    
    private bool isAnimating = false; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (isAnimating)
            {
                Debug.Log("Punch scale not completed");
                return;
            }
            Debug.Log(
                $"Pressed button '<color=yellow>2</color>': <color=orange>Punch scale the object</color>");
            AnimateButton();
        }
    }

    void AnimateButton()
    {
        isAnimating = true;
        transform.DOPunchScale(Vector3.one * punchScale, duration, vibrato, elasticity).OnComplete(() => isAnimating = false);
    }
}