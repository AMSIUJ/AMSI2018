using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToUrl : MonoBehaviour
{

    public string theURL = "https://github.com/AMSIUJ/AMSI2018";

    public void openTheLink()
    {
        Application.OpenURL((theURL));
    }
}
