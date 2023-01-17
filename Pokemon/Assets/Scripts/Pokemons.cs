using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Pokemons : MonoBehaviour
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
    public GegnerPokemon gegnermon;
    public Button _attacke1;
    public Button _attacke2;
    public Button _attacke3;
    public Button _attacke4;
    [SerializeField]
    private Text kpGegner;
    [SerializeField]
    private Text kpSpieler;
    [SerializeField]
    private Text attacke1Text;
    [SerializeField]
    private Text attacke2Text;
    [SerializeField]
    private Text attacke3Text;
    [SerializeField]
    private Text attacke4Text;
    [SerializeField]
    private Text ereignis;

    // Start is called before the first frame update
    void Start()
    {
        gegnermon = GameObject.FindGameObjectWithTag("gegner").GetComponent<GegnerPokemon>();
        kpGegner = GameObject.Find("kpGegner").GetComponent<Text>();
        kpSpieler = GameObject.Find("kpSpieler").GetComponent<Text>();
        _attacke1 = GameObject.Find("Attacke1").GetComponent<Button>();
        attacke1Text = GameObject.Find("Attacke1Text").GetComponent<Text>();
        _attacke2 = GameObject.Find("Attacke2").GetComponent<Button>();
        attacke2Text = GameObject.Find("Attacke2Text").GetComponent<Text>();
        _attacke3 = GameObject.Find("Attacke3").GetComponent<Button>();
        attacke3Text = GameObject.Find("Attacke3Text").GetComponent<Text>();
        _attacke4 = GameObject.Find("Attacke4").GetComponent<Button>();
        attacke4Text = GameObject.Find("Attacke4Text").GetComponent<Text>();
        ereignis = GameObject.Find("Ereignis").GetComponent<Text>();
        _attacke1.onClick.AddListener(delegate { Angreifen(attacke1); });
        _attacke2.onClick.AddListener(delegate { Angreifen(attacke2); });
        _attacke3.onClick.AddListener(delegate { Angreifen(attacke3); });
        _attacke4.onClick.AddListener(delegate { Angreifen(attacke4); });
        attacke1Text.text = attacke1.attacke;
        attacke2Text.text = attacke2.attacke;
        attacke3Text.text = attacke3.attacke;
        attacke4Text.text = attacke4.attacke;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Angreifen(Attacke attacke) {
        gegnermon.LebenVerlieren(attacke.staerke);
        AktualisiereLeben(gegnermon);
        RundenEnde();
        gegnermon.Angreifen(gegnermon.attacke1);
    }

    public void LebenVerlieren(int schaden) {
        kp -= schaden;
    }

    public void RundenAnfang() {
        _attacke1.gameObject.SetActive(true);
        _attacke2.gameObject.SetActive(true);
        _attacke3.gameObject.SetActive(true);
        _attacke4.gameObject.SetActive(true);
    }

    void RundenEnde() {
        _attacke1.gameObject.SetActive(false);
        _attacke2.gameObject.SetActive(false);
        _attacke3.gameObject.SetActive(false);
        _attacke4.gameObject.SetActive(false);
    }

    void AktualisiereLeben(GegnerPokemon gegner) {
        kpGegner.text = gegner.kp.ToString();
        if (gegner.kp < 1) {
            ereignis.text = gegner.pokemon + " wurde besiegt!";
        }
    }
}
