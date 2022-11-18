

from cgitb import reset


def calculate(num):
    ratio = num/3
    return ratio


result = calculate(2)
result = "{:.6f}".format(result)
print(result)