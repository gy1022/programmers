using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine(); //�� ���� �Է��� �޾Ƽ� ���ڿ� ���� s�� ����

        String result = ""; //����� ������ �� ���ڿ� �ʱ�ȭ ����result�� ���ڿ��� �����ϱ� ���� �뵵

        foreach (char c in s) //���ڿ� s�� �� ���ڿ� ���� �ݺ��մϴ�.
        {
            if (char.IsLower(c)) //���� ���ڰ� �ҹ������� Ȯ��
            {
                result += char.ToUpper(c); // += �� result = result + char.ToUpper(c)  //�ҹ��ڸ� �빮�ڷ� �����Ͽ� ����� �߰�
            }
            else if (char.IsUpper(c)) //���� ���ڰ� �빮������ Ȯ��
            {
                result += char.ToLower(c); //�빮�ڸ� �ҹ��ڷ� �����Ͽ� ����� �߰�
            }
        }

        Console.WriteLine(result); //��� ���ڿ��� ���

    }
}