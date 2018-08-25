using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    public float FadeInTime;

    Image fadePanel;
    Color panelColor = Color.black;

	// Use this for initialization
	void Start () {
        fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad < FadeInTime)
        {
            float alphaChange = Time.deltaTime / FadeInTime;
            panelColor.a -= alphaChange;
            fadePanel.color = panelColor;  }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
