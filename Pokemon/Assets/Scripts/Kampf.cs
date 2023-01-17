using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kampf : MonoBehaviour
{
    public Pokemon pokemon;
    public Attacke attacke1;
    public Attacke attacke2;
    public Attacke attacke3;
    public Attacke attacke4;
    public Button _attacke1;
    public Button _attacke2;
    public Button _attacke3;
    public Button _attacke4;
    [SerializeField]
    private Text attacke1Text;
    [SerializeField]
    private Text attacke2Text;
    [SerializeField]
    private Text attacke3Text;
    [SerializeField]
    private Text attacke4Text;
    // Start is called before the first frame update
    void Start()
    {
        pokemon = GameObject.FindGameObjectWithTag("spieler").GetComponent<Pokemon>();
        attacke1 = pokemon.attacke1;
        attacke2 = pokemon.attacke2;
        attacke3 = pokemon.attacke3;
        attacke4 = pokemon.attacke4;
        _attacke1 = GameObject.Find("Attacke1").GetComponent<Button>();
        attacke1Text = GameObject.Find("Attacke1Text").GetComponent<Text>();
        _attacke2 = GameObject.Find("Attacke2").GetComponent<Button>();
        attacke2Text = GameObject.Find("Attacke2Text").GetComponent<Text>();
        _attacke3 = GameObject.Find("Attacke3").GetComponent<Button>();
        attacke3Text = GameObject.Find("Attacke3Text").GetComponent<Text>();
        _attacke4 = GameObject.Find("Attacke4").GetComponent<Button>();
        attacke4Text = GameObject.Find("Attacke4Text").GetComponent<Text>();
        _attacke1.onClick.AddListener(delegate { pokemon.GegnerAngreifen(attacke1); });
        _attacke2.onClick.AddListener(delegate { pokemon.GegnerAngreifen(attacke2); });
        _attacke3.onClick.AddListener(delegate { pokemon.GegnerAngreifen(attacke3); });
        _attacke4.onClick.AddListener(delegate { pokemon.GegnerAngreifen(attacke4); });
        attacke1Text.text = attacke1.attacke;
        attacke2Text.text = attacke2.attacke;
        attacke3Text.text = attacke3.attacke;
        attacke4Text.text = attacke4.attacke;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
