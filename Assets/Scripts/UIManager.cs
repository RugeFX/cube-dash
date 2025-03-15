using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Image MyImage;
    public Slider MySlider;
    public Button MyButton;
    public Sprite MySprite;

    private void HandleClick()
    {
        MyImage.enabled = !MyImage.enabled;
    }

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        MyButton.onClick.AddListener(HandleClick);

        MyImage = GetComponentsInChildren<Image>().Single((image) => image.CompareTag("MenuImage"));

        MyImage.sprite = MySprite;
        MyImage.color = Color.white;
=======
        MyImage.sprite = MySprite;   
>>>>>>> 4a5e669a0afe00fcead1d3595bba356a48de2411
    }

    // Update is called once per frame
    void Update()
    {
        MyImage.color = new Color(1, 1, 1, MySlider.value);
    }
}
