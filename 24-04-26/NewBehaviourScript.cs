using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int l, int r)
    {
        int[] answer = new int[] { }; // ����� ������ �迭

        // ���� ������ Ư�� ������ �����ϴ� ���ڸ� ã�� �迭�� ��ȯ�մϴ�.
        answer = Enumerable.Range(l, r - l + 1) // ���� ���� ���ڸ� �����մϴ�.
                   .Where(x => x.ToString().All(y => y == '5' || y == '0')) // ������ �����ϴ� ���ڸ� ���͸��մϴ�.
                   .ToArray(); // �迭�� ��ȯ�մϴ�.

        if (answer.Length <= 0) // ��� �迭�� ��� �ִ� ���
            return new int[] { -1 }; // -1�� ��ҷ� ���� �迭�� ��ȯ�մϴ�.
        return answer; // ��� �迭�� ��ȯ�մϴ�.
    }
}