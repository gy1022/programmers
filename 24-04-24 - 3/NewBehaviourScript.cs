using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public string solution(string code)
    {
        // ��� ���ڿ�
        string ret = "";
        // mode �ʱⰪ
        int mode = 0;

        // code�� �� ���ڿ��̸� "EMPTY" ��ȯ
        if (code.Length == 0)
            return "EMPTY";

        // code�� �� ���ڸ� ó��
        for (int i = 0; i < code.Length; i++)
        {
            // mode�� 0�� ��
            if (mode == 0)
            {
                // code[i]�� "1"�� �ƴϸ鼭 idx�� ¦���� ���
                if (code[i] != '1' && i % 2 == 0)
                {
                    ret += code[i];
                }
                // code[i]�� "1"�� ��� mode�� 1�� ����
                else if (code[i] == '1')
                {
                    mode = 1;
                }
            }
            // mode�� 1�� ��
            else if (mode == 1)
            {
                // code[i]�� "1"�� �ƴϸ鼭 idx�� Ȧ���� ���
                if (code[i] != '1' && i % 2 == 1)
                {
                    ret += code[i];
                }
                // code[i]�� "1"�� ��� mode�� 0���� ����
                else if (code[i] == '1')
                {
                    mode = 0;
                }
            }
        }

        // ����� �� ���ڿ��� ��� "EMPTY" ��ȯ, �ƴϸ� ��� ��ȯ
        return ret.Length == 0 ? "EMPTY" : ret;
    }
}