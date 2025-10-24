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
        Type eventType = typeof(T); // Помещаем в eventType информацию о типе данных

        // Проверка на существование нужного списка, если нет, то добавит
        if (!_eventListeners.ContainsKey(eventType))
        {
            _eventListeners[eventType] = new List<Action<GameEvent>>();
        }


        Action<GameEvent> wrappedListener = (e) => listener((T)e);  // объявляется переменная типа Action<GameEvent>в которую помещаем события типа "e" и пребразовываем в тип "T"
        _eventListeners[eventType].Add(wrappedListener);// Добавляем нового подписчика в список подписчиков на это событие
    }

    public static void Unsubscribe<T>(Action<T> listener) where T : GameEvent
    { 
       Type eventType = typeof(T);
        if (!_eventListeners.ContainsKey(eventType)) return;
    }
}