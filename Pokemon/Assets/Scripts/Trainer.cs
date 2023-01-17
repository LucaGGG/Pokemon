using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainer : MonoBehaviour
{
    public Team team;
    public GameObject pokemon1;
    public GameObject pokemon2;
    public GameObject pokemon3;
    public GameObject pokemon4;
    public GameObject pokemon5;
    public GameObject pokemon6;
    public GameObject aktivesPokemon;
    // Start is called before the first frame update
    void Start()
    {
        pokemon1 = Instantiate(team.pokemon1, transform.position, transform.rotation);
        pokemon2 = Instantiate(team.pokemon2, transform.position, transform.rotation);
        pokemon3 = Instantiate(team.pokemon3, transform.position, transform.rotation);
        pokemon4 = Instantiate(team.pokemon4, transform.position, transform.rotation);
        pokemon5 = Instantiate(team.pokemon5, transform.position, transform.rotation);
        pokemon6 = Instantiate(team.pokemon6, transform.position, transform.rotation);
        aktivesPokemon = pokemon1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
