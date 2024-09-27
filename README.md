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
Select Brands.Name from Cars 
LEFT JOIN Brands on Cars.BrandID = Brands.ID
GROUP by Brands.Name, brandid
HAVING COUNT(Cars.id) > 3
```

## Задание 3

```SQL
Select Brands.Name, SUM(price) as SumPrice from Cars 
LEFT JOIN Brands on Cars.BrandID = Brands.ID
GROUP by Brands.Name, BrandID
```

## Задание 4

```SQL
Select TOP 2 Countries.Name, AVG(Pow) as AvgPow from Cars 
LEFT JOIN Brands on Cars.BrandID = Brands.ID
LEFT JOIN Countries on Brands.CountryID = Countries.ID
GROUP BY Countries.Name
ORDER BY AvgPow DESC
```

## Задание 5

```SQL
Select TOP 1 WITH TIES Cars.Name as Car, Brands.Name as Brand from Cars 
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

# Программирование

Проект с решениями расположен в директории `CSharpTest`.
