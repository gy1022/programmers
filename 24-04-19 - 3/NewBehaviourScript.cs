using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class Solution
{
    public string solution(string[] arr)
    {
        StringBuilder sb = new StringBuilder(); // ���ڿ��� ȿ�������� ó���ϱ� ���� StringBuilder ����

        // �迭 arr�� �� ���Ҹ� ��ȸ�ϸ鼭 StringBuilder�� �߰��մϴ�.
        foreach (string str in arr)
        {
            sb.Append(str);
        }

        // StringBuilder�� ����� ���ڿ��� ��ȯ�մϴ�.
        return sb.ToString();
    }
}