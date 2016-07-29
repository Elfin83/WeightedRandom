using System;
using System.Collections.Generic;
using System.Linq;


namespace WeightedRandom
{
    public class WeightedRandom
    {
        public static KeyValuePair<TKey, int> GetWeightedRandom<TKey>(Dictionary<TKey, int> dic, Random rndm)
        {
            int rndMemberId = 0,                
                totalWeight = 0,
                partSum = 0;
            KeyValuePair<TKey, int> dicElement = dic.First(); 

            //Получаем сумму весов всех элементов
            //Таблицу значение-вес можно преобразовать в массив типа АБББВВГГГГ,
            //где количество каждого из элементов соответствет его весу. Размер такого массива - totalWeight
            foreach (var n in dic)
            {
                totalWeight += n.Value;
            }

            //Получаем индекс элемента в массиве, описанном выше (фактически никакой массив не создается)
            
            rndMemberId = rndm.Next(0, totalWeight);

            //Ищем какому значению из массива соответствует индекс rndMemberId
            //Каждой группе значений соответствет свой "частичный" вес: А 1, Б 1+3, В 4+2, Г 6+4
            //Искомому значению соответствует частичная сумма не превышающая rndMemberId

            foreach (var n in dic)
            {
                if (rndMemberId < partSum)
                {
                    break;
                }
                partSum += n.Value; //Добавляем значение веса очередного элемента
                dicElement = n;
            }
            return dicElement;
        }

    }
}
