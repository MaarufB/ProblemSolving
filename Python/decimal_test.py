

from cgitb import reset


def calculate(num):
    ratio = num/5
    return ratio


result = calculate(2)
result = "{:.6}".format(result)
print(result)