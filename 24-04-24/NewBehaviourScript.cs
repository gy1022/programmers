using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    // �ε�ȣ(inequality)�� �����ȣ(equal sign)�� ���� �� ���� n�� m�� ���Ͽ� ����� ��ȯ�ϴ� �Լ�
    public int solution(string ineq, string eq, int n, int m)
    {
        int result = 0;

        // �־��� �ε�ȣ�� ���� ó��
        if (ineq.Equals(">"))
        {
            // �ε�ȣ�� '>'�̰� �����ȣ�� '='�� ��
            if (eq.Equals("="))
            {
                result = n >= m ? 1 : 0;    // n�� m���� ũ�ų� ������ 1, �ƴϸ� 0
            }
            else
            {         // �ε�ȣ�� '>'�̰� �����ȣ�� '='�� �ƴ� ��
                result = n > m ? 1 : 0;         // n�� m���� ũ�� 1, �ƴϸ� 0
            }
        }
        else if (ineq.Equals("<"))
        {
            // �ε�ȣ�� '<'�̰� �����ȣ�� '='�� ��
            if (eq.Equals("="))
            {
                result = n <= m ? 1 : 0;        // n�� m���� �۰ų� ������ 1, �ƴϸ� 0
            }
            else
            {         // �ε�ȣ�� '<'�̰� �����ȣ�� '='�� �ƴ� ��
                result = n < m ? 1 : 0;         // n�� m���� ������ 1, �ƴϸ� 0
            }
        }

        return result;      // ��� ��ȯ
    }
}