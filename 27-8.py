count_c = 0
a = "Александр"
b = "Петр"
c = "Лев"
d = "Мария"
e = "Елизавета"
f = "Юлия"
while True:
    p = input()
    if p == a or p == b or p == c or p == d or p == e or p == f:
     count_c += 1
    elif p == "END":
     break
print(count_c)
