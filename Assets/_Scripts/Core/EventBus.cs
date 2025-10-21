using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventBus
{
    // ���������: ������� <��� �������, ������ ������� ������� ������ ���������� <����� ��������� ���� �������� (GameEvent) � ���������� void > ���������� = ��������������
    private static Dictionary<Type, List<Action<GameEvent>>> _eventListeners = new Dictionary<Type, List<Action<GameEvent>>>();

    // ����� ��� �������� �� ������� ������������� ����
    public static void Subscribe<T>(Action<T> listener) where T : GameEvent //����� � ������ ����� <��� �������> (�����-���������� ������� ������� ������� ���� T)  T ������ ����� �������� (����������� GameEvent)
    { 
    
    }
}
