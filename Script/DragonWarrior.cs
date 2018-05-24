using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonWarrior : MonoBehaviour {
    public int Player_Health;
    public int Player_Strength;
    public int Player_Intelliegence;
    public int Player_Agility;
    public bool Dicision;
    public Animator _Ani;

    public enum State_Move
    {
        None,
        forword,
        backword
    };
    public State_Move eState_Move;
    public enum State_Fence
    {
        None,
        offence,
        defence
    };
    public State_Fence eState_Fence;

    public void setAni(int i)
    {
        _Ani.SetInteger("State", i);
    }

    // Click Offence Button
	public void OnClick_Offence()
    {
        Debug.Log("OnClick_Offence!");
        eState_Fence = State_Fence.offence;
    }

    // Click Defence Button
    public void OnClick_Defence()
    {
        Debug.Log("OnClick_Defence!");
        eState_Fence = State_Fence.defence;
    }

    // Click Forword Button
    public void OnClick_Forword()
    {
        Debug.Log("OnClick_Forword!");
        eState_Move = State_Move.forword;
    }

    // Click Backword Button
    public void OnClick_Backword()
    {
        Debug.Log("OnClick_Backword!");
        eState_Move = State_Move.backword;
    }

    public void OnClick_Dicision()
    {
        Debug.Log("OnClick_Dicision!");
        Dicision = true;
    }

    public void LostHealth(double i)
    {
        Player_Health -= (int)i;
    }

    public void animate()
    {
        if(Player_Health <= 0)
        {
            setAni(-1);
        }
        else setAni(0);

    }

    float timeSpan;
    float checkTime;

    public void start()
    {
        timeSpan = 0.0f;
    }

    public void Update()
    {
        timeSpan += Time.deltaTime;  // 경과 시간을 계속 등록
        if (timeSpan > 1.5)  // 경과 시간이 특정 시간이 보다 커졋을 경우
        {
            animate();
            timeSpan = 0;
        }
    }
}
