# SQL

## Задание 1

```SQL
SELECT child.Name
FROM Cars AS child
JOIN Cars AS parent ON child.BaseID = parent.ID
WHERE child.BrandID = parent.BrandID
```

## Задание 2

```SQL
SELECT Brands.Name from Cars 
LEFT JOIN Brands on Cars.BrandID = Brands.ID
GROUP by Brands.Name, brandid
HAVING COUNT(Cars.id) > 3
```

## Задание 3

```SQL
SELECT Brands.Name, SUM(price) as SumPrice from Cars 
LEFT JOIN Brands on Cars.BrandID = Brands.ID
GROUP by Brands.Name, BrandID
```

## Задание 4

```SQL
SELECT TOP 2 Countries.Name, AVG(Pow) as AvgPow from Cars 
LEFT JOIN Brands on Cars.BrandID = Brands.ID
LEFT JOIN Countries on Brands.CountryID = Countries.ID
GROUP BY Countries.Name
ORDER BY AvgPow DESC
```

## Задание 5

```SQL
SELECT TOP 1 WITH TIES Cars.Name as Car, Brands.Name as Brand from Cars 
LEFT JOIN Brands on Cars.BrandID = Brands.ID
GROUP by Brands.Name, Cars.Name, Price
ORDER by ROW_NUMBER() OVER(PARTITION BY Brands.Name ORDER BY Price);
```

# Логика

## Задание 1

В первые сутки необходимо протестировать по 100 пробирок на каждой мыши (по одной капле с каждой). После того, как одна мышь умрет будет известно в какой сотне пробирок отравленная.

На вторые сутки делим 100 пробирок на 9 мышей (на 8 мышей по 11 пробирок, одной останется 12). В худшем случае круг поиска сузится до 12 пробирок.

На 3 сутки делим 12 пробирок на 6 мышей.

На 4 сутки проверяем оставшиеся две пробирки.

**Ответ:** гарантированно найти отравленную пробирку возможно за 4 суток.

## Задание 2

Необходимо убедиться, в том, что:

- на противоположной стороне карточки A четное число.
- на противоположной стороне карточки D согласная буква.

Переворачивать карточки B и C не нужно так, как на согласные буквы и числа не наложены какие-либо условия.

**Ответ:** 2 карточки A и D.

## Задание 3

Сначала проверяем автомат с маркировкой случайного напитка. Так как на нем точно некорректная маркировка, то по тому напитку, который он выдаст можно сделать вывод о том, что это за автомат (чайный / кофейный).

Если это кофейный автомат, значит:

- с маркировкой кофе будет чайный автомат
- с маркировкой чая будет случайный.

Если это чайный автомат:

- с маркировкой чая будет кофейный автомат
- с маркировкой кофе будет случайный.

**Ответ:** необходима одна попытка.

## Задание 4

Сначала первый человек отвечает, что не знает в какой он шляпе. По этому ответу второй понимает, что на нем не синяя шляпа, так как он видит третьего в синей и если бы на втором была такая же, первый бы сразу мог сказать, что на нем желтая.

**Ответ:** второй человек.

## Задание 5

Нужно разрезать 4 таблетки пополам, раскладывая половины в разные стороны. В таком случае, с каждой стороны суммарно окажется по одной таблетке А и одной таблетке Б.

# Программирование

Проект с решениями расположен в директории `CSharpTest`.
