n = int(input("Введите количество фильмов:"))
summ = 0
for i in range(n):
    time = int(input("Введите длительность фильма {i+1} : "))
    summ += time
print(summ)