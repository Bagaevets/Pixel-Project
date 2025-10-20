using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventBus
{
    // Структура: Словарь <Тип события, список методов которые нужно вызвать при событии > переменная = инициафлизация
    private static Dictionary<Type, List<Action<GameEvent>>> _eventListeners = new Dictionary<Type, List<Action<GameEvent>>>();
}
