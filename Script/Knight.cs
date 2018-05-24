using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour {
    public string Name;
    public int Enemy_Health;
    public int Enemy_Strength;
    public int Enemy_Intelliegence;
    public int Enemy_Agility;
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

    public void LostHealth(double i)
    {
        Enemy_Health -= (int)i;
    }

    public void animate()
    {
        if (Enemy_Health <= 0)
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
    // Update is called once per frame
    void Update () {
        timeSpan += Time.deltaTime;  // 경과 시간을 계속 등록
        if (timeSpan > 1.5)  // 경과 시간이 특정 시간이 보다 커졋을 경우
        {
            animate();
            timeSpan = 0f;
        }
    }
}
