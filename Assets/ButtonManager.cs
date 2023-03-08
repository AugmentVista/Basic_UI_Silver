using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public TextMeshProUGUI myTextMeshProButton;
    private Color orginalColor;


    public static void Main(string[] args)
    {
        // Start is called before the first frame update
        void Start()
        {
            orginalColor = MyTextMeshProButton.color;
            Button button = GetComponent<button>();
            button.onClick.AddListener(OnButtonClick);

            void OnButtonClick()
            {
                orginalColor currentColor = myTextMeshProButton.color;
                currentColor.a = 1f;
                currentColor.r += 0.2f;
                currentColor.g += 0.2f;
                currentColor.b += 0.2f;

                myTextMeshPRoButton.color = currentColor;

                StartCoroutine(ResetButtonColor());
            }

            IEnumerator ResetButtonColor()
            {
                yield return new WaitForSeconds(0.5f);
                myTextMeshProButton.color = orginalColor;
            }


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}





