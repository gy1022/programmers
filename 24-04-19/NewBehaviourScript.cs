using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public string solution(string my_string, string overwrite_string, int s)
    {
        // my_string에서 s부터 overwrite_string의 길이만큼을 overwrite_string으로 대체하여 새로운 문자열을 생성합니다.
        string result = my_string.Substring(0, s) + overwrite_string + my_string.Substring(s + overwrite_string.Length);

        return result;
    }
}