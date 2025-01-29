using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    [SerializeField] private float rotationAngle;
    [SerializeField] private float rotationDuration;

    private bool isAnimating = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (isAnimating)
            {
                Debug.Log("Rotating not completed");
                return;
            }

            Debug.Log(
                $"Pressed button '<color=yellow>1</color>': <color=orange>Rotating the object</color>");
            RotateObject();
        }

    }
    void RotateObject()
    {
        isAnimating = true;
        transform.DORotate(new Vector3(0, rotationAngle, 0), rotationDuration, RotateMode.FastBeyond360)
            .OnComplete(() => isAnimating = false)
            .SetEase(Ease.Linear);

    }
}
