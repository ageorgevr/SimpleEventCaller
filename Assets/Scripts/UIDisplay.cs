using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        GameManager.instance.gameStarted += SetStartText;
        GameManager.instance.gameLost += SetLostText;
    }

    void SetStartText()
    {
        StopAllCoroutines();
        text.text = "GO!";
        StartCoroutine(ClearText());
    }

    void SetLostText()
    {
        StopAllCoroutines();
        text.text = "GAME OVER\nPRESS SPACE TO RESTART";
    }

    IEnumerator ClearText()
    {
        yield return new WaitForSeconds(2);
        text.text = "";
    }
}
