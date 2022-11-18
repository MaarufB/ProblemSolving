
def draw(num):

    for i in range(num):
        for j in range(num - i):
            # print spaces
            print(" ", end="")
        for k in range(i):
            # print stars
            print(f"{k}", end="")
        print("\r")

draw(8)