using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wechseln : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WechselMen�() {
        SceneManager.LoadScene(1);
    }

    public void Men�Schliessen() {
        SceneManager.LoadScene(0);
    }

    public void test(int hallo) {
        hallo = hallo + 5;
    }
}
