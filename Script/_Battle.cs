using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Battle : MonoBehaviour {

    public GameObject GameObject_Dragon;
    public GameObject GameObject_Knight;
    private DragonWarrior Dragonwarrior;
    private Knight knight;
    public Text t1;
    public Text t2;

    void Awake()
    {
        Dragonwarrior = GameObject_Dragon.GetComponent<DragonWarrior>();
        knight = GameObject_Knight.GetComponent<Knight>();
    }

    void Update() {
        if (Dragonwarrior.Dicision == true) // if Player Click Dicision
        {
            if (Dragonwarrior.eState_Move == DragonWarrior.State_Move.forword) // forword
            {
                if (Dragonwarrior.eState_Fence == DragonWarrior.State_Fence.offence) // offence
                {
                    switch (knight.eState_Move)
                    {
                        case Knight.State_Move.forword:
                            if (knight.eState_Fence == Knight.State_Fence.offence) // Dragon forword,offence Knight forword offence
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 1.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 1.25);
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(2);
                                knight.setAni(2);
                            }
                            else // Dragon forword,offence Knight forword defence
                            {
                                Dragonwarrior.LostHealth(((Dragonwarrior.Player_Strength * 4) * 0.5) * 1.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.33);
                                t1.transform.Translate(new Vector2(-75, 0));
                                t2.transform.Translate(new Vector2(-75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(-2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(-2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(3);
                                knight.setAni(4);
                            }
                            break;
                        case Knight.State_Move.backword: // Dragon forword,offence Knight backword offence
                            if (knight.eState_Fence == Knight.State_Fence.offence)
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 1.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 1.25);
                                t1.transform.Translate(new Vector2(75, 0));
                                t2.transform.Translate(new Vector2(75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(2);
                                knight.setAni(1);
                            }
                            else // Dragon forword,offence Knight backword defence
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 0.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.75);
                                t1.transform.Translate(new Vector2(75, 0));
                                t2.transform.Translate(new Vector2(75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(2);
                                knight.setAni(3);
                            }
                            break;
                        default:
                            break;
                    }
                }
                else // defence
                {
                    switch (knight.eState_Move)
                    {
                        case Knight.State_Move.forword:
                            if (knight.eState_Fence == Knight.State_Fence.offence) // Dragon forword,defence Knight forword offence
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 0.33);
                                knight.LostHealth(((knight.Enemy_Strength * 4) * 0.5) * 1.25);
                                t1.transform.Translate(new Vector2(75, 0));
                                t2.transform.Translate(new Vector2(75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(4);
                                knight.setAni(3);
                            }
                            else // Dragon forword,defence Knight forword defence
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 0.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.25);
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(4);
                                knight.setAni(4);
                            }
                            break;
                        case Knight.State_Move.backword: // Dragon forword,defence Knight backword offence
                            if (knight.eState_Fence == Knight.State_Fence.offence)
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4)* 0.75);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.25);
                                t1.transform.Translate(new Vector2(-75, 0));
                                t2.transform.Translate(new Vector2(-75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(-2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(-2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(3);
                                knight.setAni(1);
                            }
                            else // Dragon forword,defence Knight backword defence
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 0.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.25);
                                t1.transform.Translate(new Vector2(75, 0));
                                t2.transform.Translate(new Vector2(75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(4);
                                knight.setAni(4);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            else // backword
            {
                if (Dragonwarrior.eState_Fence == DragonWarrior.State_Fence.offence) // offence
                {
                    switch (knight.eState_Move)
                    {
                        case Knight.State_Move.forword:
                            if (knight.eState_Fence == Knight.State_Fence.offence) // Dragon backword,offence Knight forword offence
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 1.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 1.25);
                                t1.transform.Translate(new Vector2(-75, 0));
                                t2.transform.Translate(new Vector2(-75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(-2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(-2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(3);
                                knight.setAni(2);
                            }
                            else // Dragon backword,offence Knight forword defence
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 0.25);
                                knight.LostHealth(((Dragonwarrior.Player_Strength * 4) * 0.75));
                                t1.transform.Translate(new Vector2(75, 0));
                                t2.transform.Translate(new Vector2(75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(1);
                                knight.setAni(3);
                            }
                            break;
                        case Knight.State_Move.backword: // Dragon backword,offence Knight backword offence
                            if (knight.eState_Fence == Knight.State_Fence.offence)
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 1.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 1.25);
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(1);
                                knight.setAni(1);
                            }
                            else // Dragon backword,offence Knight backword defence
                            {
                                Dragonwarrior.LostHealth(((Dragonwarrior.Player_Strength * 4) * 0.5) * 1.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.33);
                                t1.transform.Translate(new Vector2(-75, 0));
                                t2.transform.Translate(new Vector2(-75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(-2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(-2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(3);
                                knight.setAni(4);
                            }
                            break;
                        default:
                            break;
                    }
                }
                else // defence
                {
                    switch (knight.eState_Move)
                    {
                        case Knight.State_Move.forword:
                            if (knight.eState_Fence == Knight.State_Fence.offence) // Dragon backword,defence Knight forword offence
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 0.75);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.25);
                                t1.transform.Translate(new Vector2(-75, 0));
                                t2.transform.Translate(new Vector2(-75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(-2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(-2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(3);
                                knight.setAni(2);
                            }
                            else // Dragon backword,defence Knight forword defence
                            {
                                Dragonwarrior.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.25);
                                knight.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.25);
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(4);
                                knight.setAni(4);
                            }
                            break;
                        case Knight.State_Move.backword: // Dragon backword,defence Knight backword offence
                            if (knight.eState_Fence == Knight.State_Fence.offence)
                            {
                                Dragonwarrior.LostHealth((knight.Enemy_Strength * 4) * 0.33);
                                knight.LostHealth(((knight.Enemy_Strength * 4) * 0.5) * 1.25);
                                t1.transform.Translate(new Vector2(75, 0));
                                t2.transform.Translate(new Vector2(75, 0));
                                GameObject_Dragon.transform.Translate(new Vector2(2, 0));
                                GameObject_Knight.transform.Translate(new Vector2(2, 0));
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(4);
                                knight.setAni(3);
                            }
                            else // Dragon backword,defence Knight backword defence
                            {
                                Dragonwarrior.LostHealth((Dragonwarrior.Player_Strength * 4) * 0.25);
                                knight.LostHealth((knight.Enemy_Strength * 4) * 0.25);
                                Dragonwarrior.Dicision = false;
                                Dragonwarrior.setAni(4);
                                knight.setAni(4);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        if(GameObject_Dragon.transform.position.x == -11) // if Dragon Pos.x touched walls
        {
            t1.transform.Translate(new Vector2 (150, 0));
            t2.transform.Translate(new Vector2 (150, 0));
            GameObject_Dragon.transform.Translate(new Vector2(4, 0));
            knight.transform.Translate(new Vector2(4, 0));
            Dragonwarrior.LostHealth(30);
        }
        if (GameObject_Knight.transform.position.x == 11) // if Knight Pos.x touched walls
        {
            t1.transform.Translate(new Vector2(-150, 0));
            t2.transform.Translate(new Vector2(-150, 0));
            GameObject_Dragon.transform.Translate(new Vector2(-4, 0));
            knight.transform.Translate(new Vector2(-4, 0));
            knight.LostHealth(30);
        }
        t1.text = Dragonwarrior.Player_Health.ToString();
        t2.text = knight.Enemy_Health.ToString();
    }
	
}
