using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public string solution(string my_string, string overwrite_string, int s)
    {
        // my_string���� s���� overwrite_string�� ���̸�ŭ�� overwrite_string���� ��ü�Ͽ� ���ο� ���ڿ��� �����մϴ�.
        string result = my_string.Substring(0, s) + overwrite_string + my_string.Substring(s + overwrite_string.Length);

        return result;
    }
}