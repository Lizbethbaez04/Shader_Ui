using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Control de UI
using UnityEngine.UI;

public class MyCharacter : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    float colorPower = 1f;
    [SerializeField]
    Slider sld_colorPower;

    private void Start()
    {
        render = GetComponent<Renderer>();

    }

    private void Update()
    {
        render.material.SetFloat("_ColorPower", sld_colorPower.value);
    }
}
