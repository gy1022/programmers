using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Solution
{
    public string solution(string code)
    {
        // 결과 문자열
        string ret = "";
        // mode 초기값
        int mode = 0;

        // code가 빈 문자열이면 "EMPTY" 반환
        if (code.Length == 0)
            return "EMPTY";

        // code의 각 문자를 처리
        for (int i = 0; i < code.Length; i++)
        {
            // mode가 0일 때
            if (mode == 0)
            {
                // code[i]가 "1"이 아니면서 idx가 짝수인 경우
                if (code[i] != '1' && i % 2 == 0)
                {
                    ret += code[i];
                }
                // code[i]가 "1"인 경우 mode를 1로 변경
                else if (code[i] == '1')
                {
                    mode = 1;
                }
            }
            // mode가 1일 때
            else if (mode == 1)
            {
                // code[i]가 "1"이 아니면서 idx가 홀수인 경우
                if (code[i] != '1' && i % 2 == 1)
                {
                    ret += code[i];
                }
                // code[i]가 "1"인 경우 mode를 0으로 변경
                else if (code[i] == '1')
                {
                    mode = 0;
                }
            }
        }

        // 결과가 빈 문자열인 경우 "EMPTY" 반환, 아니면 결과 반환
        return ret.Length == 0 ? "EMPTY" : ret;
    }
}