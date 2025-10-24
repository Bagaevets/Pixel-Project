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
        Type eventType = typeof(T); // �������� � eventType ���������� � ���� ������

        // �������� �� ������������� ������� ������, ���� ���, �� �������
        if (!_eventListeners.ContainsKey(eventType))
        {
            _eventListeners[eventType] = new List<Action<GameEvent>>();
        }


        Action<GameEvent> wrappedListener = (e) => listener((T)e);  // ����������� ���������� ���� Action<GameEvent>� ������� �������� ������� ���� "e" � �������������� � ��� "T"
        _eventListeners[eventType].Add(wrappedListener);// ��������� ������ ���������� � ������ ����������� �� ��� �������
    }

    public static void Unsubscribe<T>(Action<T> listener) where T : GameEvent
    { 
       Type eventType = typeof(T);
        if (!_eventListeners.ContainsKey(eventType)) return;
    }
}