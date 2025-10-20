using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventBus
{
    // ���������: ������� <��� �������, ������ ������� ������� ����� ������� ��� ������� > ���������� = ��������������
    private static Dictionary<Type, List<Action<GameEvent>>> _eventListeners = new Dictionary<Type, List<Action<GameEvent>>>();
}
