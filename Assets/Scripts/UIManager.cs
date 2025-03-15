using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image MyImage;
    public Slider MySlider;
    public Button MyButton;

    public Sprite MySprite;
    // Start is called before the first frame update
    void Start()
    {
        MyImage.sprite = MySprite;   
    }

    // Update is called once per frame
    void Update()
    {
        MyImage.color = new Color(0, 0, 0, MySlider.value);
    }
}
