using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    [SerializeField] int ScreenShakeFrames = 100;
    [SerializeField] float intensity = .01f, frequency;


    private void Start()
    {
        GameManager.instance.gameLost += ShakeScreen;
    }

    void ShakeScreen()
    {
        StopAllCoroutines();
        StartCoroutine(ScreenShakeCoroutine());
    }

    IEnumerator ScreenShakeCoroutine()
    {
        var originalposition = transform.position;

        for(int i = 0; i < ScreenShakeFrames ; i++)
        {
            transform.position = originalposition + (Vector3.right * intensity * Mathf.Cos(i * frequency) * (100 - i) / ScreenShakeFrames);
            yield return null;
        }

        transform.position = originalposition;
    }
}
