

class BinarySearch:
    def __init__(self, data):
        self.data = data
        self.left_child = None
        self.right_child = None



def main():
    node_1 = BinarySearch(50)
    node_2 = BinarySearch(20)
    node_3 = BinarySearch(11)

    node_1.left_child = node_2
    node_1.right_child = node_3

    node_data = node_1.data
    node_left = node_1.left_child
    node_right = node_1.right_child

    node_list = [node_data, node_left, node_right]
    print(node_list)

if __name__ == "__main__":
    main()