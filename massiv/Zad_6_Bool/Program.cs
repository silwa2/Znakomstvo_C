//L1.10.Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Ложь, В = Ложь, С = Истина:
      //а) (не А или не В) и не С;
      //б) (не А или не В) и(А или В);
      //в) А и В или А и С или не С.
      bool A, B, C;
      bool result_A, result_B, result_C;
      A = false;
      B = false;
      C = true;

      result_A = (!A || !B) && !C;
      result_B = (!A || !B) && (A || B);
      result_C = A && B || A && C || !C;
       
      Console.WriteLine("Вывести \n{0} \n{1} \n{2} ", result_A, result_B, result_C);
      Console.ReadLine();