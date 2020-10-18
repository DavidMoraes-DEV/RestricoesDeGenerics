using System;
using System.Collections.Generic;
using System.Text;

namespace RestricoesDeGenerics.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable //Para declarar um método como tipo genérico seu tipo deve ser do tipo "T" e na frente do nome do método também tem que se declarar que é do tipo T entre <>: "<T>". E no trecho (where T : IComparable) declaro que esse tipo T tem que ser comparável com outro entrando no assunto da aula de restrições de Generics.
        { /*
            * OUTRAS POSSIBLIDADES DE RESTRIÇÕES:
            
            - where T : struct
            - where T : class
            - where T : unmanaged
            - where T : new()
            - where T : <base type name>
            - where T : U
           */
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0]; //Aqui o tipo da variável max também tem que ser do tipo "T"
            for (int i=1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0) //Aqui entra a funcionalidade da interface IComparable (CompareTo) que retorna valores int -1, 0 e 1)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
