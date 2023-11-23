n = int(input())
w = int(input())
h = int(input())
k = w * h * n
count_s = 0
count_t = 0
for i in range(k):
    ka = int(input())
    if ka == 1 or 2:
        count_s += 1
    elif ka == 3 or 4:
        count_t += 1
if count_t < count_s:
    print("фильм засвечен")
elif count_t == count_s:
    print("фильм снят ")
else:
    print("фильм затемнен")