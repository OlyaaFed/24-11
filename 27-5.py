count_c = 0
note = int(input("Введите всего"))
while True:
    p = int(input("сцена"))
    if p == 1:
        count_c += 1
    elif p == (-1):
        break
if count_c == note:
    print("YES")
else:
    print("NO")
