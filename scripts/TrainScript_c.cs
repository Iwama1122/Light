using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript_c : TrainScript_a
{
    protected int c;

    protected override void Start()
    {
        base.Start();
    }

    public int GetNumberC() //パスワードの1桁目がどの数字になっているか
    {
        if (number == 0)
        {
            c = 0;
        }
        else if (number == 1)
        {
            c = 1;
        }
        else if (number == 2)
        {
            c = 2;
        }
        else if (number == 3)
        {
            c = 3;
        }
        else if (number == 4)
        {
            c = 4;
        }
        else if (number == 5)
        {
            c = 5;
        }
        else if (number == 6)
        {
            c = 6;
        }
        else if (number == 7)
        {
            c = 7;
        }
        else if (number == 8)
        {
            c = 8;
        }
        else if (number == 9)
        {
            c = 9;
        }
        return c;
    }
}
