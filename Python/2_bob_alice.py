
def getResult(a,b):
    score_result = [0, 0]

    for i ,j in enumerate(zip(a, b)):
        if a[i] > b[i]:
            score_result[0] += 1#a[i]
        elif a[i] < b[i]:
            score_result[1] += 1 #b[i]
        # else:
    return score_result


if __name__ == '__main__':
    alice = [1,2,3]
    bob = [3,2,1]

    result = getResult(alice, bob)
    print(result)