using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokemon : MonoBehaviour
{
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
    //public Button _attacke1;
    //public Button _attacke2;
    //public Button _attacke3;
    //public Button _attacke4;
    public Pokemon spielermon;
    public Pokemon gegnermon;
    [SerializeField]
    private Text kpGegner;
    [SerializeField]
    private Text kpSpieler;
    [SerializeField]
    private Text ereignis;
    // Start is called before the first frame update
    void Start()
    {
        //_attacke1 = GameObject.Find("Attacke1").GetComponent<Button>();
        //_attacke2 = GameObject.Find("Attacke2").GetComponent<Button>();
        //_attacke3 = GameObject.Find("Attacke3").GetComponent<Button>();
        //_attacke4 = GameObject.Find("Attacke4").GetComponent<Button>();
        spielermon = GameObject.FindGameObjectWithTag("spieler").GetComponent<Pokemon>();
        gegnermon = GameObject.FindGameObjectWithTag("gegner").GetComponent<Pokemon>();
        kpSpieler = GameObject.Find("kpSpieler").GetComponent<Text>();
        kpGegner = GameObject.Find("kpGegner").GetComponent<Text>();
        ereignis = GameObject.Find("Ereignis").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GegnerAngreifen(Attacke attacke) {
        gegnermon.LebenVerlieren(attacke.staerke);
        AktualisiereLeben(gegnermon);
        //RundenEnde();
        gegnermon.SpielerAngreifen(gegnermon.attacke1);
    }

    public void SpielerAngreifen(Attacke attacke) {
        spielermon.LebenVerlieren(attacke.staerke);
        AktualisiereLeben(spielermon);
        //RundenAnfang();
    }

    public void LebenVerlieren(int schaden) {
        kp -= schaden;
    }

    //public void RundenAnfang() {
    //    _attacke1.gameObject.SetActive(true);
    //    _attacke2.gameObject.SetActive(true);
    //    _attacke3.gameObject.SetActive(true);
    //    _attacke4.gameObject.SetActive(true);
    //}

    //void RundenEnde() {
    //    _attacke1.gameObject.SetActive(false);
    //    _attacke2.gameObject.SetActive(false);
    //    _attacke3.gameObject.SetActive(false);
    //    _attacke4.gameObject.SetActive(false);
    //}

    void AktualisiereLeben(Pokemon pokemon) {
        kpGegner.text = gegnermon.kp.ToString();
        kpSpieler.text = spielermon.kp.ToString();
        if (gegnermon.kp < 1) {
            ereignis.text = gegnermon.pokemon + " wurde besiegt!";
        }
        if (spielermon.kp < 1) {
            ereignis.text = spielermon.pokemon + " wurde besiegt!";
        }
    }
}
