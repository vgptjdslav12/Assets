using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {

    public GameObject GameObject_Dragon;
    public GameObject GameObject_Knight;
    private DragonWarrior Dragonwarrior;
    private Knight knight;
    public Text t1;
    public Text t2;
    // Use this for initialization
    void Awake () {
        Dragonwarrior = GameObject_Dragon.GetComponent<DragonWarrior>();
        knight = GameObject_Knight.GetComponent<Knight>();
    }
	
	// Update is called once per frame
	void Update () {
        t1.text = Dragonwarrior.Player_Health.ToString();
        t2.text = knight.Enemy_Health.ToString();
	}
}
