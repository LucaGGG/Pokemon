using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GegnerPokemon : MonoBehaviour {
    public string pokemon;
    public string typ1;
    public string typ2;
    public int maxKp;
    public int kp;
    public int angriff;
    public int verteidigung;
    public int initiative;
    public Attacke attacke1;
    public Attacke attacke2;
    public Attacke attacke3;
    public Attacke attacke4;
    public Pokemon gegnermon;
    [SerializeField]
    private Text kpGegner;
    [SerializeField]
    private Text kpSpieler;
    [SerializeField]
    private Text ereignis;

    // Start is called before the first frame update
    void Start() {
        gegnermon = GameObject.FindGameObjectWithTag("spieler").GetComponent<Pokemon>();
        kpGegner = GameObject.Find("kpGegner").GetComponent<Text>();
        kpSpieler = GameObject.Find("kpSpieler").GetComponent<Text>();
        ereignis = GameObject.Find("Ereignis").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void Angreifen(Attacke attacke) {
        gegnermon.LebenVerlieren(attacke.staerke);
        AktualisiereLeben(gegnermon);
        //gegnermon.RundenAnfang();
    }

    public void LebenVerlieren(int schaden) {
        kp -= schaden;
    }

    void AktualisiereLeben(Pokemon gegner) {
        kpSpieler.text = gegner.kp.ToString();
        if (gegner.kp < 1) {
            ereignis.text = gegner.pokemon + " wurde besiegt!";
        }
    }
}
