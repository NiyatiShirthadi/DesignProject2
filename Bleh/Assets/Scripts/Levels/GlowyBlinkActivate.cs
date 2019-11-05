using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowyBlinkActivate : MonoBehaviour
{
    public GameObject Glowy;
    // Start is called before the first frame update
    void Start()
    {
        Glowy.SetActive(false);

        CreateTheBlackness.letThereBeDark += GlowyActivate;
    }

    public void GlowyActivate()
    {
        Glowy.SetActive(true);
    }

    // Update is called once per frame
    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= GlowyActivate;
    }
}
