using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Control de UI
using UnityEngine.UI;

public class Albedo : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    Slider sld_ColorR;
    [SerializeField]
    Slider sld_ColorG;
    [SerializeField]
    Slider sld_ColorB;

    // Start is called before the first frame update
    private void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        render.material.SetFloat("_ColorR", sld_ColorR.value);
        render.material.SetFloat("_ColorG", sld_ColorG.value);
        render.material.SetFloat("_ColorB", sld_ColorB.value);
    }
}
