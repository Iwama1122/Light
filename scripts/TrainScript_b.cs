using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript_b : TrainScript_a
{
        protected int b;

        protected override void Start()
        {
            base.Start();
        }

    public int GetNumberB() //�p�X���[�h��2���ڂ��ǂ̐����ɂȂ��Ă��邩
    {
        if (number == 0)
        {
            b = 0;
        }
        else if (number == 1)
        {
            b = 1;
        }
        else if (number == 2)
        {
            b = 2;
        }
        else if (number == 3)
        {
            b = 3;
            Debug.Log("b=" + b);
        }
        else if (number == 4)
        {
            b = 4;
        }
        else if (number == 5)
        {
            b = 5;
        }
        else if (number == 6)
        {
            b = 6;
        }
        else if (number == 7)
        {
            b = 7;
        }
        else if (number == 8)
        {
            b = 8;
        }
        else if (number == 9)
        {
            b = 9;
        }
        return b;
    }
}
  