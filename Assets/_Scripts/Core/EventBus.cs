using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventBus
{
    // Структура: Словарь <Тип события, список методов которые должны вызываться <метод принимает один параметр (GameEvent) и возвращает void > переменная = инициафлизация
    private static Dictionary<Type, List<Action<GameEvent>>> _eventListeners = new Dictionary<Type, List<Action<GameEvent>>>();

    // Метод для подписки на событие определенного типа
    public static void Subscribe<T>(Action<T> listener) where T : GameEvent //бланк с пустым полем <Тип события> (метод-обработчик который получит событие типа T)  T всегда будет событием (наследником GameEvent)
    { 
    
    }
}
